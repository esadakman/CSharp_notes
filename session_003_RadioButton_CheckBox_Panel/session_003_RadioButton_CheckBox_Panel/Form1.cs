namespace session_001_Visual_Studio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            textBoxMsg.Text = "Session 1:GUI Design";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBoxMsg.Text = ""; 
        }

        private void addName_Click(object sender, EventArgs e)
        {
            comboBoxNames.Items.Add(textBoxMsg.Text);
        }

        private void labelChange_Click(object sender, EventArgs e)
        {
            labelWrittenName.Text= textBoxMsg.Text;
        }

        private void addNameAll_Click(object sender, EventArgs e)
        {
            comboBoxNames.Items.Add(textBoxMsg.Text);
            listBoxPaths.Items.Add(textBoxMsg.Text); 
        }

        private void btnRichTextBox_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = richTextBoxText.Text + "\n" + "Hello World";
        }

        private void dateTimePickerBtn_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = richTextBoxText.Text + "\n" + dateTimePicker1.Text;
            // Eklenen ögenin yeni satırda eklenmesi için '\n' ifadesini ekliyoruz
        }

        private void trackBarBtn_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = richTextBoxText.Text + "\n" + trackBarVolume.Value;
        }
        // (ctrl+alt+x) toolbox shortcut
        // radio button'ın checkbox'tan farkı sadece bir tanesinin seçilebilmesidir
        // radio button'ın default seçili gelmesi için ise 'Checked'  kısmını true yapmamız gerekiyor
        // projeyi çalıştırırken bazen değişiklikler anında gözükmeyebiliyor. öyle bir durumda 'Build' kısmından
        // 'Clean Solution' deyip tekrar çalıştırmalıyız
        // panel kullanarak ekranımı bölebilir, çeşitli customization'lar yapabilirim
        // yorum kısayolu (ctrl+k) + (ctrl+C)
        // solution explorer kısayolu (ctrl+Alt+L)
        // herhangi bir eventi kaldırmak istediğimiz zaman öncelikle ilgili kod satırını silmemiz, ardından ise
        // solution explorerda yer alan Designer'ın üzerine çift tıklayıp hata veren satırları siliyoruz

    }
}