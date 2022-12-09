namespace Arithmetic_Operations
{
    partial class Geometric_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geometric_Calculator));
            this.calculateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kareLabelSonuc = new System.Windows.Forms.Label();
            this.kareKenarTextbox = new System.Windows.Forms.TextBox();
            this.kareLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.diktortgenLabelSonuc = new System.Windows.Forms.Label();
            this.dikdortgenUzunTextbox = new System.Windows.Forms.TextBox();
            this.dikdortgenKısaTextbox = new System.Windows.Forms.TextBox();
            this.dikdörtgenLabel2 = new System.Windows.Forms.Label();
            this.dikdörtgenLabel1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.daireLabelSonuc = new System.Windows.Forms.Label();
            this.daireYariCapTextbox = new System.Windows.Forms.TextBox();
            this.daireLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.calculateBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateBtn.Location = new System.Drawing.Point(328, 353);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(309, 71);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 90);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(303, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geometric Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.kareLabelSonuc);
            this.panel2.Controls.Add(this.kareKenarTextbox);
            this.panel2.Controls.Add(this.kareLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(4, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 214);
            this.panel2.TabIndex = 3;
            // 
            // kareLabelSonuc
            // 
            this.kareLabelSonuc.AutoSize = true;
            this.kareLabelSonuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kareLabelSonuc.Location = new System.Drawing.Point(8, 173);
            this.kareLabelSonuc.Name = "kareLabelSonuc";
            this.kareLabelSonuc.Size = new System.Drawing.Size(22, 25);
            this.kareLabelSonuc.TabIndex = 6;
            this.kareLabelSonuc.Text = "0";
            // 
            // kareKenarTextbox
            // 
            this.kareKenarTextbox.Location = new System.Drawing.Point(8, 130);
            this.kareKenarTextbox.Name = "kareKenarTextbox";
            this.kareKenarTextbox.Size = new System.Drawing.Size(125, 27);
            this.kareKenarTextbox.TabIndex = 5;
            this.kareKenarTextbox.Text = "0";
            // 
            // kareLabel
            // 
            this.kareLabel.AutoSize = true;
            this.kareLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kareLabel.Location = new System.Drawing.Point(8, 101);
            this.kareLabel.Name = "kareLabel";
            this.kareLabel.Size = new System.Drawing.Size(228, 25);
            this.kareLabel.TabIndex = 1;
            this.kareLabel.Text = "Kare Kenar Uzunluğu (m)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.diktortgenLabelSonuc);
            this.panel3.Controls.Add(this.dikdortgenUzunTextbox);
            this.panel3.Controls.Add(this.dikdortgenKısaTextbox);
            this.panel3.Controls.Add(this.dikdörtgenLabel2);
            this.panel3.Controls.Add(this.dikdörtgenLabel1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(338, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 214);
            this.panel3.TabIndex = 4;
            // 
            // diktortgenLabelSonuc
            // 
            this.diktortgenLabelSonuc.AutoSize = true;
            this.diktortgenLabelSonuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diktortgenLabelSonuc.Location = new System.Drawing.Point(17, 173);
            this.diktortgenLabelSonuc.Name = "diktortgenLabelSonuc";
            this.diktortgenLabelSonuc.Size = new System.Drawing.Size(22, 25);
            this.diktortgenLabelSonuc.TabIndex = 7;
            this.diktortgenLabelSonuc.Text = "0";
            // 
            // dikdortgenUzunTextbox
            // 
            this.dikdortgenUzunTextbox.Location = new System.Drawing.Point(174, 129);
            this.dikdortgenUzunTextbox.Name = "dikdortgenUzunTextbox";
            this.dikdortgenUzunTextbox.Size = new System.Drawing.Size(125, 27);
            this.dikdortgenUzunTextbox.TabIndex = 5;
            this.dikdortgenUzunTextbox.Text = "0";
            // 
            // dikdortgenKısaTextbox
            // 
            this.dikdortgenKısaTextbox.Location = new System.Drawing.Point(18, 130);
            this.dikdortgenKısaTextbox.Name = "dikdortgenKısaTextbox";
            this.dikdortgenKısaTextbox.Size = new System.Drawing.Size(125, 27);
            this.dikdortgenKısaTextbox.TabIndex = 4;
            this.dikdortgenKısaTextbox.Text = "0";
            // 
            // dikdörtgenLabel2
            // 
            this.dikdörtgenLabel2.AutoSize = true;
            this.dikdörtgenLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dikdörtgenLabel2.Location = new System.Drawing.Point(172, 101);
            this.dikdörtgenLabel2.Name = "dikdörtgenLabel2";
            this.dikdörtgenLabel2.Size = new System.Drawing.Size(111, 25);
            this.dikdörtgenLabel2.TabIndex = 3;
            this.dikdörtgenLabel2.Text = "Uzun Kenar";
            // 
            // dikdörtgenLabel1
            // 
            this.dikdörtgenLabel1.AutoSize = true;
            this.dikdörtgenLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dikdörtgenLabel1.Location = new System.Drawing.Point(17, 101);
            this.dikdörtgenLabel1.Name = "dikdörtgenLabel1";
            this.dikdörtgenLabel1.Size = new System.Drawing.Size(107, 25);
            this.dikdörtgenLabel1.TabIndex = 2;
            this.dikdörtgenLabel1.Text = "Kısa Kenar ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.daireLabelSonuc);
            this.panel4.Controls.Add(this.daireYariCapTextbox);
            this.panel4.Controls.Add(this.daireLabel);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(669, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 211);
            this.panel4.TabIndex = 5;
            // 
            // daireLabelSonuc
            // 
            this.daireLabelSonuc.AutoSize = true;
            this.daireLabelSonuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daireLabelSonuc.Location = new System.Drawing.Point(144, 170);
            this.daireLabelSonuc.Name = "daireLabelSonuc";
            this.daireLabelSonuc.Size = new System.Drawing.Size(22, 25);
            this.daireLabelSonuc.TabIndex = 8;
            this.daireLabelSonuc.Text = "0";
            // 
            // daireYariCapTextbox
            // 
            this.daireYariCapTextbox.Location = new System.Drawing.Point(144, 115);
            this.daireYariCapTextbox.Name = "daireYariCapTextbox";
            this.daireYariCapTextbox.Size = new System.Drawing.Size(125, 27);
            this.daireYariCapTextbox.TabIndex = 6;
            this.daireYariCapTextbox.Text = "0";
            // 
            // daireLabel
            // 
            this.daireLabel.AutoSize = true;
            this.daireLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daireLabel.Location = new System.Drawing.Point(18, 114);
            this.daireLabel.Name = "daireLabel";
            this.daireLabel.Size = new System.Drawing.Size(80, 25);
            this.daireLabel.TabIndex = 4;
            this.daireLabel.Text = "Yarı Çap";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(99, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Geometric_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 505);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Geometric_Calculator";
            this.Text = "Geometric Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button calculateBtn;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label kareLabelSonuc;
        private TextBox kareKenarTextbox;
        private Label kareLabel;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label diktortgenLabelSonuc;
        private TextBox dikdortgenUzunTextbox;
        private TextBox dikdortgenKısaTextbox;
        private Label dikdörtgenLabel2;
        private Label dikdörtgenLabel1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label daireLabelSonuc;
        private TextBox daireYariCapTextbox;
        private Label daireLabel;
        private PictureBox pictureBox3;
    }
}