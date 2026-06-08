namespace WinFormsApp1
{
    partial class Form4
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
            LblNumberList = new Label();
            CboNumberList = new ComboBox();
            BtnAdd = new Button();
            BtnRemove = new Button();
            BtnClear = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // LblNumberList
            // 
            LblNumberList.AutoSize = true;
            LblNumberList.Location = new Point(31, 34);
            LblNumberList.Name = "LblNumberList";
            LblNumberList.Size = new Size(96, 20);
            LblNumberList.TabIndex = 0;
            LblNumberList.Text = "Number List :";
            // 
            // CboNumberList
            // 
            CboNumberList.FormattingEnabled = true;
            CboNumberList.Location = new Point(150, 26);
            CboNumberList.Name = "CboNumberList";
            CboNumberList.Size = new Size(337, 28);
            CboNumberList.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(73, 89);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 29);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add(+)";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(224, 89);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(94, 29);
            BtnRemove.TabIndex = 3;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(393, 89);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 29);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(100, 143);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(350, 58);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search...";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(BtnClear);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAdd);
            Controls.Add(CboNumberList);
            Controls.Add(LblNumberList);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNumberList;
        private ComboBox CboNumberList;
        private Button BtnAdd;
        private Button BtnRemove;
        private Button BtnClear;
        private Button btnSearch;
    }
}