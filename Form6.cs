using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuOpenpic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb1.Image = Image.FromFile(openFileDialog.FileName);
                pcb1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pcb1_Click(object sender, EventArgs e)
        {

        }

        private void mnuOpenpic2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb2.Image = Image.FromFile(openFileDialog.FileName);
                pcb2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void mnuOpenpic3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb3.Image = Image.FromFile(openFileDialog.FileName);
                pcb3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void mnuOpenpic4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcb4.Image = Image.FromFile(openFileDialog.FileName);
                pcb4.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
