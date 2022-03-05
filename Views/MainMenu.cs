using IT_Test.Loca;
using System.Diagnostics;

namespace IT_Test
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            refreshScreen();
            version.Text = "0.27";
        }

        public void refreshScreen()
        {
            this.Text = MyStrings.MainMenu;
            mainButtonStart.Text = MyStrings.StartGame;
            mainButtonEdit.Text = MyStrings.Editor;
            languageSign.Text = MyStrings.Language;
            mainVersionLabel.Text = MyStrings.Version;
            mainLinkAuthor.Text = MyStrings.Author;
            mainLogoLabel.Text = MyStrings.ItTest;
        }

        private void mainButtonEdit_Click(object sender, EventArgs e)
        {
            EditMode editMode = new EditMode();
            editMode.FormClosed += formClosed;
            editMode.StartPosition = FormStartPosition.Manual;
            editMode.Size = Size;
            editMode.Location = Location;
            this.Hide();
            editMode.Show();
        }

        private void mainButtonStart_Click(object sender, EventArgs e)
        {
            StartGame startGame = new StartGame();
            startGame.FormClosed += formClosed;
            startGame.StartPosition = FormStartPosition.Manual;
            startGame.Size = Size;
            startGame.Location = Location;
            this.Hide();
            startGame.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void mainLinkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start https://www.instagram.com/atlikot/?hl=ru"));
            //Process.Start("explorer http://www.google.com");
        }

        private void language_ru_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            refreshScreen();
        }

        private void language_by_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("be-BY");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("be-BY");
            refreshScreen();
        }

        private void language_en_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            refreshScreen();
        }
    }
}