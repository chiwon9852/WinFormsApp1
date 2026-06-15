using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //Add CCY
            CboCCY.Items.Clear();
            CboCCY.Items.Add("KHR");
            CboCCY.Items.Add("USD");
            CboCCY.Text = CboCCY.Items[0].ToString();

            //Add value to text box
            TxtUnitPrice.Text = "0";
            TxtQty.Text = "0";

            //Create property in listview control

            listViewItems.View = View.Details;
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            //listViewItems.View = View.List;
            //listViewItems.View = View.Tile;

            //Create col in listview control
            listViewItems.Columns.Clear();
            listViewItems.Columns.Add("NO.", 60, HorizontalAlignment.Center);
            listViewItems.Columns.Add("PRO_NAME", 100, HorizontalAlignment.Center);
            listViewItems.Columns.Add("UNIT_PRICE", 100, HorizontalAlignment.Center);
            listViewItems.Columns.Add("QTY", 100, HorizontalAlignment.Center);
        }

        private void btnSaleItems_Click(object sender, EventArgs e)
        {

        }

        private void BtnViwitems_Click(object sender, EventArgs e)
        {

        }
    }
}
