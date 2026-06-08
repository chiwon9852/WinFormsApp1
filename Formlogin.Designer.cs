namespace WinFormsApp1
{
    partial class Formlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            BtnLogin = new Button();
            chkShowHide = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(299, 39);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "LOGIN TO SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.ForeColor = Color.Navy;
            lblUsername.Location = new Point(54, 98);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.ForeColor = Color.Navy;
            lblPassword.Location = new Point(54, 166);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(230, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(478, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(478, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            BtnLogin.ForeColor = Color.Navy;
            BtnLogin.Location = new Point(277, 258);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(193, 57);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "LOG IN";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // chkShowHide
            // 
            chkShowHide.Appearance = Appearance.Button;
            chkShowHide.AutoSize = true;
            chkShowHide.FlatStyle = FlatStyle.Flat;
            chkShowHide.Location = new Point(714, 156);
            chkShowHide.Name = "chkShowHide";
            chkShowHide.Size = new Size(40, 30);
            chkShowHide.TabIndex = 6;
            chkShowHide.Text = "👁️";
            chkShowHide.UseVisualStyleBackColor = true;
            chkShowHide.CheckedChanged += chkShowHide_CheckedChanged;
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowHide);
            Controls.Add(BtnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "Formlogin";
            Text = "MICRO LOAN MANAGEMENT SYSTEM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button BtnLogin;
        private CheckBox chkShowHide;
    }
}