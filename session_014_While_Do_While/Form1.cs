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
            label1.Text = "Sayılar: ";
            int N = Convert.ToInt32(textBox1.Text); 
            int toplam = 0;
            // 0'dan N'e kadar olan tam ardışık tam sayıların toplamı
            // while kullanırken temporary değişkenimin ismini parantez içinde belirtiyorum 
            //int index = 0; // for'dan farklı olarak değişkenimi while'dan önce tanımlamam gerekiyor
            /*
            while (index <= N) // index'in i'sinin küçük olmasına dikkat etmeliyiz 
            {
                toplam = toplam + index;
                index = index + 1;
            }
            */
            // do while'da ise do önce yazılır
            int index = 11;
            do // Do while'ın while'dan farkı do'da ki işlemi en az 1 kere yapar daha sonra while koşulunu kontrol eder
            {
                toplam = toplam + index;
                index = index + 1;
            } while (index <= N);

            label1.Text = toplam.ToString();

        }
    }
}