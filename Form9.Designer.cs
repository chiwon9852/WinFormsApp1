namespace WinFormsApp1
{
    partial class Form9
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
            lblPD_Name = new Label();
            lblCCY = new Label();
            lblU_Price = new Label();
            lblQTY = new Label();
            btnSaleItems = new Button();
            btnViewItems = new Button();
            txtProductName = new TextBox();
            TxtUnitPrice = new TextBox();
            TxtQty = new TextBox();
            CboCCY = new ComboBox();
            listViewItems = new ListView();
            button1 = new Button();
            BtnViwitems = new Button();
            SuspendLayout();
            // 
            // lblPD_Name
            // 
            lblPD_Name.AutoSize = true;
            lblPD_Name.Location = new Point(25, 41);
            lblPD_Name.Name = "lblPD_Name";
            lblPD_Name.Size = new Size(130, 20);
            lblPD_Name.TabIndex = 0;
            lblPD_Name.Text = "PRODUCT_NAME :";
            // 
            // lblCCY
            // 
            lblCCY.AutoSize = true;
            lblCCY.Location = new Point(25, 87);
            lblCCY.Name = "lblCCY";
            lblCCY.Size = new Size(42, 20);
            lblCCY.TabIndex = 1;
            lblCCY.Text = "CCY :";
            // 
            // lblU_Price
            // 
            lblU_Price.AutoSize = true;
            lblU_Price.Location = new Point(25, 131);
            lblU_Price.Name = "lblU_Price";
            lblU_Price.Size = new Size(93, 20);
            lblU_Price.TabIndex = 2;
            lblU_Price.Text = "UNIT_PRICE :";
            // 
            // lblQTY
            // 
            lblQTY.AutoSize = true;
            lblQTY.Location = new Point(25, 179);
            lblQTY.Name = "lblQTY";
            lblQTY.Size = new Size(42, 20);
            lblQTY.TabIndex = 3;
            lblQTY.Text = "QTY :";
            // 
            // btnSaleItems
            // 
            btnSaleItems.Location = new Point(239, 232);
            btnSaleItems.Name = "btnSaleItems";
            btnSaleItems.Size = new Size(144, 55);
            btnSaleItems.TabIndex = 4;
            btnSaleItems.Text = "Sale Items";
            btnSaleItems.UseVisualStyleBackColor = true;
            btnSaleItems.Click += btnSaleItems_Click;
            // 
            // btnViewItems
            // 
            btnViewItems.Location = new Point(0, 0);
            btnViewItems.Name = "btnViewItems";
            btnViewItems.Size = new Size(75, 23);
            btnViewItems.TabIndex = 11;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(239, 34);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(327, 27);
            txtProductName.TabIndex = 6;
            // 
            // TxtUnitPrice
            // 
            TxtUnitPrice.Location = new Point(239, 124);
            TxtUnitPrice.Name = "TxtUnitPrice";
            TxtUnitPrice.Size = new Size(327, 27);
            TxtUnitPrice.TabIndex = 7;
            // 
            // TxtQty
            // 
            TxtQty.Location = new Point(239, 172);
            TxtQty.Name = "TxtQty";
            TxtQty.Size = new Size(327, 27);
            TxtQty.TabIndex = 8;
            // 
            // CboCCY
            // 
            CboCCY.FormattingEnabled = true;
            CboCCY.Items.AddRange(new object[] { "KMR", "USE" });
            CboCCY.Location = new Point(239, 79);
            CboCCY.Name = "CboCCY";
            CboCCY.Size = new Size(327, 28);
            CboCCY.TabIndex = 9;
            // 
            // listViewItems
            // 
            listViewItems.Location = new Point(162, 293);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(474, 156);
            listViewItems.TabIndex = 10;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // BtnViwitems
            // 
            BtnViwitems.Location = new Point(422, 232);
            BtnViwitems.Name = "BtnViwitems";
            BtnViwitems.Size = new Size(144, 55);
            BtnViwitems.TabIndex = 12;
            BtnViwitems.Text = "View Items";
            BtnViwitems.UseVisualStyleBackColor = true;
            BtnViwitems.Click += BtnViwitems_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnViwitems);
            Controls.Add(button1);
            Controls.Add(listViewItems);
            Controls.Add(CboCCY);
            Controls.Add(TxtQty);
            Controls.Add(TxtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(btnViewItems);
            Controls.Add(btnSaleItems);
            Controls.Add(lblQTY);
            Controls.Add(lblU_Price);
            Controls.Add(lblCCY);
            Controls.Add(lblPD_Name);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPD_Name;
        private Label lblCCY;
        private Label lblU_Price;
        private Label lblQTY;
        private Button btnSaleItems;
        private Button btnViewItems;
        private TextBox txtProductName;
        private TextBox TxtUnitPrice;
        private TextBox TxtQty;
        private ComboBox CboCCY;
        private ListView listViewItems;
        private Button button1;
        private Button BtnViwitems;
    }
}