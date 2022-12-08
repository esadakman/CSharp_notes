namespace Variables_Data_Types
{
    public partial class Form1 : Form
    {
        // değişkenimi form dışında tanımlarsak Form1 classında ki diğer yerlerde de kullanabiliriz
        string isim;
        int studentNote1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox2.Text = textBox1.Text;
            //string isim = "Joe"; // Tek satırda tanımlayabileceğim gibi iki ayrı satırda da tanımlayabilirim 
            //string isim;
            //isim = textBox1.Text;
            //textBox2.Text = isim;
            // string istenen yere integer yazdığımız için bu veriyi int'e çevirmemiz gerekiyor
            //veri türü çevirmenin iki yolu bulunuyor bunların ilki Convert.To
            //studentNote1 = Convert.ToInt16(textBox1.Text); // Sayı büyüklüğüne göre ToInt numarasını değiştirebilirim
            // ikinci convert türü ise Int16.Parse(var_name)
            studentNote1 = Int16.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // veri tipleri değişik olduğu için +1 dediğimiz zaman 11 girildiyse '111' olarak bize gösterir
            //isim = isim + 1;
            //label2.Text = isim;
            studentNote1 = studentNote1 + 1;
            //label2.Text = studentNote1;
            // burda ise label2'imin string olması gerekiyor, yani integer'ı stringe çevirmem gerekiyor.
            // bu işlemi ise değişkenimin sonuna ToString() yazarak yapıyorum 
            //label2.Text = studentNote1.ToString();
            // veya Convert.ToString(var_name) diyerek yapabilirim
            label2.Text = Convert.ToString(studentNote1);

        }


    }
}