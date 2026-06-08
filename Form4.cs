using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CboNumberList.Items.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int tmp_value = CboNumberList.Items.Count + 1;
            CboNumberList.Items.Add(tmp_value.ToString());
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (CboNumberList.Items.Count > 0)
            {
                CboNumberList.Items.RemoveAt(CboNumberList.Items.Count - 1);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboNumberList.Items.RemoveAt(0);
            CboNumberList.Items.Remove("ItemName");
            CboNumberList.Items.Clear();
            if (CboNumberList.SelectedIndex >= 0)
                CboNumberList.Items.RemoveAt(CboNumberList.SelectedIndex);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string itemToSearch = CboNumberList.Text;
            if (CboNumberList.Items.Contains(itemToSearch))
            {
                MessageBox.Show("We find [ " + itemToSearch + " ] in list.");
            }
        }
    }
}
