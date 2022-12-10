namespace functions
{
    partial class functions
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.summationBtn = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(126, 177);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(125, 27);
            this.number1.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(285, 176);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(125, 27);
            this.number2.TabIndex = 1;
            // 
            // summationBtn
            // 
            this.summationBtn.Location = new System.Drawing.Point(481, 243);
            this.summationBtn.Name = "summationBtn";
            this.summationBtn.Size = new System.Drawing.Size(94, 29);
            this.summationBtn.TabIndex = 2;
            this.summationBtn.Text = "Summation";
            this.summationBtn.UseVisualStyleBackColor = true;
            this.summationBtn.Click += new System.EventHandler(this.summationBtn_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(434, 180);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(19, 20);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(481, 183);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(17, 20);
            this.result.TabIndex = 4;
            this.result.Text = "0";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(257, 183);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(19, 20);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            // 
            // functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.summationBtn);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "functions";
            this.Text = "Functions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox number1;
        private TextBox number2;
        private Button summationBtn;
        private Label equal;
        private Label result;
        private Label plus;
    }
}