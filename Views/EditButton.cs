using IT_Test.Loca;

namespace IT_Test.Views
{
    public partial class EditButton : Form
    {
        public string AnswerText => editButtonText.Text;

        private readonly string _initialText;

        public EditButton(string text)
        {
            InitializeComponent();

            _initialText = text;
            editButtonText.Text = text;
            editButtonText.SelectionStart = editButtonText.Text.Length;
            buttonNewValueText.Text = MyStrings.NewValueText;
            buttonQuickTemplates.Text = MyStrings.QuickTemplates;
            this.Text = MyStrings.EditButton;
        }

        private void refreshText()
        {
            editButtonText.Focus();
            editButtonText.SelectionStart = editButtonText.TextLength;
        }
        private void editButtonText_TextChanged(object sender, EventArgs e)
        {
            if (!editButtonText.Text.Contains("\n"))
            {
                return;
            }

            editButtonText.Text = editButtonText.Text.Replace("\n", string.Empty);
        }

        private void editButtonTrue_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonTrue.Text;
            refreshText();
        }

        private void editButtonFalse_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonFalse.Text;
            refreshText();
        }

        private void editButtonStackOverflow_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonStackOverflow.Text;
            refreshText();
        }

        private void editButtonZero_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonZero.Text;
            refreshText();
        }

        private void editButtonOne_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonOne.Text;
            refreshText();
        }

        private void editButtonNull_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonNull.Text;
            refreshText();
        }

        private void editButtonUnhandledException_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonUnhandledException.Text;
            refreshText();
        }

        private void editButtonOutOfRange_Click(object sender, EventArgs e)
        {
            editButtonText.Text = editButtonOutOfRange.Text;
            refreshText();
        }

        private void editButtonText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void editButtonSend_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditButton_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_initialText != AnswerText && DialogResult != DialogResult.OK && MessageBox.Show(MyStrings.SaveNewChangesQuestion, MyStrings.TextWasChanged, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
