using System.Xml.Linq;

namespace Switch_Case
{
    public partial class Switch_Case : Form
    {
        public Switch_Case()
        {
            InitializeComponent();
        }

        private void dayBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int day = Convert.ToInt16(textBox1.Text);

            switch(day) // switch kullanacağımız zaman switch yazıp kullanacağımız parametreyi parantez içine yazıyoruz
            {
                case 1:
                    label1.Text = "monday";
                    break;
                case 2:
                    label1.Text = "tuesday";
                    break;
                case 3:
                    label1.Text = "wedneday";
                    break;
                case 4:
                    label1.Text = "thursday";
                    break;
                case 5:
                    label1.Text = "friday";
                    break;
                case 6:
                    label1.Text = "saturday";
                    break;
                case 7:
                    label1.Text = "sunday";
                    break;
                default: 
                    label1.Text = ($"{day} is not a day !"); 
                    break;

            }

        }
    }
}