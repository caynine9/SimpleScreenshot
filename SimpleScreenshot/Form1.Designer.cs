namespace SimpleScreenshot
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
            this.Capture.Click += new System.EventHandler(this.CaptureScreenshot);
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Capture = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            optioonsToolStripMenuItem = new ToolStripMenuItem();
            changeNameFormatToolStripMenuItem = new ToolStripMenuItem();
            changePreferredFileFormatToolStripMenuItem = new ToolStripMenuItem();
            pNGToolStripMenuItem = new ToolStripMenuItem();
            jPEGToolStripMenuItem = new ToolStripMenuItem();
            bMPToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Capture
            // 
            Capture.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Capture.Location = new Point(478, 300);
            Capture.Name = "Capture";
            Capture.Size = new Size(92, 26);
            Capture.TabIndex = 0;
            Capture.Text = "Capture";
            Capture.UseVisualStyleBackColor = true;
            Capture.Click += CaptureScreenshot;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(12, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optioonsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click_1;
            // 
            // optioonsToolStripMenuItem
            // 
            optioonsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeNameFormatToolStripMenuItem, changePreferredFileFormatToolStripMenuItem });
            optioonsToolStripMenuItem.Name = "optioonsToolStripMenuItem";
            optioonsToolStripMenuItem.Size = new Size(61, 20);
            optioonsToolStripMenuItem.Text = "Options";
            optioonsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // changeNameFormatToolStripMenuItem
            // 
            changeNameFormatToolStripMenuItem.Name = "changeNameFormatToolStripMenuItem";
            changeNameFormatToolStripMenuItem.Size = new Size(233, 22);
            changeNameFormatToolStripMenuItem.Text = "Change name format...";
            // 
            // changePreferredFileFormatToolStripMenuItem
            // 
            changePreferredFileFormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pNGToolStripMenuItem, jPEGToolStripMenuItem, bMPToolStripMenuItem });
            changePreferredFileFormatToolStripMenuItem.Name = "changePreferredFileFormatToolStripMenuItem";
            changePreferredFileFormatToolStripMenuItem.Size = new Size(233, 22);
            changePreferredFileFormatToolStripMenuItem.Text = "Change preferred file format...";
            // 
            // pNGToolStripMenuItem
            // 
            pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            pNGToolStripMenuItem.Size = new Size(180, 22);
            pNGToolStripMenuItem.Text = "PNG  (default)";
            pNGToolStripMenuItem.Click += pNGToolStripMenuItem_Click;
            // 
            // jPEGToolStripMenuItem
            // 
            jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            jPEGToolStripMenuItem.Size = new Size(180, 22);
            jPEGToolStripMenuItem.Text = "JPEG";
            jPEGToolStripMenuItem.Click += jPEGToolStripMenuItem_Click;
            // 
            // bMPToolStripMenuItem
            // 
            bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            bMPToolStripMenuItem.Size = new Size(180, 22);
            bMPToolStripMenuItem.Text = "BMP";
            bMPToolStripMenuItem.Click += bMPToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(582, 338);
            Controls.Add(pictureBox1);
            Controls.Add(Capture);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleScreenshot";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Capture;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optioonsToolStripMenuItem;
        private ToolStripMenuItem changeNameFormatToolStripMenuItem;
        private ToolStripMenuItem changePreferredFileFormatToolStripMenuItem;
        private ToolStripMenuItem pNGToolStripMenuItem;
        private ToolStripMenuItem jPEGToolStripMenuItem;
        private ToolStripMenuItem bMPToolStripMenuItem;
    }
}
