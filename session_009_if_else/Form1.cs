namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showResBtn_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            int not1 = Convert.ToInt32(textBox1.Text);
            int not2 = Convert.ToInt32(textBox2.Text);
            int ortalama = (not1 + not2) / 2;
            if (ortalama >= 70)
                label1.Text = "Basarılı";
            else if(ortalama >= 50 && ortalama < 70) 
                label1.Text = "Gecti";
            else if (ortalama < 50 && ortalama >=  40)
                label1.Text = "Bütünlemeye kaldı";  
            else
                label1.Text = "Kaldı";


        }
    }
}