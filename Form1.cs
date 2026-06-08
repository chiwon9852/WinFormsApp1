namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {            // ១. ប្រកាស variable សម្រាប់ទុកលេខ
            Double value1, value2, value3;

            // ២. ប្រើ TryParse ជាមួយពាក្យ "out" ដើម្បីទាញយកលេខ
            Double.TryParse(TxtValue1.Text, out value1);
            Double.TryParse(TxtValue2.Text, out value2);
            Double.TryParse(TxtValue3.Text, out value3);

            // ៣. បូកលេខចូលគ្នា
            Double Result = value1 * value2 * value3;

            // ៤. បង្ហាញលទ្ធផល
            TxtResult.Text = Result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double value1, value2, value3;
            Double.TryParse(TxtValue1.Text, out value1);
            Double.TryParse(TxtValue2.Text, out value2);
            Double.TryParse(TxtValue3.Text, out value3);
            Double Result = value1 / value2 / value3;
            TxtResult.Text = Result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtValue1.Text = "0.00";
            TxtValue2.Text = "0.00";
            TxtValue3.Text = "0.00";
            TxtResult.Text = "0.00";
            //textAligment
            TxtValue1.TextAlign = HorizontalAlignment.Center;
            TxtValue2.TextAlign = HorizontalAlignment.Center;
            TxtValue3.TextAlign = HorizontalAlignment.Center;
            TxtResult.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double value1, value2, value3;
            Double.TryParse(TxtValue1.Text, out value1);
            Double.TryParse(TxtValue2.Text, out value2);
            Double.TryParse(TxtValue3.Text, out value3);
            Double Result = value1 + value2 + value3;
            TxtResult.Text = Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double value1, value2, value3;
            Double.TryParse(TxtValue1.Text, out value1);
            Double.TryParse(TxtValue2.Text, out value2);
            Double.TryParse(TxtValue3.Text, out value3);
            Double Result = value1 - value2 - value3;
            TxtResult.Text = Result.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Double value1, value2, value3;
            Double.TryParse(TxtValue1.Text, out value1);
            Double.TryParse(TxtValue2.Text, out value2);
            Double.TryParse(TxtValue3.Text, out value3);
            Double Result = value1 % value2 % value3;
            TxtResult.Text = Result.ToString();
        }
    }
}
