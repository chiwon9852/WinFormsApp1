using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("សូមបញ្ចូល Username និង Password ឲ្យបានគ្រប់គ្រាន់!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (username == "PREAB KUNTHY" && password == "03/08/09")
            {
                MessageBox.Show("ចូលប្រើប្រាស់ប្រព័ន្ធជោគជ័យ!", "សារដំណឹង", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Form10 mainForm = new Form10();
                mainForm.Show();


                this.Hide();
            }
            else
            {

                MessageBox.Show("Username ឬ Password មិនត្រឹមត្រូវទេ! សូមពិនិត្យឡើងវិញ។", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkShowHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; 
                chkShowHide.Text = "***";                 
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;  
                chkShowHide.Text = "👁️";              
            }
        }
    }
}
