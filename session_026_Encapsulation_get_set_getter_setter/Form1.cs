namespace OOP_Class_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil1 = new Otomobil();
            Otomobil otomobil2 = new Otomobil();


            otomobil1.Renk = "Kırmızı";
            otomobil1.Cant= "Celik";

            otomobil2.Renk = "Sarı";
            otomobil2.Cant= "Normal";

            richTextBox1.Text = "Otomobil1: " + otomobil1.Renk + " " + otomobil1.Cant + " " + otomobil1.getModel() + " " + otomobil1.getGenislik() + " " + otomobil1.getUzunluk() + "\n" +
                                "Otomobil2: " + otomobil2.Renk + " " + otomobil2.Cant + " " + otomobil2.getModel() + " " + otomobil2.getGenislik() + " " + otomobil2.getUzunluk();



        }
    }
}