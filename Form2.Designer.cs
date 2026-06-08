namespace WinFormsApp1
{
    partial class Form2
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
            TxtOption = new Label();
            LblInput1 = new Label();
            LblIput2 = new Label();
            LblInput3 = new Label();
            TxtInput1 = new TextBox();
            TxtInput2 = new TextBox();
            TxtInput3 = new TextBox();
            TxtView = new TextBox();
            BtnView = new Button();
            CboOption = new ComboBox();
            BtnViewSwitch = new Button();
            SuspendLayout();
            // 
            // TxtOption
            // 
            TxtOption.AutoSize = true;
            TxtOption.Location = new Point(110, 32);
            TxtOption.Name = "TxtOption";
            TxtOption.Size = new Size(62, 20);
            TxtOption.TabIndex = 0;
            TxtOption.Text = "Option :";
            // 
            // LblInput1
            // 
            LblInput1.AutoSize = true;
            LblInput1.Location = new Point(110, 76);
            LblInput1.Name = "LblInput1";
            LblInput1.Size = new Size(58, 20);
            LblInput1.TabIndex = 1;
            LblInput1.Text = "Input1 :";
            // 
            // LblIput2
            // 
            LblIput2.AutoSize = true;
            LblIput2.Location = new Point(110, 117);
            LblIput2.Name = "LblIput2";
            LblIput2.Size = new Size(58, 20);
            LblIput2.TabIndex = 2;
            LblIput2.Text = "Input2 :";
            // 
            // LblInput3
            // 
            LblInput3.AutoSize = true;
            LblInput3.Location = new Point(110, 155);
            LblInput3.Name = "LblInput3";
            LblInput3.Size = new Size(58, 20);
            LblInput3.TabIndex = 3;
            LblInput3.Text = "Input3 :";
            // 
            // TxtInput1
            // 
            TxtInput1.Location = new Point(201, 69);
            TxtInput1.Name = "TxtInput1";
            TxtInput1.Size = new Size(175, 27);
            TxtInput1.TabIndex = 4;
            // 
            // TxtInput2
            // 
            TxtInput2.Location = new Point(201, 110);
            TxtInput2.Name = "TxtInput2";
            TxtInput2.Size = new Size(175, 27);
            TxtInput2.TabIndex = 5;
            // 
            // TxtInput3
            // 
            TxtInput3.Location = new Point(201, 155);
            TxtInput3.Name = "TxtInput3";
            TxtInput3.Size = new Size(175, 27);
            TxtInput3.TabIndex = 6;
            // 
            // TxtView
            // 
            TxtView.Location = new Point(201, 202);
            TxtView.Name = "TxtView";
            TxtView.Size = new Size(175, 27);
            TxtView.TabIndex = 7;
            // 
            // BtnView
            // 
            BtnView.Location = new Point(236, 246);
            BtnView.Name = "BtnView";
            BtnView.Size = new Size(94, 29);
            BtnView.TabIndex = 8;
            BtnView.Text = "View ";
            BtnView.UseVisualStyleBackColor = true;
            BtnView.Click += BtnView_Click;
            // 
            // CboOption
            // 
            CboOption.FormattingEnabled = true;
            CboOption.Location = new Point(201, 29);
            CboOption.Name = "CboOption";
            CboOption.Size = new Size(175, 28);
            CboOption.TabIndex = 9;
            CboOption.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnViewSwitch
            // 
            BtnViewSwitch.Location = new Point(236, 281);
            BtnViewSwitch.Name = "BtnViewSwitch";
            BtnViewSwitch.Size = new Size(94, 29);
            BtnViewSwitch.TabIndex = 10;
            BtnViewSwitch.Text = "ViewSwitch";
            BtnViewSwitch.UseVisualStyleBackColor = true;
            BtnViewSwitch.Click += BtnViewSwitch_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnViewSwitch);
            Controls.Add(CboOption);
            Controls.Add(BtnView);
            Controls.Add(TxtView);
            Controls.Add(TxtInput3);
            Controls.Add(TxtInput2);
            Controls.Add(TxtInput1);
            Controls.Add(LblInput3);
            Controls.Add(LblIput2);
            Controls.Add(LblInput1);
            Controls.Add(TxtOption);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtOption;
        private Label LblInput1;
        private Label LblIput2;
        private Label LblInput3;
        private TextBox TxtInput1;
        private TextBox TxtInput2;
        private TextBox TxtInput3;
        private TextBox TxtView;
        private Button BtnView;
        private ComboBox CboOption;
        private Button BtnViewSwitch;
    }
}