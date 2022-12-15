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
            int[] nums = { 7, 12, 25, 34, 46 };
            string[] students = { "Michael", "Dwight", "Jim", "Pam", "Creed" };

            // for each kullanırken arraylere indexle erişmek zorunda değiliz. Iteratorla erişebiliriz.
            //foreach (string student in students)
            //{
            //    richTextBox1.Text = richTextBox1.Text + student + "\n";
            //    comboBoxStudents.Items.Add(students);
            //}
            foreach (int num in nums)
            {
                richTextBox1.Text = richTextBox1.Text + num + "\n";
                comboBoxStudents.Items.Add(nums);
            }
        }

    }
}