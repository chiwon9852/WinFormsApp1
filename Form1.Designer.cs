namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblValue = new Label();
            LblVule2 = new Label();
            LblValue3 = new Label();
            TxtValue1 = new TextBox();
            TxtValue3 = new TextBox();
            TxtValue2 = new TextBox();
            LblResult = new Label();
            TxtResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // LblValue
            // 
            LblValue.AutoSize = true;
            LblValue.Location = new Point(83, 18);
            LblValue.Name = "LblValue";
            LblValue.Size = new Size(60, 20);
            LblValue.TabIndex = 0;
            LblValue.Text = "Value1 :";
            // 
            // LblVule2
            // 
            LblVule2.AutoSize = true;
            LblVule2.Location = new Point(83, 67);
            LblVule2.Name = "LblVule2";
            LblVule2.Size = new Size(60, 20);
            LblVule2.TabIndex = 1;
            LblVule2.Text = "Value2 :";
            // 
            // LblValue3
            // 
            LblValue3.AutoSize = true;
            LblValue3.Location = new Point(83, 120);
            LblValue3.Name = "LblValue3";
            LblValue3.Size = new Size(60, 20);
            LblValue3.TabIndex = 2;
            LblValue3.Text = "Value3 :";
            // 
            // TxtValue1
            // 
            TxtValue1.Location = new Point(184, 11);
            TxtValue1.Name = "TxtValue1";
            TxtValue1.Size = new Size(125, 27);
            TxtValue1.TabIndex = 3;
            // 
            // TxtValue3
            // 
            TxtValue3.Location = new Point(184, 117);
            TxtValue3.Name = "TxtValue3";
            TxtValue3.Size = new Size(125, 27);
            TxtValue3.TabIndex = 4;
            // 
            // TxtValue2
            // 
            TxtValue2.Location = new Point(184, 67);
            TxtValue2.Name = "TxtValue2";
            TxtValue2.Size = new Size(125, 27);
            TxtValue2.TabIndex = 5;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(83, 177);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(56, 20);
            LblResult.TabIndex = 6;
            LblResult.Text = "Result :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(184, 177);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(125, 27);
            TxtResult.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(355, -8);
            button1.Name = "button1";
            button1.Size = new Size(94, 73);
            button1.TabIndex = 8;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(446, -4);
            button2.Name = "button2";
            button2.Size = new Size(94, 69);
            button2.TabIndex = 9;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(355, 67);
            button3.Name = "button3";
            button3.Size = new Size(94, 73);
            button3.TabIndex = 10;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 67);
            button4.Name = "button4";
            button4.Size = new Size(94, 73);
            button4.TabIndex = 11;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(399, 146);
            button5.Name = "button5";
            button5.Size = new Size(94, 66);
            button5.TabIndex = 12;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue3);
            Controls.Add(TxtValue1);
            Controls.Add(LblValue3);
            Controls.Add(LblVule2);
            Controls.Add(LblValue);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValue;
        private Label LblVule2;
        private Label LblValue3;
        private TextBox TxtValue1;
        private TextBox TxtValue3;
        private TextBox TxtValue2;
        private Label LblResult;
        private TextBox TxtResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
