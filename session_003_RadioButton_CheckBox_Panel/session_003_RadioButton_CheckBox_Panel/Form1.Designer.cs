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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerBtn = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBoxGroup = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.checkBoxGroup.SuspendLayout();
            this.radioButtonBox.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.listBoxPaths.Location = new System.Drawing.Point(585, 195);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Ketchup";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 24);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Mayonnaise";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 24);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Ranch";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.Controls.Add(this.checkBox1);
            this.checkBoxGroup.Controls.Add(this.checkBox3);
            this.checkBoxGroup.Controls.Add(this.checkBox2);
            this.checkBoxGroup.Location = new System.Drawing.Point(40, 179);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(128, 125);
            this.checkBoxGroup.TabIndex = 21;
            this.checkBoxGroup.TabStop = false;
            this.checkBoxGroup.Text = "Sauces";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 24);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Small";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 24);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 24);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Large";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonBox
            // 
            this.radioButtonBox.Controls.Add(this.radioButton1);
            this.radioButtonBox.Controls.Add(this.radioButton3);
            this.radioButtonBox.Controls.Add(this.radioButton2);
            this.radioButtonBox.Location = new System.Drawing.Point(40, 344);
            this.radioButtonBox.Name = "radioButtonBox";
            this.radioButtonBox.Size = new System.Drawing.Size(128, 125);
            this.radioButtonBox.TabIndex = 25;
            this.radioButtonBox.TabStop = false;
            this.radioButtonBox.Text = "Coffee Size";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.radioButtonBox);
            this.panel1.Controls.Add(this.checkBoxGroup);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1043, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 550);
            this.panel1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1250, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBarBtn);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.dateTimePickerBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.checkBoxGroup.ResumeLayout(false);
            this.checkBoxGroup.PerformLayout();
            this.radioButtonBox.ResumeLayout(false);
            this.radioButtonBox.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button dateTimePickerBtn;
        private TrackBar trackBarVolume;
        private Button trackBarBtn;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox checkBoxGroup;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox radioButtonBox;
        private Panel panel1;
    }
}