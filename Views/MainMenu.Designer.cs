namespace IT_Test
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainLogoLabel = new System.Windows.Forms.Label();
            this.mainLinkAuthor = new System.Windows.Forms.LinkLabel();
            this.mainVersionLabel = new System.Windows.Forms.Label();
            this.mainButtonStart = new System.Windows.Forms.Button();
            this.mainButtonEdit = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.language_by = new System.Windows.Forms.PictureBox();
            this.language_ru = new System.Windows.Forms.PictureBox();
            this.language_en = new System.Windows.Forms.PictureBox();
            this.languageSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.language_by)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_ru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_en)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLogoLabel
            // 
            resources.ApplyResources(this.mainLogoLabel, "mainLogoLabel");
            this.mainLogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLogoLabel.ForeColor = System.Drawing.Color.Azure;
            this.mainLogoLabel.Name = "mainLogoLabel";
            // 
            // mainLinkAuthor
            // 
            resources.ApplyResources(this.mainLinkAuthor, "mainLinkAuthor");
            this.mainLinkAuthor.BackColor = System.Drawing.Color.Transparent;
            this.mainLinkAuthor.ForeColor = System.Drawing.Color.Azure;
            this.mainLinkAuthor.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.mainLinkAuthor.LinkColor = System.Drawing.Color.Azure;
            this.mainLinkAuthor.Name = "mainLinkAuthor";
            this.mainLinkAuthor.TabStop = true;
            this.mainLinkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mainLinkAuthor_LinkClicked);
            // 
            // mainVersionLabel
            // 
            resources.ApplyResources(this.mainVersionLabel, "mainVersionLabel");
            this.mainVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainVersionLabel.ForeColor = System.Drawing.Color.Azure;
            this.mainVersionLabel.Name = "mainVersionLabel";
            // 
            // mainButtonStart
            // 
            resources.ApplyResources(this.mainButtonStart, "mainButtonStart");
            this.mainButtonStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainButtonStart.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.mainButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButtonStart.ForeColor = System.Drawing.Color.Azure;
            this.mainButtonStart.Name = "mainButtonStart";
            this.mainButtonStart.UseVisualStyleBackColor = false;
            this.mainButtonStart.Click += new System.EventHandler(this.mainButtonStart_Click);
            // 
            // mainButtonEdit
            // 
            resources.ApplyResources(this.mainButtonEdit, "mainButtonEdit");
            this.mainButtonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainButtonEdit.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.mainButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainButtonEdit.ForeColor = System.Drawing.Color.Azure;
            this.mainButtonEdit.Name = "mainButtonEdit";
            this.mainButtonEdit.UseVisualStyleBackColor = false;
            this.mainButtonEdit.Click += new System.EventHandler(this.mainButtonEdit_Click);
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.Azure;
            this.version.Name = "version";
            // 
            // language_by
            // 
            this.language_by.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.language_by, "language_by");
            this.language_by.Cursor = System.Windows.Forms.Cursors.Hand;
            this.language_by.Image = global::IT_Test.Properties.Resources.flag_by;
            this.language_by.Name = "language_by";
            this.language_by.TabStop = false;
            this.language_by.Click += new System.EventHandler(this.language_by_Click);
            // 
            // language_ru
            // 
            this.language_ru.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.language_ru, "language_ru");
            this.language_ru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.language_ru.Image = global::IT_Test.Properties.Resources.flag_ru;
            this.language_ru.Name = "language_ru";
            this.language_ru.TabStop = false;
            this.language_ru.Click += new System.EventHandler(this.language_ru_Click);
            // 
            // language_en
            // 
            this.language_en.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.language_en, "language_en");
            this.language_en.Cursor = System.Windows.Forms.Cursors.Hand;
            this.language_en.Image = global::IT_Test.Properties.Resources.flag_en;
            this.language_en.Name = "language_en";
            this.language_en.TabStop = false;
            this.language_en.Click += new System.EventHandler(this.language_en_Click);
            // 
            // languageSign
            // 
            resources.ApplyResources(this.languageSign, "languageSign");
            this.languageSign.BackColor = System.Drawing.Color.Transparent;
            this.languageSign.ForeColor = System.Drawing.Color.Azure;
            this.languageSign.Name = "languageSign";
            // 
            // MainMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IT_Test.Properties.Resources.background;
            this.Controls.Add(this.languageSign);
            this.Controls.Add(this.language_en);
            this.Controls.Add(this.language_ru);
            this.Controls.Add(this.language_by);
            this.Controls.Add(this.version);
            this.Controls.Add(this.mainButtonEdit);
            this.Controls.Add(this.mainVersionLabel);
            this.Controls.Add(this.mainLinkAuthor);
            this.Controls.Add(this.mainButtonStart);
            this.Controls.Add(this.mainLogoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.language_by)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_ru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_en)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainLogoLabel;
        private LinkLabel mainLinkAuthor;
        private Label mainVersionLabel;
        private Button mainButtonStart;
        private Button mainButtonEdit;
        private Label version;
        private PictureBox language_by;
        private PictureBox language_ru;
        private PictureBox language_en;
        private Label languageSign;
    }
}