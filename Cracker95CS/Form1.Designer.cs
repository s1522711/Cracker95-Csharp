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
            components = new System.ComponentModel.Container();
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
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            KeyTypeSelectBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OutputKeyBox
            // 
            OutputKeyBox.Location = new Point(12, 34);
            OutputKeyBox.Name = "OutputKeyBox";
            OutputKeyBox.ReadOnly = true;
            OutputKeyBox.Size = new Size(156, 23);
            OutputKeyBox.TabIndex = 0;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(174, 34);
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
            KeyTypeSelectBox.Location = new Point(216, 63);
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
            CopyBtn.Location = new Point(255, 34);
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
            ValidatorOutputLabel.Size = new Size(346, 15);
            ValidatorOutputLabel.TabIndex = 8;
            ValidatorOutputLabel.Text = "Enter a key above and press the validate button to validate a key!";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 10;
            label1.Text = "Windows 95 Key Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 11;
            label2.Text = "Windows 95 CD/OEM Key Validator";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(-1, 187);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(600, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Interval = 400;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(356, 286);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
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
            MaximumSize = new Size(9999, 325);
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
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}