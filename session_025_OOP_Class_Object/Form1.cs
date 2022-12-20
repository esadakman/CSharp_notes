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


            otomobil1.renk = "Kırmızı";
            otomobil1.cant= "Celik";

            otomobil2.renk = "Sarı";
            otomobil2.cant= "Normal";

            richTextBox1.Text = "Otomobil1: " + otomobil1.renk + " " + otomobil1.cant + otomobil1.getModel() + otomobil1.getGenislik() + "\n" +
                                "Otomobil2: " + otomobil2.renk + " " + otomobil2.cant + otomobil2.getModel();



        }
    }
}