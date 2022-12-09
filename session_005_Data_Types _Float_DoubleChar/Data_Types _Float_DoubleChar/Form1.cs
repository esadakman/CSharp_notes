namespace Data_Types__Float_DoubleChar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void floatBtn_Click(object sender, EventArgs e)
        {
            // float ve double veri tipleri
            // float: 7 decimal digits, double: 15 decimal digits alır 
            float x = 5.123456789f; // float sayı tanımlarken sonuna 'f' eklemek gerekir,
            //  bunun yerine direkt double kullanılabilir fakat  double daha fazla yer kaplar
            //textBox1.Text = x.ToString();
            textBox1.Text = Convert.ToString(x); // text içine yazacağımız için stringe çevirmemiz gerekiyor
            // float yukarda da belirttiğimiz gibi 7 digit aldığı için form'u çalıştırdığımız zaman son 2 rakam gözükmedi
        }

        private void doubleBtn_Click(object sender, EventArgs e)
        {
            double y = 5.123456789; // double'ı kullanırken sonuna herhangi bir harf yazmamıza gerek yok
            textBox2.Text = Convert.ToString(y); // Text olarak yazacağımız için yine convert işlemi yaptık 
        }

        private void charBtn_Click(object sender, EventArgs e)
        {
            char c; // char 1 byte'lık yer tutar, yerden tasarruf sağlamış oluruz
            c = 'w'; // tek tırnak olarak yazmamız gerekir
            textBox3.Text = Convert.ToString(c);
        }

        private void calculateGrades_Click(object sender, EventArgs e)
        {
            // bütün tanımlamaları aynı satırda yapabiliriz
            //int not1, not2, not3;
            //double ortalama; // int yazarak hesaplatırsak küsürat alamayız
            double not1, not2, not3;
            double ortalama; // int yazarak hesaplatırsak küsürat alamayız
            not1 = Convert.ToInt16(not1Text.Text);
            not2 = Convert.ToInt16(not2Text.Text);
            not3 = Convert.ToInt16(not3Text.Text);
            /*  Input'u küsüratlı girmek istiyosak form tarafından ',' ile girmemiz gerekir, burdan gireceksek '.' ile girebiliriz
            değişkenimide burda ToDouble olarak değiştirmem gerekir
            not1 = Convert.ToDouble(not1Text.Text);
            not2 = Convert.ToDouble(not2Text.Text);
            not3 = Convert.ToDouble(not3Text.Text); */

            //ortalama = (not1 + not2 + not3) / 3; // direkt böyle yazarsak küsüratlı rakamları bize vermeyebilir  bu yüzden => 
            //ortalama = (double)(not1 + not2 + not3) / 3; //  double yazarak küsüratlı sonuçlar alabiliriz (typecasting)
            ortalama = (not1 + not2 + not3) / 3;
            //  değişkenimizi ilk başta tanımlarken direkt double olarak tanımlarsak typecasting'e gerek kalmaz
            
            resultText.Text = Convert.ToString(ortalama);

        }
    }
}