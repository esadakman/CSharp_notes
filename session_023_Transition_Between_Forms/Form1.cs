namespace Transition_Between_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2 form2 = new Form2();
            // form2.ShowDialog(); // ShowDialog sayesinde modal ekliyoruz ama ilk formumuza bu durumda tıklayamıyoruz
            Form2 form2 = new Form2();
            this.Hide(); // İlk Formumuzu kapatmak için öncelikle `this.Hide();` komutumuzu giriyoruz
            form2.Show();
        }
    }
}