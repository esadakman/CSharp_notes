namespace Arithmetic_Operations
{
    public partial class Geometric_Calculator : Form
    {
        public Geometric_Calculator()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            // Kare Alan
            int kareKenarUzunluk = Convert.ToInt16(kareKenarTextbox.Text);
            int alanKare = kareKenarUzunluk * kareKenarUzunluk; // Math.Pow(kareKenarUzunluk, 2)
            kareLabelSonuc.Text = alanKare.ToString();
            // Dikdörtgen Alan
            int dikdörtgenKısaKenar = Convert.ToInt16(dikdortgenKısaTextbox.Text);
            int dikdörtgenUzunKenar = Convert.ToInt16(dikdortgenUzunTextbox.Text); 
            int dikdörtgenAlan = dikdörtgenKısaKenar * dikdörtgenUzunKenar;  
            diktortgenLabelSonuc.Text = dikdörtgenAlan.ToString();
            // Daire Alan
            int daireYariCap = Convert.ToInt16(dikdortgenKısaTextbox.Text); 
            int daireAlan = (int) Math.PI* daireYariCap; // Math.PI double istediği için int'e çevirdik
            daireLabelSonuc.Text = daireAlan.ToString();
        }
         
    }
}