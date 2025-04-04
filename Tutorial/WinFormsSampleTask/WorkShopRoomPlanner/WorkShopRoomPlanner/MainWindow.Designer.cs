namespace WorkShopRoomPlanner
{
    partial class MainWindow
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
            newBlueprintToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            Canvas = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxAddFurnitures = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCoffeTable = new Button();
            buttonTable = new Button();
            buttonsofa = new Button();
            buttonDoubleBed = new Button();
            groupBoxCreatedFurnitures = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBoxAddFurnitures.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(774, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBlueprintToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // newBlueprintToolStripMenuItem
            // 
            newBlueprintToolStripMenuItem.Name = "newBlueprintToolStripMenuItem";
            newBlueprintToolStripMenuItem.Size = new Size(299, 44);
            newBlueprintToolStripMenuItem.Text = "New Blueprint";
            newBlueprintToolStripMenuItem.Click += newBlueprintToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 40);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Canvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(774, 489);
            splitContainer1.SplitterDistance = 472;
            splitContainer1.TabIndex = 1;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(472, 489);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBoxAddFurnitures, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxCreatedFurnitures, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(298, 489);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxAddFurnitures
            // 
            groupBoxAddFurnitures.Controls.Add(flowLayoutPanel1);
            groupBoxAddFurnitures.Dock = DockStyle.Fill;
            groupBoxAddFurnitures.Location = new Point(3, 3);
            groupBoxAddFurnitures.Name = "groupBoxAddFurnitures";
            groupBoxAddFurnitures.Size = new Size(292, 238);
            groupBoxAddFurnitures.TabIndex = 0;
            groupBoxAddFurnitures.TabStop = false;
            groupBoxAddFurnitures.Text = "Add Furnitures";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCoffeTable);
            flowLayoutPanel1.Controls.Add(buttonTable);
            flowLayoutPanel1.Controls.Add(buttonsofa);
            flowLayoutPanel1.Controls.Add(buttonDoubleBed);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(286, 200);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonCoffeTable
            // 
            buttonCoffeTable.BackColor = Color.White;
            buttonCoffeTable.BackgroundImage = Properties.Resources.coffee_table;
            buttonCoffeTable.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCoffeTable.Location = new Point(3, 3);
            buttonCoffeTable.Name = "buttonCoffeTable";
            buttonCoffeTable.Size = new Size(100, 100);
            buttonCoffeTable.TabIndex = 0;
            buttonCoffeTable.UseVisualStyleBackColor = false;
            buttonCoffeTable.Click += buttonFurniture_Click;
            // 
            // buttonTable
            // 
            buttonTable.BackColor = Color.White;
            buttonTable.BackgroundImage = Properties.Resources.table;
            buttonTable.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTable.Location = new Point(109, 3);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(100, 100);
            buttonTable.TabIndex = 1;
            buttonTable.UseVisualStyleBackColor = false;
            buttonTable.Click += buttonFurniture_Click;
            // 
            // buttonsofa
            // 
            buttonsofa.BackColor = Color.White;
            buttonsofa.BackgroundImage = Properties.Resources.sofa;
            buttonsofa.BackgroundImageLayout = ImageLayout.Stretch;
            buttonsofa.Location = new Point(3, 109);
            buttonsofa.Name = "buttonsofa";
            buttonsofa.Size = new Size(100, 100);
            buttonsofa.TabIndex = 2;
            buttonsofa.UseVisualStyleBackColor = false;
            buttonsofa.Click += buttonFurniture_Click;
            // 
            // buttonDoubleBed
            // 
            buttonDoubleBed.BackColor = Color.White;
            buttonDoubleBed.BackgroundImage = Properties.Resources.double_bed;
            buttonDoubleBed.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDoubleBed.Location = new Point(109, 109);
            buttonDoubleBed.Name = "buttonDoubleBed";
            buttonDoubleBed.Size = new Size(100, 100);
            buttonDoubleBed.TabIndex = 3;
            buttonDoubleBed.UseVisualStyleBackColor = false;
            buttonDoubleBed.Click += buttonFurniture_Click;
            // 
            // groupBoxCreatedFurnitures
            // 
            groupBoxCreatedFurnitures.Dock = DockStyle.Fill;
            groupBoxCreatedFurnitures.Location = new Point(3, 247);
            groupBoxCreatedFurnitures.Name = "groupBoxCreatedFurnitures";
            groupBoxCreatedFurnitures.Size = new Size(292, 239);
            groupBoxCreatedFurnitures.TabIndex = 1;
            groupBoxCreatedFurnitures.TabStop = false;
            groupBoxCreatedFurnitures.Text = "Created Furnitures";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 529);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 600);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Window";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxAddFurnitures.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newBlueprintToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxAddFurnitures;
        private GroupBox groupBoxCreatedFurnitures;
        private PictureBox Canvas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCoffeTable;
        private Button buttonTable;
        private Button buttonsofa;
        private Button buttonDoubleBed;
    }
}
