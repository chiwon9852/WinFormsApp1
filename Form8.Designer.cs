namespace WinFormsApp1
{
    partial class Form8
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
            lblAuthentication = new Label();
            lblServer = new Label();
            lblDatabase = new Label();
            lblUserID = new Label();
            lblPassword = new Label();
            CboAuthentication = new ComboBox();
            CboServer = new ComboBox();
            CboDatabase = new ComboBox();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            BtnCheck = new Button();
            SuspendLayout();
            // 
            // lblAuthentication
            // 
            lblAuthentication.AutoSize = true;
            lblAuthentication.Location = new Point(47, 32);
            lblAuthentication.Name = "lblAuthentication";
            lblAuthentication.Size = new Size(113, 20);
            lblAuthentication.TabIndex = 0;
            lblAuthentication.Text = "Authentication :";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(47, 94);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(57, 20);
            lblServer.TabIndex = 1;
            lblServer.Text = "Server :";
            lblServer.Click += lblServer_Click;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(47, 160);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(79, 20);
            lblDatabase.TabIndex = 2;
            lblDatabase.Text = "Database :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(47, 218);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(64, 20);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(47, 270);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password :";
            // 
            // CboAuthentication
            // 
            CboAuthentication.FormattingEnabled = true;
            CboAuthentication.Location = new Point(171, 32);
            CboAuthentication.Name = "CboAuthentication";
            CboAuthentication.Size = new Size(311, 28);
            CboAuthentication.TabIndex = 5;
            // 
            // CboServer
            // 
            CboServer.FormattingEnabled = true;
            CboServer.Location = new Point(171, 94);
            CboServer.Name = "CboServer";
            CboServer.Size = new Size(311, 28);
            CboServer.TabIndex = 6;
            CboServer.SelectedIndexChanged += CboServer_SelectedIndexChanged;
            // 
            // CboDatabase
            // 
            CboDatabase.FormattingEnabled = true;
            CboDatabase.Location = new Point(171, 160);
            CboDatabase.Name = "CboDatabase";
            CboDatabase.Size = new Size(311, 28);
            CboDatabase.TabIndex = 7;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(171, 218);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(311, 27);
            txtUserID.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(171, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(311, 27);
            txtPassword.TabIndex = 9;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(239, 336);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(151, 29);
            BtnCheck.TabIndex = 10;
            BtnCheck.Text = "Check Connection";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCheck);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(CboDatabase);
            Controls.Add(CboServer);
            Controls.Add(CboAuthentication);
            Controls.Add(lblPassword);
            Controls.Add(lblUserID);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Controls.Add(lblAuthentication);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAuthentication;
        private Label lblServer;
        private Label lblDatabase;
        private Label lblUserID;
        private Label lblPassword;
        private ComboBox CboAuthentication;
        private ComboBox CboServer;
        private ComboBox CboDatabase;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private Button BtnCheck;
    }
}