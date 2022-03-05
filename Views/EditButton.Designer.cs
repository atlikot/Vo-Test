namespace IT_Test.Views
{
    partial class EditButton
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
            this.editButtonText = new System.Windows.Forms.RichTextBox();
            this.buttonNewValueText = new System.Windows.Forms.Label();
            this.buttonQuickTemplates = new System.Windows.Forms.Label();
            this.editButtonTrue = new System.Windows.Forms.Button();
            this.editButtonFalse = new System.Windows.Forms.Button();
            this.editButtonZero = new System.Windows.Forms.Button();
            this.editButtonUnhandledException = new System.Windows.Forms.Button();
            this.editButtonOne = new System.Windows.Forms.Button();
            this.editButtonStackOverflow = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editButtonNull = new System.Windows.Forms.Button();
            this.editButtonOutOfRange = new System.Windows.Forms.Button();
            this.editButtonSend = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonSend)).BeginInit();
            this.SuspendLayout();
            // 
            // editButtonText
            // 
            this.editButtonText.BackColor = System.Drawing.SystemColors.Menu;
            this.editButtonText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButtonText.Location = new System.Drawing.Point(11, 48);
            this.editButtonText.Name = "editButtonText";
            this.editButtonText.Size = new System.Drawing.Size(350, 50);
            this.editButtonText.TabIndex = 0;
            this.editButtonText.Text = "";
            this.editButtonText.WordWrap = false;
            this.editButtonText.TextChanged += new System.EventHandler(this.editButtonText_TextChanged);
            this.editButtonText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editButtonText_KeyDown);
            // 
            // buttonNewValueText
            // 
            this.buttonNewValueText.AutoSize = true;
            this.buttonNewValueText.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewValueText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNewValueText.ForeColor = System.Drawing.Color.Azure;
            this.buttonNewValueText.Location = new System.Drawing.Point(6, 11);
            this.buttonNewValueText.Name = "buttonNewValueText";
            this.buttonNewValueText.Size = new System.Drawing.Size(360, 25);
            this.buttonNewValueText.TabIndex = 1;
            this.buttonNewValueText.Text = "Введите новое значение для кнопки:";
            // 
            // buttonQuickTemplates
            // 
            this.buttonQuickTemplates.AutoSize = true;
            this.buttonQuickTemplates.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuickTemplates.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuickTemplates.ForeColor = System.Drawing.Color.Azure;
            this.buttonQuickTemplates.Location = new System.Drawing.Point(15, 108);
            this.buttonQuickTemplates.Name = "buttonQuickTemplates";
            this.buttonQuickTemplates.Size = new System.Drawing.Size(144, 19);
            this.buttonQuickTemplates.TabIndex = 2;
            this.buttonQuickTemplates.Text = "Быстрые шаблоны:";
            // 
            // editButtonTrue
            // 
            this.editButtonTrue.Location = new System.Drawing.Point(3, 3);
            this.editButtonTrue.Name = "editButtonTrue";
            this.editButtonTrue.Size = new System.Drawing.Size(75, 23);
            this.editButtonTrue.TabIndex = 3;
            this.editButtonTrue.Text = "True";
            this.editButtonTrue.UseVisualStyleBackColor = true;
            this.editButtonTrue.Click += new System.EventHandler(this.editButtonTrue_Click);
            // 
            // editButtonFalse
            // 
            this.editButtonFalse.Location = new System.Drawing.Point(84, 3);
            this.editButtonFalse.Name = "editButtonFalse";
            this.editButtonFalse.Size = new System.Drawing.Size(75, 23);
            this.editButtonFalse.TabIndex = 4;
            this.editButtonFalse.Text = "False";
            this.editButtonFalse.UseVisualStyleBackColor = true;
            this.editButtonFalse.Click += new System.EventHandler(this.editButtonFalse_Click);
            // 
            // editButtonZero
            // 
            this.editButtonZero.Location = new System.Drawing.Point(275, 3);
            this.editButtonZero.Name = "editButtonZero";
            this.editButtonZero.Size = new System.Drawing.Size(27, 23);
            this.editButtonZero.TabIndex = 5;
            this.editButtonZero.Text = "0";
            this.editButtonZero.UseVisualStyleBackColor = true;
            this.editButtonZero.Click += new System.EventHandler(this.editButtonZero_Click);
            // 
            // editButtonUnhandledException
            // 
            this.editButtonUnhandledException.Location = new System.Drawing.Point(84, 32);
            this.editButtonUnhandledException.Name = "editButtonUnhandledException";
            this.editButtonUnhandledException.Size = new System.Drawing.Size(139, 23);
            this.editButtonUnhandledException.TabIndex = 7;
            this.editButtonUnhandledException.Text = "Unhandled exception";
            this.editButtonUnhandledException.UseVisualStyleBackColor = true;
            this.editButtonUnhandledException.Click += new System.EventHandler(this.editButtonUnhandledException_Click);
            // 
            // editButtonOne
            // 
            this.editButtonOne.Location = new System.Drawing.Point(308, 3);
            this.editButtonOne.Name = "editButtonOne";
            this.editButtonOne.Size = new System.Drawing.Size(27, 23);
            this.editButtonOne.TabIndex = 8;
            this.editButtonOne.Text = "1";
            this.editButtonOne.UseVisualStyleBackColor = true;
            this.editButtonOne.Click += new System.EventHandler(this.editButtonOne_Click);
            // 
            // editButtonStackOverflow
            // 
            this.editButtonStackOverflow.Location = new System.Drawing.Point(165, 3);
            this.editButtonStackOverflow.Name = "editButtonStackOverflow";
            this.editButtonStackOverflow.Size = new System.Drawing.Size(104, 23);
            this.editButtonStackOverflow.TabIndex = 10;
            this.editButtonStackOverflow.Text = "Stack overflow";
            this.editButtonStackOverflow.UseVisualStyleBackColor = true;
            this.editButtonStackOverflow.Click += new System.EventHandler(this.editButtonStackOverflow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.editButtonTrue);
            this.flowLayoutPanel1.Controls.Add(this.editButtonFalse);
            this.flowLayoutPanel1.Controls.Add(this.editButtonStackOverflow);
            this.flowLayoutPanel1.Controls.Add(this.editButtonZero);
            this.flowLayoutPanel1.Controls.Add(this.editButtonOne);
            this.flowLayoutPanel1.Controls.Add(this.editButtonNull);
            this.flowLayoutPanel1.Controls.Add(this.editButtonUnhandledException);
            this.flowLayoutPanel1.Controls.Add(this.editButtonOutOfRange);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 63);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // editButtonNull
            // 
            this.editButtonNull.Location = new System.Drawing.Point(3, 32);
            this.editButtonNull.Name = "editButtonNull";
            this.editButtonNull.Size = new System.Drawing.Size(75, 23);
            this.editButtonNull.TabIndex = 11;
            this.editButtonNull.Text = "NULL";
            this.editButtonNull.UseVisualStyleBackColor = true;
            this.editButtonNull.Click += new System.EventHandler(this.editButtonNull_Click);
            // 
            // editButtonOutOfRange
            // 
            this.editButtonOutOfRange.Location = new System.Drawing.Point(229, 32);
            this.editButtonOutOfRange.Name = "editButtonOutOfRange";
            this.editButtonOutOfRange.Size = new System.Drawing.Size(106, 23);
            this.editButtonOutOfRange.TabIndex = 12;
            this.editButtonOutOfRange.Text = "Out of range";
            this.editButtonOutOfRange.UseVisualStyleBackColor = true;
            this.editButtonOutOfRange.Click += new System.EventHandler(this.editButtonOutOfRange_Click);
            // 
            // editButtonSend
            // 
            this.editButtonSend.BackgroundImage = global::IT_Test.Properties.Resources.send_forward;
            this.editButtonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButtonSend.Location = new System.Drawing.Point(324, 57);
            this.editButtonSend.Name = "editButtonSend";
            this.editButtonSend.Size = new System.Drawing.Size(32, 32);
            this.editButtonSend.TabIndex = 12;
            this.editButtonSend.TabStop = false;
            this.editButtonSend.Click += new System.EventHandler(this.editButtonSend_Click);
            // 
            // EditButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IT_Test.Properties.Resources.btn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 201);
            this.Controls.Add(this.editButtonSend);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonQuickTemplates);
            this.Controls.Add(this.buttonNewValueText);
            this.Controls.Add(this.editButtonText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditButton";
            this.Text = "EditButton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditButton_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editButtonSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox editButtonText;
        private Label label1;
        private Label label2;
        private Button editButtonTrue;
        private Button editButtonFalse;
        private Button editButtonZero;
        private Button editButtonUnhandledException;
        private Button editButtonOne;
        private Button editButtonStackOverflow;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button editButtonNull;
        private Button editButtonOutOfRange;
        private PictureBox editButtonSend;
        private Label buttonNewValueText;
        private Label buttonQuickTemplates;
    }
}