namespace Arithmetic_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            /* int x = 8;
            int y = x*4; */
            //int x = 12;
            // Modulus işareti ile kalan bilgisi elde edebiliriz
            //int y = x % 10; 
            int x = 3; // Bir sayının üssünü almak için Math.Pow func. kullanabiliriz. 
                // Fakat Math.Pow() double döndüğü için ya sounucu (int) diyerek integere'a çevirmeliyiz 
            // int y = (int) Math.Pow(x, 2);
                // Yada y'yi double olarak tanımlamalıyız
            double y = Math.Pow(x,2); 
            textBox1.Text = y.ToString();
        }
    }
}