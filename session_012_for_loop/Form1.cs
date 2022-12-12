namespace for_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resBtn_Click(object sender, EventArgs e)
        {
            label1.Text= "Sayılar: ";
            int N = Convert.ToInt32(textBox1.Text);
            for (int i=0; i<= N;i++)
            {
                //label1.Text = label1.Text + "," + i.ToString();
                label1.Text = label1.Text + "," + i; // String olduğu zaman typecasting yapmaya gerek kalmıyor

            }
            // int toplam = 0;
            // for (int i = 0; i <= N; i++)
            // {
            //     toplam = toplam + 1;
            //     //label1.Text = label1.Text + "," + i.ToString();
            //     label1.Text = toplam.ToString(); // String olduğu zaman typecasting yapmaya gerek kalmıyor

            // }
        }
    }
}