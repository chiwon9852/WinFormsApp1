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
            // ១. ទាញតម្លៃពី TextBox ទាំងពីរ (សូមប្រាកដថា TextBox របស់អ្នកឈ្មោះ txtUsername និង txtPassword)
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // ២. ពិនិត្យមើលភាពទទេរ
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("សូមបញ្ចូល Username និង Password ឲ្យបានគ្រប់គ្រាន់!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ៣. លក្ខខណ្ឌចាក់សោរ៖ អនុញ្ញាតតែឈ្មោះ PREAB KUNTHY និងលេខកូដ 030809 មួយគត់
            if (username == "PREAB KUNTHY" && password == "03/08/09")
            {
                MessageBox.Show("ចូលប្រើប្រាស់ប្រព័ន្ធជោគជ័យ!", "សារដំណឹង", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // បើកទៅកាន់ Form10 
                Form10 mainForm = new Form10();
                mainForm.Show();

                // លាក់ផ្ទាំង Login នេះចោល
                this.Hide();
            }
            else
            {
                // បើវាយខុសពីការកំណត់ខាងលើ គឺមិនឲ្យចូលដាច់ខាត
                MessageBox.Show("Username ឬ Password មិនត្រឹមត្រូវទេ! សូមពិនិត្យឡើងវិញ។", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
