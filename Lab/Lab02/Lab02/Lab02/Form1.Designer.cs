namespace Lab02
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGToolStripMenuItem = new ToolStripMenuItem();
            surrenderToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            GameArea = new TableLayoutPanel();
            panel1 = new Panel();
            vialControl1 = new VialControl();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            menuStrip1.SuspendLayout();
            GameArea.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGToolStripMenuItem, surrenderToolStripMenuItem, exitGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGToolStripMenuItem
            // 
            newGToolStripMenuItem.Name = "newGToolStripMenuItem";
            newGToolStripMenuItem.Size = new Size(264, 44);
            newGToolStripMenuItem.Text = "New Game";
            // 
            // surrenderToolStripMenuItem
            // 
            surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            surrenderToolStripMenuItem.Size = new Size(264, 44);
            surrenderToolStripMenuItem.Text = "Surrender";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(264, 44);
            exitGameToolStripMenuItem.Text = "Exit Game";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(120, 36);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            openSettingsToolStripMenuItem.Size = new Size(299, 44);
            openSettingsToolStripMenuItem.Text = "Open Settings";
            // 
            // GameArea
            // 
            GameArea.ColumnCount = 4;
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            GameArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            GameArea.Controls.Add(panel1, 0, 0);
            GameArea.Controls.Add(panel2, 1, 0);
            GameArea.Controls.Add(panel3, 2, 0);
            GameArea.Controls.Add(panel4, 3, 0);
            GameArea.Dock = DockStyle.Fill;
            GameArea.Location = new Point(0, 40);
            GameArea.Name = "GameArea";
            GameArea.RowCount = 1;
            GameArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            GameArea.Size = new Size(774, 389);
            GameArea.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(vialControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 383);
            panel1.TabIndex = 0;
            // 
            // vialControl1
            // 
            vialControl1.Anchor = AnchorStyles.None;
            vialControl1.BackColor = SystemColors.ControlDarkDark;
            vialControl1.Location = new Point(70, 113);
            vialControl1.MaximumSize = new Size(50, 150);
            vialControl1.MinimumSize = new Size(50, 150);
            vialControl1.Name = "vialControl1";
            vialControl1.Size = new Size(50, 150);
            vialControl1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(196, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 383);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(389, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 383);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(582, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 383);
            panel4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 429);
            Controls.Add(GameArea);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            GameArea.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGToolStripMenuItem;
        private ToolStripMenuItem surrenderToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private TableLayoutPanel GameArea;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private VialControl vialControl1;
    }
}
