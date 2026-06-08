namespace WinFormsApp1
{
    partial class Form3
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
            listBoxView = new ListBox();
            btnForLoop = new Button();
            btnWhileLoop = new Button();
            btnDoLoop = new Button();
            LblStar = new Label();
            LnlEnd = new Label();
            TxtStart = new TextBox();
            TxtEnd = new TextBox();
            SuspendLayout();
            // 
            // listBoxView
            // 
            listBoxView.FormattingEnabled = true;
            listBoxView.Location = new Point(-6, 126);
            listBoxView.Name = "listBoxView";
            listBoxView.Size = new Size(803, 164);
            listBoxView.TabIndex = 0;
            // 
            // btnForLoop
            // 
            btnForLoop.Location = new Point(112, 297);
            btnForLoop.Name = "btnForLoop";
            btnForLoop.Size = new Size(132, 52);
            btnForLoop.TabIndex = 1;
            btnForLoop.Text = "For (Loop)";
            btnForLoop.UseVisualStyleBackColor = true;
            btnForLoop.Click += btnForLoop_Click;
            // 
            // btnWhileLoop
            // 
            btnWhileLoop.Location = new Point(269, 297);
            btnWhileLoop.Name = "btnWhileLoop";
            btnWhileLoop.Size = new Size(141, 52);
            btnWhileLoop.TabIndex = 2;
            btnWhileLoop.Text = "While (Loop)";
            btnWhileLoop.UseVisualStyleBackColor = true;
            btnWhileLoop.Click += btnWhileLoop_Click;
            // 
            // btnDoLoop
            // 
            btnDoLoop.Location = new Point(440, 297);
            btnDoLoop.Name = "btnDoLoop";
            btnDoLoop.Size = new Size(133, 52);
            btnDoLoop.TabIndex = 3;
            btnDoLoop.Text = "Do (Loop)";
            btnDoLoop.UseVisualStyleBackColor = true;
            btnDoLoop.Click += btnDoLoop_Click;
            // 
            // LblStar
            // 
            LblStar.AutoSize = true;
            LblStar.Location = new Point(12, 25);
            LblStar.Name = "LblStar";
            LblStar.Size = new Size(47, 20);
            LblStar.TabIndex = 4;
            LblStar.Text = "Start :";
            // 
            // LnlEnd
            // 
            LnlEnd.AutoSize = true;
            LnlEnd.Location = new Point(12, 67);
            LnlEnd.Name = "LnlEnd";
            LnlEnd.Size = new Size(41, 20);
            LnlEnd.TabIndex = 5;
            LnlEnd.Text = "End :";
            // 
            // TxtStart
            // 
            TxtStart.Location = new Point(90, 18);
            TxtStart.Name = "TxtStart";
            TxtStart.Size = new Size(125, 27);
            TxtStart.TabIndex = 6;
            // 
            // TxtEnd
            // 
            TxtEnd.Location = new Point(90, 60);
            TxtEnd.Name = "TxtEnd";
            TxtEnd.Size = new Size(125, 27);
            TxtEnd.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtEnd);
            Controls.Add(TxtStart);
            Controls.Add(LnlEnd);
            Controls.Add(LblStar);
            Controls.Add(btnDoLoop);
            Controls.Add(btnWhileLoop);
            Controls.Add(btnForLoop);
            Controls.Add(listBoxView);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxView;
        private Button btnForLoop;
        private Button btnWhileLoop;
        private Button btnDoLoop;
        private Label LblStar;
        private Label LnlEnd;
        private TextBox TxtStart;
        private TextBox TxtEnd;
    }
}