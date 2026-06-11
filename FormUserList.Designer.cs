namespace WinFormsApp1
{
    partial class FormUserList
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
            dgvUser = new DataGridView();
            lblSearchName = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(0, 38);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(800, 413);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick_1;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            // 
            // lblSearchName
            // 
            lblSearchName.AutoSize = true;
            lblSearchName.Location = new Point(8, 8);
            lblSearchName.Name = "lblSearchName";
            lblSearchName.Size = new Size(112, 20);
            lblSearchName.TabIndex = 1;
            lblSearchName.Text = "SearchName  :  ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(118, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(670, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FormUserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(lblSearchName);
            Controls.Add(dgvUser);
            Name = "FormUserList";
            Text = "FormUserList";
            Load += FormUserList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgvUser;
        private Label lblSearchName;
        private TextBox txtSearch;
    }
}