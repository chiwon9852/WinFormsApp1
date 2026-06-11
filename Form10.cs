using Microsoft.Data.SqlClient;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void uiAddress_Click(object sender, EventArgs e)
        {


        }
        private void uiBtnCommit_Click(object sender, EventArgs e)
        {

        }
        string MyServer = @".\SQLEXPRESS";
        string MyDb = "test1";
        string MyUserID = "sa";
        string MyPwd = "100124";
        SqlConnection MyConn = new();
        SqlCommand cmd;
        string sql;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnINSERT_Click(object sender, EventArgs e)
       
        {
            // ១. ឆែកមើលជាមុនសិន បើឈ្មោះ ឬលេខកូដទទេ គឺមិនឲ្យ INSERT ឡើយ
            if (string.IsNullOrEmpty(TxtNAME.Text.Trim()) || string.IsNullOrEmpty(TxtPWD.Text.Trim()))
            {
                MessageBox.Show("សូមបញ្ចូល USER_NAME និង USER_PWD ឲ្យបានគ្រប់គ្រាន់!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string StrMyConn_SqlAuth = $"Server={MyServer}; Database={MyDb}; User id={MyUserID}; Password={MyPwd}; Encrypt=True; TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                try
                {
                    MyConn.Open(); // បើកការភ្ជាប់ទៅកាន់ SQL Server

                    // កែសម្រួល SQL Query៖ ដក [USER_ID] និង @userid ចេញ ដើម្បីឲ្យ SQL Server បង្កើតលេខអូតូ
                    sql = "INSERT INTO [USER_LST] ([USER_NAME], [USER_PWD], [USER_EMAIL], [USER_PROFILE]) " +
                          "VALUES (@username, @pwd, @email, @Profile);";

                    cmd = new SqlCommand(sql, MyConn);

                    // មិនបាច់មានបន្ទាត់កូដ int.Parse(TxtID.Text) ទៀតទេ លែងគាំង Error ផ្ដេសផ្ដាសហើយ
                    cmd.Parameters.AddWithValue("@username", TxtNAME.Text.Trim());
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TxtEMAIL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Profile", CboPROFILE.Text);

                    // ដំណើរការ Query
                    int x = cmd.ExecuteNonQuery();

                    // បង្ហាញលទ្ធផល
                    if (x == 1)
                    {
                        MessageBox.Show("បានរក្សាទុកគណនីថ្មីចូលទៅកាន់ប្រព័ន្ធជោគជ័យ!", "ទិន្នន័យត្រូវបានបញ្ចូល", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // គន្លឹះ៖ សម្អាតប្រអប់ TextBox ក្រោយពេលរក្សាទុករួចរាល់
                        TxtID.Clear();
                        TxtNAME.Clear();
                        TxtPWD.Clear();
                        TxtEMAIL.Clear();
                        CboPROFILE.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("មិនអាចរក្សាទុកទិន្នន័យបានទេ!", "បរាជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មានបញ្ហា៖ " + ex.Message, "កំហុសប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // ធានាថាការភ្ជាប់ត្រូវបានបិទ ទោះបីជាដើរជោគជ័យ ឬមាន Error ក៏ដោយ
                    if (MyConn.State == System.Data.ConnectionState.Open)
                    {
                        MyConn.Close();
                    }
                }
            }
        }

        private void BtnUPDATE_Click(object sender, EventArgs e)

        {
            // ១. ឆែកការពារ បើប្រអប់ ID នៅទទេ (មិនទាន់បានរើស User ពីតារាង) មិនឱ្យដើរឡើយ
            if (string.IsNullOrEmpty(TxtID.Text))
            {
                MessageBox.Show("សូមជ្រើសរើសទិន្នន័យពីតារាង VIEW ជាមុនសិន ទើបអាចធ្វើការកែប្រែបាន!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string StrMyConn_SqlAuth = $"Server={MyServer}; Database={MyDb}; User id={MyUserID}; Password={MyPwd}; Encrypt=True; TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                try
                {
                    MyConn.Open();

                   
                    sql = "UPDATE [USER_LST] SET [USER_NAME]=@username, [USER_PWD]=@pwd, [USER_EMAIL]=@email, [USER_PROFILE]=@Profile WHERE [USER_ID]=@userid;";

                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtID.Text)); 
                    cmd.Parameters.AddWithValue("@username", TxtNAME.Text.Trim());
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TxtEMAIL.Text.Trim());
                    cmd.Parameters.AddWithValue("@Profile", CboPROFILE.Text);

                    int x = cmd.ExecuteNonQuery();

                    if (x == 1)
                    {
                        MessageBox.Show("បានធ្វើបច្ចុប្បន្នភាព (Update) ទិន្នន័យគណនីជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                        TxtID.Clear(); TxtNAME.Clear(); TxtPWD.Clear(); TxtEMAIL.Clear(); CboPROFILE.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("កំហុស UPDATE: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnDELETE_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "បញ្ជាក់ការលុប",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string StrMyConn_SqlAuth =
                    $"Server={MyServer}; " +
                    $"Database={MyDb}; " +
                    $"User id={MyUserID}; Password={MyPwd}; " +
                    "Encrypt=True; " +
                    "TrustServerCertificate=True; ";

                using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
                {
                    try
                    {
                        MyConn.Open();

                     
                        sql = "DELETE FROM [USER_LST] WHERE [USER_ID] = @userid;";

                        cmd = new SqlCommand(sql, MyConn);

                        
                        cmd.Parameters.AddWithValue("@userid", int.Parse(TxtID.Text));

                        int x = cmd.ExecuteNonQuery();

                        if (x > 0)
                        {
                            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពីប្រព័ន្ធជោគជ័យ!", "ជោគជ័យ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                           
                            TxtID.Clear();
                            TxtNAME.Clear();
                            TxtPWD.Clear();
                            TxtEMAIL.Clear();
                        }
                        else
                        {
                            MessageBox.Show("មិនរកឃើញទិន្នន័យដែលមាន ID នេះដើម្បីលុបឡើយ!", "ព្រមាន",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "កំហុស",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnVIEW_Click(object sender, EventArgs e)
        {


            string connString = $"Server={MyServer}; Database={MyDb}; User id={MyUserID}; Password={MyPwd}; Encrypt=True; TrustServerCertificate=True;";


            string query = "SELECT USER_ID, USER_NAME, USER_PWD, USER_EMAIL, USER_PROFILE FROM USER_LST";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    FormUserList listForm = new FormUserList();

 
                    listForm.dvUser = dt.DefaultView;


                    listForm.dgvUser.DataSource = listForm.dvUser;

                    listForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("មិនអាចបើកមើលទិន្នន័យបានទេ៖ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CboPROFILE_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboPROFILE.SelectedIndex = 0;
        }

        private void LblID_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string username = TxtPWD.Text.Trim();
            string password = TxtNAME.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("សូមបញ្ចូល Username និង Password ឲ្យបានគ្រប់គ្រាន់!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connString = @"Server=.\SQLEXPRESS; Database=test1; Integrated Security=True;";

 
            string query = "SELECT COUNT(*) FROM USER_ACCOUNT WHERE USER_NAME = @user AND USER_PWD = @pwd";


            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pwd", password);


                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0) 
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
                }
                catch (Exception ex)
                {

                    MessageBox.Show("មានបញ្ហាភ្ជាប់ទៅកាន់ Database: " + ex.Message, "កំហុសប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
