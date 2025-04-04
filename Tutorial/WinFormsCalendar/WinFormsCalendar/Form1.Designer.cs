namespace WinFormsCalendar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer = new SplitContainer();
            noteTextBox = new TextBox();
            monthCalendar = new MonthCalendar();
            calendarListView = new ListView();
            dateColumnHeader = new ColumnHeader();
            noteColumnHeader = new ColumnHeader();
            removeButton = new Button();
            addButton = new Button();
            notifyIcon = new NotifyIcon(components);
            notifyIconContextMenu = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = SystemColors.GradientActiveCaption;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(2, 1, 2, 1);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer.Panel1.Controls.Add(noteTextBox);
            splitContainer.Panel1.Controls.Add(monthCalendar);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.ControlLight;
            splitContainer.Panel2.Controls.Add(calendarListView);
            splitContainer.Panel2.Controls.Add(removeButton);
            splitContainer.Panel2.Controls.Add(addButton);
            splitContainer.Size = new Size(848, 448);
            splitContainer.SplitterDistance = 268;
            splitContainer.SplitterWidth = 2;
            splitContainer.TabIndex = 0;
            // 
            // noteTextBox
            // 
            noteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noteTextBox.Location = new Point(554, 8);
            noteTextBox.Margin = new Padding(2, 1, 2, 1);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(288, 254);
            noteTextBox.TabIndex = 1;
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(2, 1);
            monthCalendar.Location = new Point(5, 8);
            monthCalendar.Margin = new Padding(5, 4, 5, 4);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // calendarListView
            // 
            calendarListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarListView.Columns.AddRange(new ColumnHeader[] { dateColumnHeader, noteColumnHeader });
            calendarListView.FullRowSelect = true;
            calendarListView.Location = new Point(5, 36);
            calendarListView.Margin = new Padding(2, 1, 2, 1);
            calendarListView.Name = "calendarListView";
            calendarListView.Size = new Size(838, 149);
            calendarListView.TabIndex = 2;
            calendarListView.UseCompatibleStateImageBehavior = false;
            calendarListView.View = View.Details;
            calendarListView.SelectedIndexChanged += calendarListView_SelectedIndexChanged;
            // 
            // dateColumnHeader
            // 
            dateColumnHeader.Text = "Date";
            dateColumnHeader.Width = 120;
            // 
            // noteColumnHeader
            // 
            noteColumnHeader.Text = "Note";
            noteColumnHeader.Width = 200;
            // 
            // removeButton
            // 
            removeButton.Enabled = false;
            removeButton.Location = new Point(95, 7);
            removeButton.Margin = new Padding(2, 1, 2, 1);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(81, 22);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(5, 7);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(81, 22);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = notifyIconContextMenu;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Windows Forms Calendar";
            notifyIcon.Visible = true;
            // 
            // notifyIconContextMenu
            // 
            notifyIconContextMenu.Name = "notifyIconContextMenu";
            notifyIconContextMenu.Size = new Size(181, 26);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 448);
            Controls.Add(splitContainer);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TextBox noteTextBox;
        private MonthCalendar monthCalendar;
        private ListView calendarListView;
        private Button removeButton;
        private Button addButton;
        private ColumnHeader dateColumnHeader;
        private ColumnHeader noteColumnHeader;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip notifyIconContextMenu;
    }
}
