namespace Cracker95CS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OutputKeyBox = new TextBox();
            GenerateBtn = new Button();
            KeyTypeSelectBox = new GroupBox();
            OemKeySel = new RadioButton();
            CdKeySel = new RadioButton();
            CopyBtn = new Button();
            ValidatorInputBox = new TextBox();
            ValidatorBtn = new Button();
            ValidatorPasteBtn = new Button();
            ValidatorOutputLabel = new Label();
            pictureBox1 = new PictureBox();
            KeyTypeSelectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OutputKeyBox
            // 
            OutputKeyBox.Location = new Point(12, 12);
            OutputKeyBox.Name = "OutputKeyBox";
            OutputKeyBox.ReadOnly = true;
            OutputKeyBox.Size = new Size(156, 23);
            OutputKeyBox.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(174, 12);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(75, 23);
            GenerateBtn.TabIndex = 1;
            GenerateBtn.Text = "Generate!";
            GenerateBtn.UseVisualStyleBackColor = true;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // KeyTypeSelectBox
            // 
            KeyTypeSelectBox.Controls.Add(OemKeySel);
            KeyTypeSelectBox.Controls.Add(CdKeySel);
            KeyTypeSelectBox.Location = new Point(216, 41);
            KeyTypeSelectBox.Name = "KeyTypeSelectBox";
            KeyTypeSelectBox.Size = new Size(85, 78);
            KeyTypeSelectBox.TabIndex = 2;
            KeyTypeSelectBox.TabStop = false;
            KeyTypeSelectBox.Text = "Key Type";
            // 
            // OemKeySel
            // 
            OemKeySel.AutoSize = true;
            OemKeySel.Location = new Point(6, 47);
            OemKeySel.Name = "OemKeySel";
            OemKeySel.Size = new Size(73, 19);
            OemKeySel.TabIndex = 4;
            OemKeySel.Text = "OEM Key";
            OemKeySel.UseVisualStyleBackColor = true;
            // 
            // CdKeySel
            // 
            CdKeySel.AutoSize = true;
            CdKeySel.Checked = true;
            CdKeySel.Location = new Point(6, 22);
            CdKeySel.Name = "CdKeySel";
            CdKeySel.Size = new Size(63, 19);
            CdKeySel.TabIndex = 3;
            CdKeySel.TabStop = true;
            CdKeySel.Text = "CD Key";
            CdKeySel.UseVisualStyleBackColor = true;
            // 
            // CopyBtn
            // 
            CopyBtn.Location = new Point(255, 12);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(75, 23);
            CopyBtn.TabIndex = 4;
            CopyBtn.Text = "Copy!";
            CopyBtn.UseVisualStyleBackColor = true;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // ValidatorInputBox
            // 
            ValidatorInputBox.Location = new Point(12, 231);
            ValidatorInputBox.Name = "ValidatorInputBox";
            ValidatorInputBox.PlaceholderText = "Enter key to validate";
            ValidatorInputBox.Size = new Size(156, 23);
            ValidatorInputBox.TabIndex = 5;
            // 
            // ValidatorBtn
            // 
            ValidatorBtn.Location = new Point(174, 231);
            ValidatorBtn.Name = "ValidatorBtn";
            ValidatorBtn.Size = new Size(75, 23);
            ValidatorBtn.TabIndex = 6;
            ValidatorBtn.Text = "Validate!";
            ValidatorBtn.UseVisualStyleBackColor = true;
            ValidatorBtn.Click += ValidatorBtn_Click;
            // 
            // ValidatorPasteBtn
            // 
            ValidatorPasteBtn.Location = new Point(255, 231);
            ValidatorPasteBtn.Name = "ValidatorPasteBtn";
            ValidatorPasteBtn.Size = new Size(75, 23);
            ValidatorPasteBtn.TabIndex = 7;
            ValidatorPasteBtn.Text = "Paste!";
            ValidatorPasteBtn.UseVisualStyleBackColor = true;
            ValidatorPasteBtn.Click += ValidatorPasteBtn_Click;
            // 
            // ValidatorOutputLabel
            // 
            ValidatorOutputLabel.AutoSize = true;
            ValidatorOutputLabel.Location = new Point(12, 262);
            ValidatorOutputLabel.Name = "ValidatorOutputLabel";
            ValidatorOutputLabel.Size = new Size(38, 15);
            ValidatorOutputLabel.TabIndex = 8;
            ValidatorOutputLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trolla;
            pictureBox1.Location = new Point(49, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(356, 286);
            Controls.Add(pictureBox1);
            Controls.Add(ValidatorOutputLabel);
            Controls.Add(ValidatorPasteBtn);
            Controls.Add(ValidatorBtn);
            Controls.Add(ValidatorInputBox);
            Controls.Add(CopyBtn);
            Controls.Add(KeyTypeSelectBox);
            Controls.Add(GenerateBtn);
            Controls.Add(OutputKeyBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(372, 325);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cracker95 C#";
            Load += Form1_Load;
            KeyTypeSelectBox.ResumeLayout(false);
            KeyTypeSelectBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OutputKeyBox;
        private Button GenerateBtn;
        private GroupBox KeyTypeSelectBox;
        private RadioButton OemKeySel;
        private RadioButton CdKeySel;
        private Button CopyBtn;
        private TextBox ValidatorInputBox;
        private Button ValidatorBtn;
        private Button ValidatorPasteBtn;
        private Label ValidatorOutputLabel;
        private PictureBox pictureBox1;
    }
}