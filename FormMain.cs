using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using Sunny.UI.Win32;
using Microsoft.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class FormMain : UIForm
    {
        public FormMain()
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
            string str_id = uiTxtID.Text;
            string str_Name = uiTxtName.Text;
            string str_ContactPerson = uiTxtContactPerson.Text;
            string str_Phone = uiTxtPhone.Text;
            string str_Email = uiTxtEmail.Text;
            string str_Address = uiTxtAddress.Text;
            string str_lst =
                "1. ID" + str_id.ToString() + Environment.NewLine +
                "2. Name" + str_Name.ToString() + Environment.NewLine +
                "3. Contact Person" + str_ContactPerson.ToString() + Environment.NewLine +
                "4. Phone" + str_Phone.ToString() + Environment.NewLine +
                "5. Email" + str_Email.ToString() + Environment.NewLine +
                "6. Adress" + str_Address.ToString() + Environment.NewLine;
            uiListBox1.Items.Add($"{str_lst}");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        string MyServer = @"MAMAMILA\SQLEXPRESS";
        string MyDb = "Test1";
        string MyUserID = "sa";
        string MyPwd = "mamamila";
        SqlConnection MyConn = new();
        SqlCommand cmd;
        string sql;



        private void BtnInsert_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@username", TxtName.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboProfile.Text);
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

        private void BtnUpdate_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@username", TxtName.Text);
                    cmd.Parameters.AddWithValue("@pwd", TxtPWD.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Profile", CboProfile.Text);

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
        private void BtnDelete_Click(object sender, EventArgs e)
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
                            TxtName.Clear();
                            TxtPWD.Clear();
                            TxtEmail.Clear();
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
    }
}
