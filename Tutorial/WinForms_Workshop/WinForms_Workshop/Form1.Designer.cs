namespace WinForms_Workshop
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
            nameLabel = new Label();
            nameTextBox = new TextBox();
            goButton = new Button();
            nameErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nameErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = SystemColors.ButtonHighlight;
            nameLabel.ForeColor = SystemColors.ActiveCaptionText;
            nameLabel.Location = new Point(24, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(132, 32);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Your Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(24, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 39);
            nameTextBox.TabIndex = 1;
            nameTextBox.Validating += nameTextBox_Validating;
            // 
            // goButton
            // 
            goButton.Location = new Point(111, 455);
            goButton.Name = "goButton";
            goButton.Size = new Size(314, 46);
            goButton.TabIndex = 2;
            goButton.Text = "OK";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // nameErrorProvider
            // 
            nameErrorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(574, 529);
            Controls.Add(goButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "Form1";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)nameErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Button goButton;
        private ErrorProvider nameErrorProvider;
    }
}
