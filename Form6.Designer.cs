namespace WinFormsApp1
{
    partial class Form6
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
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuOpenpic1 = new ToolStripMenuItem();
            mnuOpenpic2 = new ToolStripMenuItem();
            mnuOpenpic3 = new ToolStripMenuItem();
            mnuOpenpic4 = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            pcb1 = new PictureBox();
            pcb2 = new PictureBox();
            pcb3 = new PictureBox();
            pcb4 = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcb4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenpic1, mnuOpenpic2, mnuOpenpic3, mnuOpenpic4, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "&File";
            // 
            // mnuOpenpic1
            // 
            mnuOpenpic1.Name = "mnuOpenpic1";
            mnuOpenpic1.ShortcutKeys = Keys.Control | Keys.D1;
            mnuOpenpic1.Size = new Size(224, 26);
            mnuOpenpic1.Text = "Open pic1";
            mnuOpenpic1.Click += mnuOpenpic1_Click;
            // 
            // mnuOpenpic2
            // 
            mnuOpenpic2.Name = "mnuOpenpic2";
            mnuOpenpic2.ShortcutKeys = Keys.Control | Keys.D2;
            mnuOpenpic2.Size = new Size(224, 26);
            mnuOpenpic2.Text = "Open pic2";
            mnuOpenpic2.Click += mnuOpenpic2_Click;
            // 
            // mnuOpenpic3
            // 
            mnuOpenpic3.Name = "mnuOpenpic3";
            mnuOpenpic3.ShortcutKeys = Keys.Control | Keys.D3;
            mnuOpenpic3.Size = new Size(224, 26);
            mnuOpenpic3.Text = "Open pic3";
            mnuOpenpic3.Click += mnuOpenpic3_Click;
            // 
            // mnuOpenpic4
            // 
            mnuOpenpic4.Name = "mnuOpenpic4";
            mnuOpenpic4.ShortcutKeys = Keys.Control | Keys.D4;
            mnuOpenpic4.Size = new Size(224, 26);
            mnuOpenpic4.Text = "Open pic4";
            mnuOpenpic4.Click += mnuOpenpic4_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Exit ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pcb1, 0, 0);
            tableLayoutPanel1.Controls.Add(pcb2, 1, 0);
            tableLayoutPanel1.Controls.Add(pcb3, 0, 1);
            tableLayoutPanel1.Controls.Add(pcb4, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 417);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pcb1
            // 
            pcb1.Dock = DockStyle.Fill;
            pcb1.Location = new Point(3, 3);
            pcb1.Name = "pcb1";
            pcb1.Size = new Size(394, 202);
            pcb1.SizeMode = PictureBoxSizeMode.Zoom;
            pcb1.TabIndex = 0;
            pcb1.TabStop = false;
            pcb1.Click += pcb1_Click;
            // 
            // pcb2
            // 
            pcb2.Dock = DockStyle.Fill;
            pcb2.Location = new Point(403, 3);
            pcb2.Name = "pcb2";
            pcb2.Size = new Size(394, 202);
            pcb2.SizeMode = PictureBoxSizeMode.Zoom;
            pcb2.TabIndex = 1;
            pcb2.TabStop = false;
            // 
            // pcb3
            // 
            pcb3.Dock = DockStyle.Fill;
            pcb3.Location = new Point(3, 211);
            pcb3.Name = "pcb3";
            pcb3.Size = new Size(394, 203);
            pcb3.SizeMode = PictureBoxSizeMode.Zoom;
            pcb3.TabIndex = 2;
            pcb3.TabStop = false;
            // 
            // pcb4
            // 
            pcb4.Dock = DockStyle.Fill;
            pcb4.Location = new Point(403, 211);
            pcb4.Name = "pcb4";
            pcb4.Size = new Size(394, 203);
            pcb4.SizeMode = PictureBoxSizeMode.Zoom;
            pcb4.TabIndex = 3;
            pcb4.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form6";
            Text = "Form6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcb4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuOpenpic1;
        private ToolStripMenuItem mnuOpenpic2;
        private ToolStripMenuItem mnuOpenpic3;
        private ToolStripMenuItem mnuOpenpic4;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pcb1;
        private PictureBox pcb2;
        private PictureBox pcb3;
        private PictureBox pcb4;
        private ToolStripMenuItem mnuExit;
    }
}