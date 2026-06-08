namespace WinFormsApp1
{
    partial class Form10
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
            uiTabCboUserAccount = new Sunny.UI.UITabControlMenu();
            tabPage4 = new TabPage();
            panellogin = new Panel();
            tabPage1 = new TabPage();
            BtnVIEW = new Button();
            BtnDELETE = new Button();
            BtnUPDATE = new Button();
            BtnINSERT = new Button();
            CboPROFILE = new ComboBox();
            TxtEMAIL = new TextBox();
            TxtPWD = new TextBox();
            TxtNAME = new TextBox();
            TxtID = new TextBox();
            LblPROFILE = new Label();
            LblEMAIL = new Label();
            LblPWD = new Label();
            LblNAME = new Label();
            LblID = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            uiTabCboUserAccount.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabCboUserAccount
            // 
            uiTabCboUserAccount.Alignment = TabAlignment.Left;
            uiTabCboUserAccount.Controls.Add(tabPage4);
            uiTabCboUserAccount.Controls.Add(tabPage1);
            uiTabCboUserAccount.Controls.Add(tabPage2);
            uiTabCboUserAccount.Controls.Add(tabPage3);
            uiTabCboUserAccount.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabCboUserAccount.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabCboUserAccount.Location = new Point(0, 0);
            uiTabCboUserAccount.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabCboUserAccount.Multiline = true;
            uiTabCboUserAccount.Name = "uiTabCboUserAccount";
            uiTabCboUserAccount.SelectedIndex = 0;
            uiTabCboUserAccount.Size = new Size(800, 448);
            uiTabCboUserAccount.SizeMode = TabSizeMode.Fixed;
            uiTabCboUserAccount.TabBackColor = Color.MidnightBlue;
            uiTabCboUserAccount.TabIndex = 0;
            uiTabCboUserAccount.TabSelectedColor = Color.FromArgb(0, 0, 192);
            uiTabCboUserAccount.TabSelectedForeColor = Color.FromArgb(224, 224, 224);
            uiTabCboUserAccount.TabSelectedHighColor = Color.Navy;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panellogin);
            tabPage4.Location = new Point(201, 0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(599, 448);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "LOG IN";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panellogin
            // 
            panellogin.BackColor = Color.WhiteSmoke;
            panellogin.Location = new Point(0, 0);
            panellogin.Name = "panellogin";
            panellogin.Size = new Size(599, 445);
            panellogin.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Controls.Add(BtnVIEW);
            tabPage1.Controls.Add(BtnDELETE);
            tabPage1.Controls.Add(BtnUPDATE);
            tabPage1.Controls.Add(BtnINSERT);
            tabPage1.Controls.Add(CboPROFILE);
            tabPage1.Controls.Add(TxtEMAIL);
            tabPage1.Controls.Add(TxtPWD);
            tabPage1.Controls.Add(TxtNAME);
            tabPage1.Controls.Add(TxtID);
            tabPage1.Controls.Add(LblPROFILE);
            tabPage1.Controls.Add(LblEMAIL);
            tabPage1.Controls.Add(LblPWD);
            tabPage1.Controls.Add(LblNAME);
            tabPage1.Controls.Add(LblID);
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(599, 448);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "USER_ACCOUNT";
            tabPage1.Click += tabPage1_Click;
            // 
            // BtnVIEW
            // 
            BtnVIEW.ForeColor = Color.Navy;
            BtnVIEW.Location = new Point(105, 385);
            BtnVIEW.Name = "BtnVIEW";
            BtnVIEW.Size = new Size(418, 53);
            BtnVIEW.TabIndex = 13;
            BtnVIEW.Text = "VIEW";
            BtnVIEW.UseVisualStyleBackColor = true;
            BtnVIEW.Click += BtnVIEW_Click;
            // 
            // BtnDELETE
            // 
            BtnDELETE.ForeColor = Color.Navy;
            BtnDELETE.Location = new Point(393, 330);
            BtnDELETE.Name = "BtnDELETE";
            BtnDELETE.Size = new Size(130, 49);
            BtnDELETE.TabIndex = 12;
            BtnDELETE.Text = "DELETE";
            BtnDELETE.UseVisualStyleBackColor = true;
            BtnDELETE.Click += BtnDELETE_Click;
            // 
            // BtnUPDATE
            // 
            BtnUPDATE.ForeColor = Color.Navy;
            BtnUPDATE.Location = new Point(251, 330);
            BtnUPDATE.Name = "BtnUPDATE";
            BtnUPDATE.Size = new Size(127, 49);
            BtnUPDATE.TabIndex = 11;
            BtnUPDATE.Text = "UPDATE";
            BtnUPDATE.UseVisualStyleBackColor = true;
            BtnUPDATE.Click += BtnUPDATE_Click;
            // 
            // BtnINSERT
            // 
            BtnINSERT.ForeColor = Color.Navy;
            BtnINSERT.Location = new Point(105, 330);
            BtnINSERT.Name = "BtnINSERT";
            BtnINSERT.Size = new Size(131, 49);
            BtnINSERT.TabIndex = 10;
            BtnINSERT.Text = "INSERT";
            BtnINSERT.UseVisualStyleBackColor = true;
            BtnINSERT.Click += BtnINSERT_Click;
            // 
            // CboPROFILE
            // 
            CboPROFILE.FormattingEnabled = true;
            CboPROFILE.Location = new Point(269, 269);
            CboPROFILE.Name = "CboPROFILE";
            CboPROFILE.Size = new Size(196, 33);
            CboPROFILE.TabIndex = 9;
            CboPROFILE.SelectedIndexChanged += CboPROFILE_SelectedIndexChanged;
            // 
            // TxtEMAIL
            // 
            TxtEMAIL.Location = new Point(269, 208);
            TxtEMAIL.Name = "TxtEMAIL";
            TxtEMAIL.Size = new Size(196, 30);
            TxtEMAIL.TabIndex = 8;
            // 
            // TxtPWD
            // 
            TxtPWD.Location = new Point(269, 145);
            TxtPWD.Name = "TxtPWD";
            TxtPWD.Size = new Size(196, 30);
            TxtPWD.TabIndex = 7;
            // 
            // TxtNAME
            // 
            TxtNAME.Location = new Point(269, 83);
            TxtNAME.Name = "TxtNAME";
            TxtNAME.Size = new Size(196, 30);
            TxtNAME.TabIndex = 6;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(269, 25);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(196, 30);
            TxtID.TabIndex = 5;
            // 
            // LblPROFILE
            // 
            LblPROFILE.AutoSize = true;
            LblPROFILE.ForeColor = Color.Navy;
            LblPROFILE.Location = new Point(16, 277);
            LblPROFILE.Name = "LblPROFILE";
            LblPROFILE.Size = new Size(171, 25);
            LblPROFILE.TabIndex = 4;
            LblPROFILE.Text = "USER_PROFILE :";
            // 
            // LblEMAIL
            // 
            LblEMAIL.AutoSize = true;
            LblEMAIL.BackColor = Color.White;
            LblEMAIL.ForeColor = Color.Navy;
            LblEMAIL.Location = new Point(16, 213);
            LblEMAIL.Name = "LblEMAIL";
            LblEMAIL.Size = new Size(148, 25);
            LblEMAIL.TabIndex = 3;
            LblEMAIL.Text = "USER_EMAIL :";
            // 
            // LblPWD
            // 
            LblPWD.AutoSize = true;
            LblPWD.BackColor = Color.White;
            LblPWD.ForeColor = Color.Navy;
            LblPWD.Location = new Point(16, 150);
            LblPWD.Name = "LblPWD";
            LblPWD.Size = new Size(135, 25);
            LblPWD.TabIndex = 2;
            LblPWD.Text = "USER_PWD :";
            // 
            // LblNAME
            // 
            LblNAME.AutoSize = true;
            LblNAME.BackColor = Color.White;
            LblNAME.ForeColor = Color.Navy;
            LblNAME.Location = new Point(16, 88);
            LblNAME.Name = "LblNAME";
            LblNAME.Size = new Size(146, 25);
            LblNAME.TabIndex = 1;
            LblNAME.Text = "USER_NAME :";
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.BackColor = Color.White;
            LblID.ForeColor = Color.Navy;
            LblID.Location = new Point(16, 25);
            LblID.Name = "LblID";
            LblID.Size = new Size(107, 25);
            LblID.TabIndex = 0;
            LblID.Text = "USER_ID :";
            LblID.Click += LblID_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(599, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Suppliers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(599, 448);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PurChase";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uiTabCboUserAccount);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            uiTabCboUserAccount.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabCboUserAccount;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox TxtEMAIL;
        private TextBox TxtPWD;
        private TextBox TxtNAME;
        private TextBox TxtID;
        private Label LblPROFILE;
        private Label LblEMAIL;
        private Label LblPWD;
        private Label LblNAME;
        private Label LblID;
        private ComboBox CboPROFILE;
        private Button BtnVIEW;
        private Button BtnDELETE;
        private Button BtnUPDATE;
        private Button BtnINSERT;
        private TabPage tabPage4;
        private Panel panellogin;
    }
}