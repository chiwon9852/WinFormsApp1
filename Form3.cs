using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TxtStart.Text = "0";
            TxtEnd.Text = "0";
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            listBoxView.Items.Clear();

            // Parse input values from text boxes
            if (int.TryParse(TxtStart.Text, out int start) && int.TryParse(TxtEnd.Text, out int end))
            {
                // Outer loop for lines
                for (int i = start; i <= end; i++)
                {
                    string lineText = "Line " + i + ": ";

                    // Inner loop to build the sequence string (e.g., 12345678)
                    for (int j = start; j <= end; j++)
                    {
                        lineText += j;
                    }

                    // Add the constructed string line to the ListBox
                    listBoxView.Items.Add(lineText);
                }
            }
        }

        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            listBoxView.Items.Clear();

            if (int.TryParse(TxtStart.Text, out int start) && int.TryParse(TxtEnd.Text, out int end))
            {
                int i = start; // Initialize outer loop counter

                while (i <= end)
                {
                    string lineText = "Line " + i + ": ";

                    int j = start; // Initialize inner loop counter
                    while (j <= end)
                    {
                        lineText += j;
                        j++; // Increment inner loop
                    }

                    listBoxView.Items.Add(lineText);
                    i++; // Increment outer loop
                }
            }
        }

        private void btnDoLoop_Click(object sender, EventArgs e)
        {
            listBoxView.Items.Clear();

            if (int.TryParse(TxtStart.Text, out int start) && int.TryParse(TxtEnd.Text, out int end))
            {
                // Guard check to prevent execution if start is greater than end
                if (start > end) return;

                int i = start;
                do
                {
                    string lineText = "Line " + i + ": ";

                    int j = start;
                    do
                    {
                        lineText += j;
                        j++;
                    } while (j <= end);

                    listBoxView.Items.Add(lineText);
                    i++;
                } while (i <= end);
            }
        }
    }
}
