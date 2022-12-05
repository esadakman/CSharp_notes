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
        }

        private void trackBarBtn_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = richTextBoxText.Text + "\n" + trackBarVolume.Value;
        }
    }
}