namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxRes.Text = "";

            int startNum = Convert.ToInt32(textBox1.Text);
            int endNum = Convert.ToInt32(textBox2.Text);

            for (int i=startNum; i<endNum; i++)
            {
                if(i%2 == 0)
                {
                    richTextBoxRes.Text = richTextBoxRes.Text + i.ToString() + ",";
                }
            }
        }
    }
}