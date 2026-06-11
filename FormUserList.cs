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
    public partial class FormUserList : Form
    {
       public DataView dvUser = new DataView();
        public FormUserList()
        {
            InitializeComponent();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                Form10 frm10 = (Form10)Application.OpenForms["Form10"];

                if (frm10 != null)
                {
                    frm10.TxtID.Text = row.Cells["USER_ID"].Value.ToString();
                    frm10.TxtNAME.Text = row.Cells["USER_NAME"].Value.ToString();
                    frm10.TxtPWD.Text = row.Cells["USER_PWD"].Value.ToString(); // ហោះទាំង Password មកដែរ
                    frm10.TxtEMAIL.Text = row.Cells["USER_EMAIL"].Value.ToString();
                    frm10.CboPROFILE.Text = row.Cells["USER_PROFILE"].Value.ToString();

                    this.Close(); // បិទផ្ទាំងនេះវិញ
                }
            }
        }
        public void LoadDataToGrid()
        {
            // ប្រើប្រាស់ Connetion String របស់អ្នក (ដូចក្នុង Form10)
            string connString = "Server=.\\SQLEXPRESS; Database=test1; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
            string query = "SELECT USER_ID, USER_NAME, USER_EMAIL, USER_PROFILE FROM USER_LST";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dvUser = dt.DefaultView; // បោះទិន្នន័យចូលកន្ត្រក DataView
                    dgvUser.DataSource = dvUser; // បង្ហាញទៅកាន់តារាង
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មិនអាចទាញទិន្នន័យបានទេ: " + ex.Message);
                }
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormUserList_Load(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

            


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvUser.Table != null)
                {
                    // ស្វែងរកក្នុងជួរ USER_NAME ឱ្យតែមានផ្ទុកអក្សរដែលយើងវាយ
                    dvUser.RowFilter = string.Format("USER_NAME LIKE '%{0}%'", txtSearch.Text.Trim().Replace("'", "''"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("កំហុសក្នុងការស្វែងរក៖ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
