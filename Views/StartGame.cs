using IT_Test.Data;
using IT_Test.Loca;
using IT_Test.Properties;
using System.ComponentModel;
using System.Diagnostics;

namespace IT_Test
{
    public partial class StartGame : Form
    {
        private readonly FileRepository _repository;
        private Question _selectedQuestion;

        private readonly Button[] _buttons;

        private readonly BindingList<Question> _questions;

        private int select;

        private Dictionary<Question, bool> _answeredCorrect;
        private Dictionary<Answer, bool> _answers;

        public StartGame()
        {
            InitializeComponent();

            _buttons = new[] {
                gameButton1,
                gameButton2,
                gameButton3,
                gameButton4,
                gameButton5,
                gameButton6,
            };

            for (int i = 0; i < _buttons.Length; i++)
            {
                var button = _buttons[i];
                button.MouseDown += answerButton_MouseDown;
            }

            _repository = new FileRepository();
            _repository.Load();
            _repository.Questions.Shuffle();

            _questions = new BindingList<Question>(_repository.Questions);
            _answers = new Dictionary<Answer, bool>();
            _answeredCorrect = new Dictionary<Question, bool>();

            foreach (Question question in _questions)
            {
                question.Answers.Shuffle();

                foreach (Answer answer in question.Answers)
                {
                    _answers[answer] = false;
                    Debug.WriteLine(_answers[answer]);
                }
            }

            select = 0;

            ShowQuestion();
        }

        private void answerButton_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle)
            {
                var index = Array.IndexOf(_buttons, sender);
                var selected = _selectedQuestion.Answers[index];

                if (!_selectedQuestion.IsMultiple)
                {
                    foreach (Answer answer in _selectedQuestion.Answers)
                    {
                        _answers[answer] = false;
                    }
                    _answers[selected] = true;
                }
                else
                {
                    _answers[selected] = !_answers[selected];
                }
            }

            RefreshButtons();
        }
        private bool GetAnswerStatus(Answer answer)
        {
            _answers.TryGetValue(answer, out bool selected);
            return selected;
        }
        private void ShowQuestion()
        {
            CheckNextButtons();
            gameName.Text = String.Format(MyStrings.QuestionNameOf, select + 1, _questions.Count);
            gameText.Text = _questions[select].Text;
            gameChooseText.Text = MyStrings.ChooseVariants;
            gameChooseText.Visible = _questions[select].IsMultiple ? true : false;

            _selectedQuestion = _questions[select];

            CenterText();
            RefreshButtons();
        }

        private void RefreshButtons()
        {
            _selectedQuestion.ValidateAnswers();

            HideButtons();

            for (int i = 0; i < _selectedQuestion.Answers.Count; i++)
            {
                var answer = _selectedQuestion.Answers[i];

                _buttons[i].BackgroundImage = GetAnswerStatus(answer) ?
    Resources.btnSelected : Resources.btn;
                _buttons[i].Text = answer.Text;
            }
        }

        private void CenterText()
        {
            gameText.SelectAll();
            gameText.SelectionAlignment = HorizontalAlignment.Center;
            gameText.DeselectAll();
            gameText.SelectionStart = gameText.Text.Length;
            gameText.HideSelection = true;
        }
        private void CheckNextButtons()
        {
            if (select >= 0 && select < _questions.Count)
            {
                return;
            }
            select = select < 0 ? (_questions.Count - 1) : 0;
        }

        private void HideButtons()
        {
            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i].Visible = i < _selectedQuestion.Answers.Count;
            }
            ButtonsTablePanel.RowCount = _selectedQuestion.Answers.Count / 2;

            var _padding = (60 - _selectedQuestion.Answers.Count * 10);

            ButtonsTablePanel.Padding = new Padding(0, _padding, 0, _padding);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            PreviousQuestion();
        }

        private void NextQuestion()
        {
            select++;
            ShowQuestion();
        }
        private void PreviousQuestion()
        {
            select--;
            ShowQuestion();
        }

        private void gameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                PreviousQuestion();
            }
            if (e.KeyCode == Keys.Right)
            {
                NextQuestion();
            }
            if (e.KeyCode == Keys.Enter)
            {
                NextQuestion();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gameEnter_MouseHover(object sender, EventArgs e)
        {
            gameEnter.BackgroundImage = Resources.enter_pressed;
        }

        private void gameEnter_MouseLeave(object sender, EventArgs e)
        {
            gameEnter.BackgroundImage = Resources.enter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
