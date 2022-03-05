using IT_Test.Data;
using IT_Test.Loca;
using IT_Test.Properties;
using IT_Test.Views;
using System.ComponentModel;
using System.Diagnostics;

namespace IT_Test
{
    public partial class EditMode : Form
    {
        private readonly FileRepository _repository;

        private Question _selectedQuestion;

        private readonly Button[] _buttons;
        private readonly Button[] _countButtons;

        private readonly BindingList<Question> _questions;

        public EditMode()
        {
            InitializeComponent();

            this.Text = MyStrings.Editor;
            editButtonNew.Text = MyStrings.New;
            editButtonSave.Text = MyStrings.Save;
            editButtonDelete.Text = MyStrings.Delete;
            editVariantsLabel.Text = MyStrings.Variants;
            editCheckBoxMultipleAnswers.Text = MyStrings.MultipleAnswers;
            editTemplateLabel.Text = MyStrings.Templates;
            checkBoxTextDescription.Text = MyStrings.CheckBoxTextDescription;

            _buttons = new[] {
                editButton1,
                editButton2,
                editButton3,
                editButton4,
                editButton5,
                editButton6,
            };

            _countButtons = new[] {
                editButtonCount1,
                editButtonCount2,
                editButtonCount3,
            };

            for (int i = 0; i < _buttons.Length; i++)
            {
                var button = _buttons[i];
                button.MouseDown += answerButton_MouseDown;
            }

            for (int i = 0; i < _countButtons.Length; i++)
            {
                var button = _countButtons[i];
                button.Click += answerButtonCount_Click;
            }
            _repository = new FileRepository();
            _repository.Load();

            _questions = new BindingList<Question>(_repository.Questions);

            _namesList.DisplayMember = nameof(Question.Name);
            _namesList.DataSource = _questions;

            editQuestionName.DataBindings.Add("Text", _questions, nameof(Question.Name));
            editQuestionText.DataBindings.Add("Text", _questions, nameof(Question.Text));

            SelectLastQuestion();
        }

        private void SelectLastQuestion()
        {
            _namesList.SelectedIndex = _questions.Count - 1;
        }

        private void RefreshButtons()
        {
            _selectedQuestion.ValidateAnswers();

            IsMultipleChecker();

            HideButtons();

            for (int i = 0; i < _selectedQuestion.Answers.Count; i++)
            {
                _buttons[i].Text = _selectedQuestion.Answers[i].Text;
                _buttons[i].BackgroundImage = _selectedQuestion.Answers[i].IsCorrect ?
    Resources.btnCorrect : Resources.btn;
            }

            for (int i = 0; i < _countButtons.Length; i++)
            {
                _countButtons[i].BackgroundImage = ((i + 1) == (_selectedQuestion.Answers.Count / 2)) ?
    Resources.btnCorrect : Resources.btn;
            }
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

        private void EditButton(Answer answer)
        {
            EditButton editButton = new(answer.Text)
            {
                StartPosition = FormStartPosition.CenterParent,
                Location = Location
            };

            DialogResult dr = editButton.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                answer.Text = editButton.AnswerText;
                RefreshButtons();
            }
        }

        private void namesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_namesList.SelectedIndex == -1)
            {
                return;
            }

            _selectedQuestion = _questions[_namesList.SelectedIndex];
            RefreshButtons();
        }

        private Answer GetAnswer(object? sender)
        {
            var index = Array.IndexOf(_buttons, sender);
            return _selectedQuestion.Answers[index];
        }

        private void answerButton_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EditButton(GetAnswer(sender));
            }
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Middle)
            {

                if (!_selectedQuestion.IsMultiple)
                {
                    foreach (var answer in _selectedQuestion.Answers)
                    {
                        answer.IsCorrect = false;
                    }
                    GetAnswer(sender).IsCorrect = true;
                }
                else
                {
                    GetAnswer(sender).IsCorrect = GetAnswer(sender).IsCorrect? false : true;
                }

                RefreshButtons();
            }
        }
        private void answerButtonCount_Click(object? sender, EventArgs e)
        {
            var buttonIndex = Array.IndexOf(_countButtons, sender);
            var count = (buttonIndex + 1) * 2;

            if (count == _selectedQuestion.Answers.Count)
            {
                return;
            }

            do
            {
                if (count < _selectedQuestion.Answers.Count)
                {
                    _selectedQuestion.Answers.RemoveAt(_selectedQuestion.Answers.Count - 1);
                }
                else
                {
                    _selectedQuestion.Answers.Add(new Answer($"{MyStrings.Answer} {_selectedQuestion.Answers.Count + 1}"));
                }
            }
            while (count != _selectedQuestion.Answers.Count);
            RefreshButtons();
        }

        private void editButtonDelete_Click(object sender, EventArgs e)
        {
            if (_questions.Count <= 1 || _selectedQuestion == null)
            {
                return;
            }

            if (MessageBox.Show(MyStrings.DeleteQuestion, "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                _questions.Remove(_selectedQuestion);
                SelectLastQuestion();
            }
        }

        private void editButtonNew_Click(object sender, EventArgs e)
        {
            _questions.Add(new Question($"{MyStrings.Question} {_questions.Count + 1}", $"{MyStrings.QuestionText} {_questions.Count + 1}", false)
            {
                Answers = new List<Answer>
                {
                    new Answer($"{MyStrings.Answer} 1", true),
                    new Answer($"{MyStrings.Answer} 2"),
                    new Answer($"{MyStrings.Answer} 3"),
                    new Answer($"{MyStrings.Answer} 4"),
                }
            });
            SelectLastQuestion();
        }

        private void editButtonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            _repository.Save();
        }

        private void EditMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(MyStrings.SaveWithExit, String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Save();
            }
        }

        private void IsMultipleChecker()
        {
            checkBoxTextDescription.Visible = _selectedQuestion.IsMultiple;
            editCheckBoxMultipleAnswers.Checked = _selectedQuestion.IsMultiple;
        }

        private void editCheckBoxMultipleAnswers_CheckedChanged(object sender, EventArgs e)
        {
            if (editCheckBoxMultipleAnswers.Checked)
            {
                _selectedQuestion.IsMultiple = true;
            }
            else
            {
                _selectedQuestion.IsMultiple = false;
                _selectedQuestion.ValidateAnswers();
                RefreshButtons();
            }
            IsMultipleChecker();
        }
    }
}
