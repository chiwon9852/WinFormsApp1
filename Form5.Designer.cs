namespace WinFormsApp1
{
    partial class Form5
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
            mnuNewFile = new ToolStripMenuItem();
            mnuTextFile = new ToolStripMenuItem();
            mnuWordFile = new ToolStripMenuItem();
            mnuOpenFile = new ToolStripMenuItem();
            mnuSaveFile = new ToolStripMenuItem();
            mnuQuit = new ToolStripMenuItem();
            mnuCut = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fometToolStripMenuItem = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, editToolStripMenuItem, viewToolStripMenuItem, fometToolStripMenuItem, windowToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNewFile, mnuOpenFile, mnuSaveFile, mnuQuit, mnuCut });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "&File";
            // 
            // mnuNewFile
            // 
            mnuNewFile.DropDownItems.AddRange(new ToolStripItem[] { mnuTextFile, mnuWordFile });
            mnuNewFile.Name = "mnuNewFile";
            mnuNewFile.Size = new Size(206, 26);
            mnuNewFile.Text = "New file";
            // 
            // mnuTextFile
            // 
            mnuTextFile.Name = "mnuTextFile";
            mnuTextFile.Size = new Size(155, 26);
            mnuTextFile.Text = "Text File";
            // 
            // mnuWordFile
            // 
            mnuWordFile.Name = "mnuWordFile";
            mnuWordFile.Size = new Size(155, 26);
            mnuWordFile.Text = "Word File";
            // 
            // mnuOpenFile
            // 
            mnuOpenFile.Name = "mnuOpenFile";
            mnuOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpenFile.Size = new Size(206, 26);
            mnuOpenFile.Text = "Open file";
            // 
            // mnuSaveFile
            // 
            mnuSaveFile.Name = "mnuSaveFile";
            mnuSaveFile.ShortcutKeys = Keys.Control | Keys.S;
            mnuSaveFile.Size = new Size(206, 26);
            mnuSaveFile.Text = "Save file";
            // 
            // mnuQuit
            // 
            mnuQuit.Name = "mnuQuit";
            mnuQuit.ShortcutKeys = Keys.Control | Keys.Q;
            mnuQuit.Size = new Size(206, 26);
            mnuQuit.Text = "Quit";
            mnuQuit.Click += mnuQuit_Click;
            // 
            // mnuCut
            // 
            mnuCut.Name = "mnuCut";
            mnuCut.ShortcutKeys = Keys.Control | Keys.C;
            mnuCut.Size = new Size(206, 26);
            mnuCut.Text = "Cut";
            mnuCut.Click += mnuCut_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // fometToolStripMenuItem
            // 
            fometToolStripMenuItem.Name = "fometToolStripMenuItem";
            fometToolStripMenuItem.Size = new Size(68, 24);
            fometToolStripMenuItem.Text = "formet";
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(78, 24);
            windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(166, 71);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(294, 222);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form5";
            Text = "Form5";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNewFile;
        private ToolStripMenuItem mnuOpenFile;
        private ToolStripMenuItem mnuSaveFile;
        private ToolStripMenuItem mnuQuit;
        private ToolStripMenuItem mnuTextFile;
        private ToolStripMenuItem mnuWordFile;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem mnuCut;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fometToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}