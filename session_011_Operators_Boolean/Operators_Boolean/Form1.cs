namespace Operators_Boolean
{
    public partial class operatorsBoolean : Form
    {
        public operatorsBoolean()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            int x = 5;
            bool result;
            //result = (x == 5) || (x > 4); // True
            result = (x == 8) && (x > 4);   // False
            resLabel.Text = result.ToString();

            if (result == true) 
                inputTextBox.Text = "Success";
            else if (result == false)
                inputTextBox.Text = "Failure"; 
               
            
        }
    }
}