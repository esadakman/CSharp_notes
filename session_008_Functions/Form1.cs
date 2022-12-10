namespace functions
{
    public partial class functions : Form
    {
        public functions()
        {
            InitializeComponent();
        }

        /* private void sumAndShow()
        {
            int num1 = Convert.ToInt16(number1.Text);
            int num2 = Convert.ToInt16(number2.Text);
            int toplam = num1 + num2;
            result.Text = toplam.ToString()  
        } */

        /*private void sumAndShowParams(int num1, int num2)
        { 
            int toplam = num1 + num2;
            result.Text = toplam.ToString();
        }*/
            private int sumAndShowParams(int num1, int num2)
            {
                int toplam = num1 + num2;
                return toplam;
            }

        private void summationBtn_Click(object sender, EventArgs e)
        {
            //sumAndShow();
            int num1 = Convert.ToInt16(number1.Text);
            int num2 = Convert.ToInt16(number2.Text);
            //sumAndShowParams(num1,num2);
            int top = sumAndShowParams(num1,num2);
            result.Text = top.ToString();
        }
}
}