namespace Operators_Boolean
{
    partial class operatorsBoolean
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
            this.showBtn = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(303, 187);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(94, 29);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "showBtn";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(134, 189);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(125, 27);
            this.inputTextBox.TabIndex = 1;
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(444, 188);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(49, 20);
            this.resLabel.TabIndex = 2;
            this.resLabel.Text = "Result";
            // 
            // operatorsBoolean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.showBtn);
            this.Name = "operatorsBoolean";
            this.Text = "Operators Boolean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showBtn;
        private TextBox inputTextBox;
        private Label resLabel;
    }
}