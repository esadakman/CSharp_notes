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
            Console.WriteLine("Test");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + "in karesi" + x*x);

        }
    }
}