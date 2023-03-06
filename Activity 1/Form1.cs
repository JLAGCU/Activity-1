//JARED ABRAMS//CST-150//05MARCH2023//THIS IS MY OWN WORK

namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddNumbers_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int sumNumber = 0;
            int.TryParse(textBox_FirstNumber.Text, out firstNumber);
            int.TryParse(textBox_SecondNumber.Text, out secondNumber);
            sumNumber = firstNumber + secondNumber;
            textBox_Sum.Text = sumNumber.ToString();
        }
    }
}