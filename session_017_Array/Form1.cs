namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int x;
            //int[] array1;
            //double[] array;
            int[] array = { 7, 12, 25, 34, 46 };
            string[] students = { "Michael", "Dwight", "Jim", "Pam", "Creed" };

            //richTextBox1.Text = Convert.ToString(array[1]);
            for (int i = 0; i < array.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + array[i] + "\n" ;
                comboBoxStudents.Items.Add(students[i]); 
            }
        }
         
    }
}