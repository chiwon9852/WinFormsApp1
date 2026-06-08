using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CboOption.Items.Add("+");
            CboOption.Items.Add("-");
            CboOption.Items.Add("*");
            CboOption.Items.Add("/");

            String T = CboOption.Items[0].ToString();
            CboOption.Text = T;
            TxtInput1.Text = "0.00";
            TxtInput2.Text = "0.00";
            TxtInput3.Text = "0.00";
            TxtView.Text = "0.00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            string tmp_str = CboOption.Text;
            double value1 = double.Parse(TxtInput1.Text.ToString());
            double value2 = double.Parse(TxtInput2.Text.ToString());
            double value3 = double.Parse(TxtInput3.Text.ToString());
            double tmp_view = 0;

            if (tmp_str == "+")
            {
                tmp_view = value1 + value2 + value3;
                TxtView.Text = tmp_view.ToString();
                return;
            }
            if (tmp_str == "-")
            {
                tmp_view = value1 - value2 - value3;
                TxtView.Text = tmp_view.ToString();
                return;
            }
            if (tmp_str == "*")
            {
                tmp_view = value1 * value2 * value3;
                TxtView.Text = tmp_view.ToString();
                return;
            }
            if (tmp_str == "/")
            {
                tmp_view = value1 / value2 / value3;
                TxtView.Text = tmp_view.ToString();
                return;
            }
        }

        private void BtnViewSwitch_Click(object sender, EventArgs e)
        {
            // ១. កូដសម្រាប់ប្តូរសញ្ញានៅក្នុង ជាលក្ខណៈវិលជុំ (Cycle)
            int totalItems = CboOption.Items.Count;
            if (totalItems > 0)
            {
                // រំកិលទៅ Index បន្ទាប់ (បើដល់ចុងក្រោយ វានឹងត្រឡប់មក ០ វិញ)
                CboOption.SelectedIndex = (CboOption.SelectedIndex + 1) % totalItems;
            }
            string tmp_str = CboOption.Text;
            double value1 = double.Parse(TxtInput1.Text);
            double value2 = double.Parse(TxtInput2.Text);
            double value3 = double.Parse(TxtInput3.Text);
            double tmp_view = 0;

            switch (tmp_str)
            {
                case "+":
                    tmp_view = value1 + value2 + value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "-":
                    tmp_view = value1 - value2 - value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "*":
                    tmp_view = value1 * value2 * value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
                case "/":
                    tmp_view = value1 / value2 / value3;
                    TxtView.Text = tmp_view.ToString();
                    break;
            }
        }
    }
}
