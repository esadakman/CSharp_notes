namespace CSharp_Console
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string number = Console.ReadLine();

            try
            {
                int x = int.Parse(number);
                int y = 10 / x;
                Console.WriteLine("Try içindeyiz");
            }
            catch(FormatException ex) // Hatayı yakalamazsak program crash eder. Bu yüzden hata yakalamaya dikkat etmeliyiz
            {
                Console.WriteLine("Hatalı veri girdiniz..");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra Bölme Hatası");
            }
            finally
            {
                Console.WriteLine("Finally");

            }
            Console.WriteLine("try catch'den çıkıldı");
        }
    }
}