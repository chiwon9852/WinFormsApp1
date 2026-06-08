using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            CboAuthentication.Items.Clear();
            CboAuthentication.Items.Add("Windows Authentication");
            CboAuthentication.Items.Add("SQl Server Authentication");
            CboAuthentication.Items.Add("Active Directory - password");
            CboAuthentication.SelectedIndex = 0;

        }
        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            SqlConnection MyConn = new();

            string MyServer = CboServer.Text.ToString();
            string MyDb = CboDatabase.Text.ToString();
            string MyUserID = txtUserID.Text.ToString();
            string MyPwd = txtPassword.Text.ToString();
            string StrMyConn_WindAuth =
                $"Server={MyServer}; " +
                $"Database={MyDb}; " +
                "Encrypt=True; " +
                "TrustServerCertificate=True; ";

            string StrMyConn_SqlAuth =
                $"Server={MyServer}; " +
                $"Database={MyDb}; " +
                $"User id={MyUserID}; Password={MyPwd}; " +
                "Encrypt=True; " +
                "TrustServerCertificate=True; ";


            string str_auth = CboAuthentication.Text.ToString();

            if (str_auth == "Windows Authentication")
            {

                //Do any thing
                return;
            }

            if (str_auth == "SQL Server Authentication")
            {

                return;
            }

        }
        private void lblServer_Click(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
