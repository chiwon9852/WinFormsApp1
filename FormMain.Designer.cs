namespace WinFormsApp1
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnInsert = new Button();
            CboProfile = new ComboBox();
            TxtEmail = new TextBox();
            TxtPWD = new TextBox();
            TxtName = new TextBox();
            TxtID = new TextBox();
            LblUPF = new Label();
            LblUE = new Label();
            LblUP = new Label();
            LblUN = new Label();
            LblUI = new Label();
            tabSupplier = new TabPage();
            tabControl1 = new TabControl();
            tabSupplierInfo = new TabPage();
            uiListBox1 = new Sunny.UI.UIListBox();
            uiBtnCommit = new Sunny.UI.UIButton();
            uiTxtEmail = new Sunny.UI.UITextBox();
            uiTxtAddress = new Sunny.UI.UITextBox();
            uiTxtPhone = new Sunny.UI.UITextBox();
            uiTxtContactPerson = new Sunny.UI.UITextBox();
            uiTxtName = new Sunny.UI.UITextBox();
            uiTxtID = new Sunny.UI.UITextBox();
            uiAddress = new Sunny.UI.UILabel();
            uiEmail = new Sunny.UI.UILabel();
            uiPhone = new Sunny.UI.UILabel();
            uiContactPerson = new Sunny.UI.UILabel();
            uiName = new Sunny.UI.UILabel();
            uiID = new Sunny.UI.UILabel();
            tabPage4 = new TabPage();
            tabPurchase = new TabPage();
            imageList1 = new ImageList(components);
            uiTabControlMenu1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabSupplier.SuspendLayout();
            tabControl1.SuspendLayout();
            tabSupplierInfo.SuspendLayout();
            uiListBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.AllowDrop = true;
            uiTabControlMenu1.Controls.Add(tabPage1);
            uiTabControlMenu1.Controls.Add(tabSupplier);
            uiTabControlMenu1.Controls.Add(tabPurchase);
            uiTabControlMenu1.Dock = DockStyle.Fill;
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.FillColor = Color.White;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.Location = new Point(0, 35);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(800, 415);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            uiTabControlMenu1.TabBackColor = Color.Magenta;
            uiTabControlMenu1.TabIndex = 0;
            uiTabControlMenu1.TabSelectedColor = Color.White;
            uiTabControlMenu1.TabSelectedForeColor = Color.Black;
            uiTabControlMenu1.TabSelectedHighColor = Color.White;
            uiTabControlMenu1.TabUnSelectedForeColor = Color.FromArgb(48, 48, 48);
            uiTabControlMenu1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnUpdate);
            tabPage1.Controls.Add(BtnInsert);
            tabPage1.Controls.Add(CboProfile);
            tabPage1.Controls.Add(TxtEmail);
            tabPage1.Controls.Add(TxtPWD);
            tabPage1.Controls.Add(TxtName);
            tabPage1.Controls.Add(TxtID);
            tabPage1.Controls.Add(LblUPF);
            tabPage1.Controls.Add(LblUE);
            tabPage1.Controls.Add(LblUP);
            tabPage1.Controls.Add(LblUN);
            tabPage1.Controls.Add(LblUI);
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(599, 415);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "USER";
            tabPage1.UseWaitCursor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(383, 294);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "DELETE";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.UseWaitCursor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(283, 294);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 10;
            BtnUpdate.Text = "UPDATE";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.UseWaitCursor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(183, 294);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(94, 29);
            BtnInsert.TabIndex = 9;
            BtnInsert.Text = "INSERT";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.UseWaitCursor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // CboProfile
            // 
            CboProfile.FormattingEnabled = true;
            CboProfile.Location = new Point(192, 222);
            CboProfile.Name = "CboProfile";
            CboProfile.Size = new Size(285, 33);
            CboProfile.TabIndex = 8;
            CboProfile.UseWaitCursor = true;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(192, 178);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(285, 30);
            TxtEmail.TabIndex = 7;
            TxtEmail.UseWaitCursor = true;
            // 
            // TxtPWD
            // 
            TxtPWD.Location = new Point(192, 130);
            TxtPWD.Name = "TxtPWD";
            TxtPWD.Size = new Size(285, 30);
            TxtPWD.TabIndex = 6;
            TxtPWD.UseWaitCursor = true;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(192, 77);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(285, 30);
            TxtName.TabIndex = 5;
            TxtName.UseWaitCursor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(192, 31);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(285, 30);
            TxtID.TabIndex = 1;
            TxtID.UseWaitCursor = true;
            // 
            // LblUPF
            // 
            LblUPF.AutoSize = true;
            LblUPF.Location = new Point(0, 230);
            LblUPF.Name = "LblUPF";
            LblUPF.Size = new Size(171, 25);
            LblUPF.TabIndex = 4;
            LblUPF.Text = "USER_PROFILE :";
            LblUPF.UseWaitCursor = true;
            // 
            // LblUE
            // 
            LblUE.AutoSize = true;
            LblUE.Location = new Point(23, 183);
            LblUE.Name = "LblUE";
            LblUE.Size = new Size(148, 25);
            LblUE.TabIndex = 3;
            LblUE.Text = "USER_EMAIL :";
            LblUE.UseWaitCursor = true;
            // 
            // LblUP
            // 
            LblUP.AutoSize = true;
            LblUP.Location = new Point(36, 133);
            LblUP.Name = "LblUP";
            LblUP.Size = new Size(135, 25);
            LblUP.TabIndex = 2;
            LblUP.Text = "USER_PWD :";
            LblUP.UseWaitCursor = true;
            // 
            // LblUN
            // 
            LblUN.AutoSize = true;
            LblUN.Location = new Point(25, 82);
            LblUN.Name = "LblUN";
            LblUN.Size = new Size(146, 25);
            LblUN.TabIndex = 1;
            LblUN.Text = "USER_NAME :";
            LblUN.UseWaitCursor = true;
            // 
            // LblUI
            // 
            LblUI.AutoSize = true;
            LblUI.Location = new Point(64, 34);
            LblUI.Name = "LblUI";
            LblUI.Size = new Size(107, 25);
            LblUI.TabIndex = 0;
            LblUI.Text = "USER_ID :";
            LblUI.UseWaitCursor = true;
            // 
            // tabSupplier
            // 
            tabSupplier.BackColor = Color.White;
            tabSupplier.Controls.Add(tabControl1);
            tabSupplier.Location = new Point(201, 0);
            tabSupplier.Name = "tabSupplier";
            tabSupplier.Size = new Size(599, 415);
            tabSupplier.TabIndex = 0;
            tabSupplier.Text = "Suppliers";
            tabSupplier.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSupplierInfo);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(590, 403);
            tabControl1.TabIndex = 0;
            tabControl1.UseWaitCursor = true;
            // 
            // tabSupplierInfo
            // 
            tabSupplierInfo.Controls.Add(uiListBox1);
            tabSupplierInfo.Controls.Add(uiTxtEmail);
            tabSupplierInfo.Controls.Add(uiTxtAddress);
            tabSupplierInfo.Controls.Add(uiTxtPhone);
            tabSupplierInfo.Controls.Add(uiTxtContactPerson);
            tabSupplierInfo.Controls.Add(uiTxtName);
            tabSupplierInfo.Controls.Add(uiTxtID);
            tabSupplierInfo.Controls.Add(uiAddress);
            tabSupplierInfo.Controls.Add(uiEmail);
            tabSupplierInfo.Controls.Add(uiPhone);
            tabSupplierInfo.Controls.Add(uiContactPerson);
            tabSupplierInfo.Controls.Add(uiName);
            tabSupplierInfo.Controls.Add(uiID);
            tabSupplierInfo.Location = new Point(4, 34);
            tabSupplierInfo.Name = "tabSupplierInfo";
            tabSupplierInfo.Padding = new Padding(3);
            tabSupplierInfo.Size = new Size(582, 365);
            tabSupplierInfo.TabIndex = 0;
            tabSupplierInfo.Text = "Supplier info";
            tabSupplierInfo.UseVisualStyleBackColor = true;
            tabSupplierInfo.UseWaitCursor = true;
            tabSupplierInfo.Click += tabPage3_Click;
            // 
            // uiListBox1
            // 
            uiListBox1.Controls.Add(uiBtnCommit);
            uiListBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiListBox1.ItemSelectForeColor = Color.White;
            uiListBox1.Location = new Point(0, 0);
            uiListBox1.Margin = new Padding(4, 5, 4, 5);
            uiListBox1.MinimumSize = new Size(1, 1);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new Padding(2);
            uiListBox1.ShowText = false;
            uiListBox1.Size = new Size(270, 180);
            uiListBox1.TabIndex = 1;
            uiListBox1.Text = null;
            uiListBox1.UseWaitCursor = true;
            // 
            // uiBtnCommit
            // 
            uiBtnCommit.Font = new Font("Microsoft Sans Serif", 12F);
            uiBtnCommit.Location = new Point(165, 93);
            uiBtnCommit.MinimumSize = new Size(1, 1);
            uiBtnCommit.Name = "uiBtnCommit";
            uiBtnCommit.Size = new Size(100, 35);
            uiBtnCommit.TabIndex = 0;
            uiBtnCommit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiBtnCommit.UseWaitCursor = true;
            // 
            // uiTxtEmail
            // 
            uiTxtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtEmail.Location = new Point(0, 0);
            uiTxtEmail.Margin = new Padding(4, 5, 4, 5);
            uiTxtEmail.MinimumSize = new Size(1, 16);
            uiTxtEmail.Name = "uiTxtEmail";
            uiTxtEmail.Padding = new Padding(5);
            uiTxtEmail.ShowText = false;
            uiTxtEmail.Size = new Size(150, 29);
            uiTxtEmail.TabIndex = 2;
            uiTxtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtEmail.UseWaitCursor = true;
            uiTxtEmail.Watermark = "";
            // 
            // uiTxtAddress
            // 
            uiTxtAddress.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtAddress.Location = new Point(0, 0);
            uiTxtAddress.Margin = new Padding(4, 5, 4, 5);
            uiTxtAddress.MinimumSize = new Size(1, 16);
            uiTxtAddress.Name = "uiTxtAddress";
            uiTxtAddress.Padding = new Padding(5);
            uiTxtAddress.ShowText = false;
            uiTxtAddress.Size = new Size(150, 29);
            uiTxtAddress.TabIndex = 3;
            uiTxtAddress.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtAddress.UseWaitCursor = true;
            uiTxtAddress.Watermark = "";
            // 
            // uiTxtPhone
            // 
            uiTxtPhone.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtPhone.Location = new Point(0, 0);
            uiTxtPhone.Margin = new Padding(4, 5, 4, 5);
            uiTxtPhone.MinimumSize = new Size(1, 16);
            uiTxtPhone.Name = "uiTxtPhone";
            uiTxtPhone.Padding = new Padding(5);
            uiTxtPhone.ShowText = false;
            uiTxtPhone.Size = new Size(150, 29);
            uiTxtPhone.TabIndex = 4;
            uiTxtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtPhone.UseWaitCursor = true;
            uiTxtPhone.Watermark = "";
            // 
            // uiTxtContactPerson
            // 
            uiTxtContactPerson.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtContactPerson.Location = new Point(0, 0);
            uiTxtContactPerson.Margin = new Padding(4, 5, 4, 5);
            uiTxtContactPerson.MinimumSize = new Size(1, 16);
            uiTxtContactPerson.Name = "uiTxtContactPerson";
            uiTxtContactPerson.Padding = new Padding(5);
            uiTxtContactPerson.ShowText = false;
            uiTxtContactPerson.Size = new Size(150, 29);
            uiTxtContactPerson.TabIndex = 5;
            uiTxtContactPerson.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtContactPerson.UseWaitCursor = true;
            uiTxtContactPerson.Watermark = "";
            // 
            // uiTxtName
            // 
            uiTxtName.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtName.Location = new Point(0, 0);
            uiTxtName.Margin = new Padding(4, 5, 4, 5);
            uiTxtName.MinimumSize = new Size(1, 16);
            uiTxtName.Name = "uiTxtName";
            uiTxtName.Padding = new Padding(5);
            uiTxtName.ShowText = false;
            uiTxtName.Size = new Size(150, 29);
            uiTxtName.TabIndex = 6;
            uiTxtName.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtName.UseWaitCursor = true;
            uiTxtName.Watermark = "";
            // 
            // uiTxtID
            // 
            uiTxtID.Font = new Font("Microsoft Sans Serif", 12F);
            uiTxtID.Location = new Point(0, 0);
            uiTxtID.Margin = new Padding(4, 5, 4, 5);
            uiTxtID.MinimumSize = new Size(1, 16);
            uiTxtID.Name = "uiTxtID";
            uiTxtID.Padding = new Padding(5);
            uiTxtID.ShowText = false;
            uiTxtID.Size = new Size(150, 29);
            uiTxtID.TabIndex = 7;
            uiTxtID.TextAlignment = ContentAlignment.MiddleLeft;
            uiTxtID.UseWaitCursor = true;
            uiTxtID.Watermark = "";
            // 
            // uiAddress
            // 
            uiAddress.Font = new Font("Microsoft Sans Serif", 12F);
            uiAddress.ForeColor = Color.FromArgb(48, 48, 48);
            uiAddress.Location = new Point(0, 0);
            uiAddress.Name = "uiAddress";
            uiAddress.Size = new Size(100, 23);
            uiAddress.TabIndex = 8;
            uiAddress.UseWaitCursor = true;
            // 
            // uiEmail
            // 
            uiEmail.Font = new Font("Microsoft Sans Serif", 12F);
            uiEmail.ForeColor = Color.FromArgb(48, 48, 48);
            uiEmail.Location = new Point(0, 0);
            uiEmail.Name = "uiEmail";
            uiEmail.Size = new Size(100, 23);
            uiEmail.TabIndex = 9;
            uiEmail.UseWaitCursor = true;
            // 
            // uiPhone
            // 
            uiPhone.Font = new Font("Microsoft Sans Serif", 12F);
            uiPhone.ForeColor = Color.FromArgb(48, 48, 48);
            uiPhone.Location = new Point(0, 0);
            uiPhone.Name = "uiPhone";
            uiPhone.Size = new Size(100, 23);
            uiPhone.TabIndex = 10;
            uiPhone.UseWaitCursor = true;
            // 
            // uiContactPerson
            // 
            uiContactPerson.Font = new Font("Microsoft Sans Serif", 12F);
            uiContactPerson.ForeColor = Color.FromArgb(48, 48, 48);
            uiContactPerson.Location = new Point(0, 0);
            uiContactPerson.Name = "uiContactPerson";
            uiContactPerson.Size = new Size(100, 23);
            uiContactPerson.TabIndex = 11;
            uiContactPerson.UseWaitCursor = true;
            // 
            // uiName
            // 
            uiName.Font = new Font("Microsoft Sans Serif", 12F);
            uiName.ForeColor = Color.FromArgb(48, 48, 48);
            uiName.Location = new Point(0, 0);
            uiName.Name = "uiName";
            uiName.Size = new Size(100, 23);
            uiName.TabIndex = 12;
            uiName.UseWaitCursor = true;
            // 
            // uiID
            // 
            uiID.Font = new Font("Microsoft Sans Serif", 12F);
            uiID.ForeColor = Color.FromArgb(48, 48, 48);
            uiID.Location = new Point(0, 0);
            uiID.Name = "uiID";
            uiID.Size = new Size(100, 23);
            uiID.TabIndex = 13;
            uiID.UseWaitCursor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(582, 365);
            tabPage4.TabIndex = 1;
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.UseWaitCursor = true;
            // 
            // tabPurchase
            // 
            tabPurchase.BackColor = Color.White;
            tabPurchase.Location = new Point(201, 0);
            tabPurchase.Name = "tabPurchase";
            tabPurchase.Size = new Size(599, 415);
            tabPurchase.TabIndex = 1;
            tabPurchase.Text = "Purchase";
            tabPurchase.UseWaitCursor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Black;
            imageList1.Images.SetKeyName(0, "Add Bookmark.ico");
            imageList1.Images.SetKeyName(1, "Add Bookmark2.ico");
            imageList1.Images.SetKeyName(2, "Bookmark.ico");
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiTabControlMenu1);
            Name = "FormMain";
            Text = "FormMain";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FormMain_Load;
            uiTabControlMenu1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabSupplier.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabSupplierInfo.ResumeLayout(false);
            uiListBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabSupplier;
        private TabPage tabPurchase;
        private TabControl tabControl1;
        private TabPage tabSupplierInfo;
        private TabPage tabPage4;
        private Sunny.UI.UILabel uiEmail;
        private Sunny.UI.UILabel uiPhone;
        private Sunny.UI.UILabel uiContactPerson;
        private Sunny.UI.UILabel uiName;
        private Sunny.UI.UILabel uiID;
        private Sunny.UI.UILabel uiAddress;
        private Sunny.UI.UITextBox uiTxtEmail;
        private Sunny.UI.UITextBox uiTxtAddress;
        private Sunny.UI.UITextBox uiTxtPhone;
        private Sunny.UI.UITextBox uiTxtContactPerson;
        private Sunny.UI.UITextBox uiTxtName;
        private Sunny.UI.UITextBox uiTxtID;
        private Sunny.UI.UIButton uiBtnCommit;
        private Sunny.UI.UIListBox uiListBox1;
        private ImageList imageList1;
        private TabPage tabPage1;
        private Button BtnDelete;
        private Button BtnUpdate;
        private Button BtnInsert;
        private ComboBox CboProfile;
        private TextBox TxtEmail;
        private TextBox TxtPWD;
        private TextBox TxtName;
        private TextBox TxtID;
        private Label LblUPF;
        private Label LblUE;
        private Label LblUP;
        private Label LblUN;
        private Label LblUI;
    }
}