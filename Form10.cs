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
            string StrMyConn_SqlAuth =
   $"Server={MyServer}; " +
   $"Database={MyDb}; " +
   $"User id={MyUserID}; Password={MyPwd}; " +
   "Encrypt=True; " +
   "TrustServerCertificate=True; ";

            using (MyConn = new SqlConnection(StrMyConn_SqlAuth))
            {
                MyConn.Open();      //Start connect to sqlserver

                // --- បន្ថែមសារនេះដើម្បីដឹងថា ភ្ជាប់ជោគជ័យ ---
                MessageBox.Show("ការភ្ជាប់ទៅកាន់ Database បានជោគជ័យ!", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    sql =
                        "Insert into [USER_LST] ([USER_ID], [USER_NAME], [USER_PWD], [USER_EMAIL],[USER_PROFILE])" +
                        " Values(@userid,@username,@pwd,@email,@Profile);";
                    cmd = new SqlCommand(sql, MyConn);
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtID.Text));
                    cmd.Parameters.AddWithValue("@username", TxtNAME.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEMAIL.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboPROFILE.Text);
                    //Process                
                    int x = cmd.ExecuteNonQuery();
                    //Output 
                    if (x == 1)
                    {
                        //Data one row is inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is inserted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    else
                    {
                        //Data is not inserted!
                        MessageBox.Show("Confirm message..",
                            "Data is not inserted", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Confirm message..",
                        "Error:" + ex.Message);
                }
            }
        }

        private void BtnUPDATE_Click(object sender, EventArgs e)
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

                    // ឃ្លា SQL សម្រាប់ UPDATE (កែប្រែទិន្នន័យផ្អែកលើ USER_ID)
                    sql = "UPDATE [USER_LST] SET " +
                          "[USER_NAME] = @username, " +
                          "[USER_PWD] = @pwd, " +
                          "[USER_EMAIL] = @email, " +
                          "[USER_PROFILE] = @Profile " +
                          "WHERE [USER_ID] = @userid;";

                    cmd = new SqlCommand(sql, MyConn);

                    // ចង Parameters (ត្រូវប្រាកដថាឈ្មោះ TextBox ត្រូវគ្នានឹងទម្រង់ UI របស់អ្នក)
                    cmd.Parameters.AddWithValue("@userid", int.Parse(TxtID.Text)); // យក ID ទៅស្វែងរក
                    cmd.Parameters.AddWithValue("@username", TxtNAME.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEMAIL.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboPROFILE.Text);

                    int x = cmd.ExecuteNonQuery();

                    if (x > 0)
                    {
                        MessageBox.Show("ទិន្នន័យត្រូវបានកែប្រែជោគជ័យ!", "ជោគជ័យ",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("មិនរកឃើញទិន្នន័យដែលមាន ID នេះទេ ឬការកែប្រែបរាជ័យ!", "ព្រមាន",
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

        private void BtnDELETE_Click(object sender, EventArgs e)
        {
            // បង្ហាញផ្ទាំងសួរដើម្បីបញ្ជាក់ថាចង់លុបពិតប្រាកដមែនអត់ (ការពារការច្រឡំដៃ)
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

                        // ឃ្លា SQL សម្រាប់លុប
                        sql = "DELETE FROM [USER_LST] WHERE [USER_ID] = @userid;";

                        cmd = new SqlCommand(sql, MyConn);

                        // ចាប់យកតែ ID មួយគត់មកលុប
                        cmd.Parameters.AddWithValue("@userid", int.Parse(TxtID.Text));

                        int x = cmd.ExecuteNonQuery();

                        if (x > 0)
                        {
                            MessageBox.Show("ទិន្នន័យត្រូវបានលុបចេញពីប្រព័ន្ធជោគជ័យ!", "ជោគជ័យ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ជម្រើសបន្ថែម៖ សម្អាតប្រអប់ TextBox ក្រោយពេលលុបហើយ
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

        }

        private void CboPROFILE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblID_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // ១. ទាញយកតម្លៃពី TextBox មកទុកក្នុង Variable
            // (សូមប្រាកដថា TextBox ទាំងពីររបស់អ្នកមានឈ្មោះ Name ថា txtUsername និង txtPassword)
            string username = TxtPWD.Text.Trim();
            string password = TxtNAME.Text.Trim();

            // ២. ពិនិត្យថាមានចន្លោះទំនេរដែលមិនទាន់វាយបញ្ចូលដែរឬទេ
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("សូមបញ្ចូល Username និង Password ឲ្យបានគ្រប់គ្រាន់!", "ការព្រមាន", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ៣. នេះជា Connection String ដែលបានកែតម្រូវតាមម៉ាស៊ីនរបស់អ្នករួចជាស្រេច
            string connString = @"Server=.\SQLEXPRESS; Database=test1; Integrated Security=True;";

            // Query សម្រាប់ទៅឆែកមើលក្នុង Table USER_ACCOUNT របស់អ្នក
            string query = "SELECT COUNT(*) FROM USER_ACCOUNT WHERE USER_NAME = @user AND USER_PWD = @pwd";

            // ៤. ភ្ជាប់ទៅកាន់ Database និងផ្ទៀងផ្ទាត់
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        // ជំនួសតម្លៃ Parameter ការពារការលួច Hack (SQL Injection)
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pwd", password);

                        // អានលទ្ធផលលេខទិន្នន័យដែលរកឃើញ
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0) // បើរកឃើញគណនីមានន័យថាត្រឹមត្រូវហើយ
                        {
                            MessageBox.Show("ចូលប្រើប្រាស់ប្រព័ន្ធជោគជ័យ!", "សារដំណឹង", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // >>> បើកទៅកាន់ Form10 <<<
                            Form10 mainForm = new Form10(); // បង្កើតផ្ទាំង Form10
                            mainForm.Show();                // បង្ហាញ Form10 មកលើអេក្រង់

                            this.Hide();                    // លាក់ផ្ទាំង FormLogin នេះចោល
                        }
                        else
                        {
                            MessageBox.Show("Username ឬ Password មិនត្រឹមត្រូវទេ! សូមពិនិត្យឡើងវិញ។", "កំហុស", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // បង្ហាញសារកំហុស ប្រសិនបើភ្ជាប់ Database មិនដើរ
                    MessageBox.Show("មានបញ្ហាភ្ជាប់ទៅកាន់ Database: " + ex.Message, "កំហុសប្រព័ន្ធ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
