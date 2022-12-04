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
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMsg.Location = new System.Drawing.Point(56, 36);
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
            this.textBoxMsg.Location = new System.Drawing.Point(237, 41);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(241, 34);
            this.textBoxMsg.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(56, 116);
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
            this.comboBoxNames.Location = new System.Drawing.Point(543, 150);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(265, 28);
            this.comboBoxNames.TabIndex = 3;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(543, 46);
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
            this.labelWrittenName.Location = new System.Drawing.Point(914, 116);
            this.labelWrittenName.Name = "labelWrittenName";
            this.labelWrittenName.Size = new System.Drawing.Size(70, 28);
            this.labelWrittenName.TabIndex = 5;
            this.labelWrittenName.Text = "label1";
            // 
            // labelChange
            // 
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChange.Location = new System.Drawing.Point(914, 47);
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
            this.listBoxPaths.Location = new System.Drawing.Point(544, 206);
            this.listBoxPaths.Name = "listBoxPaths";
            this.listBoxPaths.Size = new System.Drawing.Size(264, 124);
            this.listBoxPaths.TabIndex = 7;
            // 
            // addNameAll
            // 
            this.addNameAll.Location = new System.Drawing.Point(543, 95);
            this.addNameAll.Name = "addNameAll";
            this.addNameAll.Size = new System.Drawing.Size(256, 26);
            this.addNameAll.TabIndex = 8;
            this.addNameAll.Text = "Add Name to Combo and ListBox";
            this.addNameAll.UseVisualStyleBackColor = true;
            this.addNameAll.Click += new System.EventHandler(this.addNameAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 427);
            this.Controls.Add(this.addNameAll);
            this.Controls.Add(this.listBoxPaths);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelWrittenName);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.btnMsg);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}