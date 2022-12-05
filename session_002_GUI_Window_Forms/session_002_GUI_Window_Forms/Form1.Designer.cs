namespace session_001_Visual_Studio
{
    partial class Form1
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
            this.btnMsg = new System.Windows.Forms.Button();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.addName = new System.Windows.Forms.Button();
            this.labelWrittenName = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Button();
            this.listBoxPaths = new System.Windows.Forms.ListBox();
            this.addNameAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.btnRichTextBox = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBtn = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMsg.Location = new System.Drawing.Point(6, 26);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(135, 46);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "btnMsg";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMsg.Location = new System.Drawing.Point(297, 41);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(241, 34);
            this.textBoxMsg.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(6, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Items.AddRange(new object[] {
            "Michael \t",
            "Jim",
            "Dwight",
            "Creed",
            "Pam",
            "Ryan"});
            this.comboBoxNames.Location = new System.Drawing.Point(584, 149);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(265, 28);
            this.comboBoxNames.TabIndex = 3;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(297, 93);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(162, 29);
            this.addName.TabIndex = 4;
            this.addName.Text = "Add Name to Combo";
            this.addName.UseVisualStyleBackColor = true;
            this.addName.Click += new System.EventHandler(this.addName_Click);
            // 
            // labelWrittenName
            // 
            this.labelWrittenName.AutoSize = true;
            this.labelWrittenName.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelWrittenName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWrittenName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWrittenName.Location = new System.Drawing.Point(584, 93);
            this.labelWrittenName.Name = "labelWrittenName";
            this.labelWrittenName.Size = new System.Drawing.Size(70, 28);
            this.labelWrittenName.TabIndex = 5;
            this.labelWrittenName.Text = "label1";
            // 
            // labelChange
            // 
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChange.Location = new System.Drawing.Point(584, 41);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(148, 29);
            this.labelChange.TabIndex = 6;
            this.labelChange.Text = "Label Change";
            this.labelChange.UseVisualStyleBackColor = true;
            this.labelChange.Click += new System.EventHandler(this.labelChange_Click);
            // 
            // listBoxPaths
            // 
            this.listBoxPaths.FormattingEnabled = true;
            this.listBoxPaths.ItemHeight = 20;
            this.listBoxPaths.Items.AddRange(new object[] {
            "Full Stack",
            "Data Science",
            "Cyber Security",
            "AWS "});
            this.listBoxPaths.Location = new System.Drawing.Point(584, 187);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(264, 124);
            this.listBoxPaths.TabIndex = 7;
            // 
            // addNameAll
            // 
            this.addNameAll.Location = new System.Drawing.Point(297, 151);
            this.addNameAll.Name = "addNameAll";
            this.addNameAll.Size = new System.Drawing.Size(256, 26);
            this.addNameAll.TabIndex = 8;
            this.addNameAll.Text = "Add Name to Combo and ListBox";
            this.addNameAll.UseVisualStyleBackColor = true;
            this.addNameAll.Click += new System.EventHandler(this.addNameAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMsg);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Box Operations";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(12, 195);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(254, 116);
            this.richTextBoxText.TabIndex = 10;
            this.richTextBoxText.Text = "Hello C# \nMerhaba C#";
            // 
            // btnRichTextBox
            // 
            this.btnRichTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRichTextBox.Location = new System.Drawing.Point(297, 195);
            this.btnRichTextBox.Name = "btnRichTextBox";
            this.btnRichTextBox.Size = new System.Drawing.Size(129, 29);
            this.btnRichTextBox.TabIndex = 11;
            this.btnRichTextBox.Text = "RichTextBox Button";
            this.btnRichTextBox.UseVisualStyleBackColor = true;
            this.btnRichTextBox.Click += new System.EventHandler(this.btnRichTextBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::session_002_GUI_Window_Forms.Properties.Resources.csharp;
            this.pictureBox1.Location = new System.Drawing.Point(1079, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 369);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date Time Picker";
            // 
            // dateTimePickerBtn
            // 
            this.dateTimePickerBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePickerBtn.Location = new System.Drawing.Point(12, 415);
            this.dateTimePickerBtn.Name = "dateTimePickerBtn";
            this.dateTimePickerBtn.Size = new System.Drawing.Size(238, 43);
            this.dateTimePickerBtn.TabIndex = 15;
            this.dateTimePickerBtn.Text = "Date Time Picker Button";
            this.dateTimePickerBtn.UseVisualStyleBackColor = false;
            this.dateTimePickerBtn.Click += new System.EventHandler(this.dateTimePickerBtn_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(315, 340);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(238, 56);
            this.trackBarVolume.TabIndex = 16;
            // 
            // trackBarBtn
            // 
            this.trackBarBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.trackBarBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.trackBarBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.trackBarBtn.Location = new System.Drawing.Point(315, 415);
            this.trackBarBtn.Name = "trackBarBtn";
            this.trackBarBtn.Size = new System.Drawing.Size(238, 34);
            this.trackBarBtn.TabIndex = 17;
            this.trackBarBtn.Text = "Track Bar Button";
            this.trackBarBtn.UseVisualStyleBackColor = false;
            this.trackBarBtn.Click += new System.EventHandler(this.trackBarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 547);
            this.Controls.Add(this.trackBarBtn);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.dateTimePickerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRichTextBox);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNameAll);
            this.Controls.Add(this.listBoxPaths);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelWrittenName);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.textBoxMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMsg;
        private TextBox textBoxMsg;
        private Button btnDelete;
        private ComboBox comboBoxNames;
        private Button addName;
        private Label labelWrittenName;
        private Button labelChange;
        private ListBox listBoxPaths;
        private Button addNameAll;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxText;
        private Button btnRichTextBox;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button dateTimePickerBtn;
        private TrackBar trackBarVolume;
        private Button trackBarBtn;
    }
}