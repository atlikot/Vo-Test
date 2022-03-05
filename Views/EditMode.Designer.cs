namespace IT_Test
{
    partial class EditMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMode));
            this._namesList = new System.Windows.Forms.ListBox();
            this.editQuestionName = new System.Windows.Forms.TextBox();
            this.editButtonCount1 = new System.Windows.Forms.Button();
            this.editQuestionText = new System.Windows.Forms.RichTextBox();
            this.editVariantsLabel = new System.Windows.Forms.Label();
            this.editButtonCount2 = new System.Windows.Forms.Button();
            this.editButtonCount3 = new System.Windows.Forms.Button();
            this.editTemplateComboBox = new System.Windows.Forms.ComboBox();
            this.editTemplateLabel = new System.Windows.Forms.Label();
            this.editButtonDelete = new System.Windows.Forms.Button();
            this.editButtonNew = new System.Windows.Forms.Button();
            this.editCheckBoxMultipleAnswers = new System.Windows.Forms.CheckBox();
            this.editButtonSave = new System.Windows.Forms.Button();
            this.editButton3 = new System.Windows.Forms.Button();
            this.editButton1 = new System.Windows.Forms.Button();
            this.ButtonsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.editButton6 = new System.Windows.Forms.Button();
            this.editButton5 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.editButton4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxTextDescription = new System.Windows.Forms.Label();
            this.ButtonsTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _namesList
            // 
            resources.ApplyResources(this._namesList, "_namesList");
            this._namesList.BackColor = System.Drawing.SystemColors.HotTrack;
            this._namesList.Cursor = System.Windows.Forms.Cursors.Hand;
            this._namesList.ForeColor = System.Drawing.Color.Azure;
            this._namesList.FormattingEnabled = true;
            this._namesList.Name = "_namesList";
            this._namesList.SelectedIndexChanged += new System.EventHandler(this.namesList_SelectedIndexChanged);
            // 
            // editQuestionName
            // 
            this.editQuestionName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.editQuestionName, "editQuestionName");
            this.editQuestionName.Name = "editQuestionName";
            // 
            // editButtonCount1
            // 
            this.editButtonCount1.BackgroundImage = global::IT_Test.Properties.Resources.btnCorrect;
            resources.ApplyResources(this.editButtonCount1, "editButtonCount1");
            this.editButtonCount1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButtonCount1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButtonCount1.Name = "editButtonCount1";
            this.editButtonCount1.UseVisualStyleBackColor = true;
            // 
            // editQuestionText
            // 
            this.editQuestionText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.editQuestionText, "editQuestionText");
            this.editQuestionText.Name = "editQuestionText";
            // 
            // editVariantsLabel
            // 
            resources.ApplyResources(this.editVariantsLabel, "editVariantsLabel");
            this.editVariantsLabel.BackColor = System.Drawing.Color.Transparent;
            this.editVariantsLabel.ForeColor = System.Drawing.Color.Azure;
            this.editVariantsLabel.Name = "editVariantsLabel";
            // 
            // editButtonCount2
            // 
            this.editButtonCount2.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            resources.ApplyResources(this.editButtonCount2, "editButtonCount2");
            this.editButtonCount2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButtonCount2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButtonCount2.Name = "editButtonCount2";
            this.editButtonCount2.UseVisualStyleBackColor = true;
            // 
            // editButtonCount3
            // 
            this.editButtonCount3.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            resources.ApplyResources(this.editButtonCount3, "editButtonCount3");
            this.editButtonCount3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButtonCount3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButtonCount3.Name = "editButtonCount3";
            this.editButtonCount3.UseVisualStyleBackColor = true;
            // 
            // editTemplateComboBox
            // 
            this.editTemplateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTemplateComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.editTemplateComboBox, "editTemplateComboBox");
            this.editTemplateComboBox.Name = "editTemplateComboBox";
            // 
            // editTemplateLabel
            // 
            resources.ApplyResources(this.editTemplateLabel, "editTemplateLabel");
            this.editTemplateLabel.BackColor = System.Drawing.Color.Transparent;
            this.editTemplateLabel.ForeColor = System.Drawing.Color.Azure;
            this.editTemplateLabel.Name = "editTemplateLabel";
            // 
            // editButtonDelete
            // 
            this.editButtonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.editButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.editButtonDelete, "editButtonDelete");
            this.editButtonDelete.Name = "editButtonDelete";
            this.editButtonDelete.UseVisualStyleBackColor = false;
            this.editButtonDelete.Click += new System.EventHandler(this.editButtonDelete_Click);
            // 
            // editButtonNew
            // 
            this.editButtonNew.BackColor = System.Drawing.Color.Azure;
            this.editButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.editButtonNew, "editButtonNew");
            this.editButtonNew.Name = "editButtonNew";
            this.editButtonNew.UseVisualStyleBackColor = false;
            this.editButtonNew.Click += new System.EventHandler(this.editButtonNew_Click);
            // 
            // editCheckBoxMultipleAnswers
            // 
            resources.ApplyResources(this.editCheckBoxMultipleAnswers, "editCheckBoxMultipleAnswers");
            this.editCheckBoxMultipleAnswers.BackColor = System.Drawing.Color.Transparent;
            this.editCheckBoxMultipleAnswers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCheckBoxMultipleAnswers.FlatAppearance.BorderSize = 2;
            this.editCheckBoxMultipleAnswers.ForeColor = System.Drawing.Color.Azure;
            this.editCheckBoxMultipleAnswers.Name = "editCheckBoxMultipleAnswers";
            this.editCheckBoxMultipleAnswers.UseVisualStyleBackColor = false;
            this.editCheckBoxMultipleAnswers.CheckedChanged += new System.EventHandler(this.editCheckBoxMultipleAnswers_CheckedChanged);
            // 
            // editButtonSave
            // 
            this.editButtonSave.BackColor = System.Drawing.Color.Lime;
            this.editButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.editButtonSave, "editButtonSave");
            this.editButtonSave.Name = "editButtonSave";
            this.editButtonSave.UseVisualStyleBackColor = false;
            this.editButtonSave.Click += new System.EventHandler(this.editButtonSave_Click);
            // 
            // editButton3
            // 
            resources.ApplyResources(this.editButton3, "editButton3");
            this.editButton3.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.editButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton3.ForeColor = System.Drawing.Color.Azure;
            this.editButton3.Name = "editButton3";
            this.editButton3.UseVisualStyleBackColor = true;
            // 
            // editButton1
            // 
            resources.ApplyResources(this.editButton1, "editButton1");
            this.editButton1.BackgroundImage = global::IT_Test.Properties.Resources.btnCorrect;
            this.editButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton1.ForeColor = System.Drawing.Color.Azure;
            this.editButton1.Name = "editButton1";
            this.editButton1.UseVisualStyleBackColor = true;
            // 
            // ButtonsTablePanel
            // 
            resources.ApplyResources(this.ButtonsTablePanel, "ButtonsTablePanel");
            this.ButtonsTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsTablePanel.Controls.Add(this.editButton6, 1, 2);
            this.ButtonsTablePanel.Controls.Add(this.editButton5, 0, 2);
            this.ButtonsTablePanel.Controls.Add(this.editButton2, 1, 0);
            this.ButtonsTablePanel.Controls.Add(this.editButton1, 0, 0);
            this.ButtonsTablePanel.Controls.Add(this.editButton4, 1, 1);
            this.ButtonsTablePanel.Controls.Add(this.editButton3, 0, 1);
            this.ButtonsTablePanel.Name = "ButtonsTablePanel";
            // 
            // editButton6
            // 
            resources.ApplyResources(this.editButton6, "editButton6");
            this.editButton6.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.editButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton6.ForeColor = System.Drawing.Color.Azure;
            this.editButton6.Name = "editButton6";
            this.editButton6.UseVisualStyleBackColor = true;
            // 
            // editButton5
            // 
            resources.ApplyResources(this.editButton5, "editButton5");
            this.editButton5.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.editButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton5.ForeColor = System.Drawing.Color.Azure;
            this.editButton5.Name = "editButton5";
            this.editButton5.UseVisualStyleBackColor = true;
            // 
            // editButton2
            // 
            resources.ApplyResources(this.editButton2, "editButton2");
            this.editButton2.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.editButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton2.ForeColor = System.Drawing.Color.Azure;
            this.editButton2.Name = "editButton2";
            this.editButton2.UseVisualStyleBackColor = true;
            // 
            // editButton4
            // 
            resources.ApplyResources(this.editButton4, "editButton4");
            this.editButton4.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.editButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton4.ForeColor = System.Drawing.Color.Azure;
            this.editButton4.Name = "editButton4";
            this.editButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::IT_Test.Properties.Resources.edit;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxTextDescription
            // 
            resources.ApplyResources(this.checkBoxTextDescription, "checkBoxTextDescription");
            this.checkBoxTextDescription.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTextDescription.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxTextDescription.Name = "checkBoxTextDescription";
            // 
            // EditMode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IT_Test.Properties.Resources.background;
            this.Controls.Add(this.checkBoxTextDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonsTablePanel);
            this.Controls.Add(this.editButtonSave);
            this.Controls.Add(this.editCheckBoxMultipleAnswers);
            this.Controls.Add(this.editButtonNew);
            this.Controls.Add(this.editButtonDelete);
            this.Controls.Add(this.editTemplateLabel);
            this.Controls.Add(this.editTemplateComboBox);
            this.Controls.Add(this.editButtonCount3);
            this.Controls.Add(this.editButtonCount2);
            this.Controls.Add(this.editVariantsLabel);
            this.Controls.Add(this.editQuestionText);
            this.Controls.Add(this.editButtonCount1);
            this.Controls.Add(this.editQuestionName);
            this.Controls.Add(this._namesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMode_FormClosing);
            this.ButtonsTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox _namesList;
        private TextBox editQuestionName;
        private Button editButtonCount1;
        private RichTextBox editQuestionText;
        private Label editVariantsLabel;
        private Button editButtonCount2;
        private Button editButtonCount3;
        private ComboBox editTemplateComboBox;
        private Label editTemplateLabel;
        private Button editButtonDelete;
        private Button editButtonNew;
        private CheckBox editCheckBoxMultipleAnswers;
        private Button editButtonSave;
        private Button editButton3;
        private Button editButton1;
        private TableLayoutPanel ButtonsTablePanel;
        private Button editButton6;
        private Button editButton5;
        private Button editButton2;
        private Button editButton4;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label checkBoxTextDescription;
    }
}