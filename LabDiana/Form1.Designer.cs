namespace LabDiana
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
            btnEncode = new Button();
            btnDecode = new Button();
            lblResult = new Label();
            label1 = new Label();
            pathToFile = new Label();
            btnOpenFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            numericUpDownKey = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKey).BeginInit();
            SuspendLayout();
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(12, 248);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(199, 89);
            btnEncode.TabIndex = 0;
            btnEncode.Text = "Encode";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(217, 248);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(192, 89);
            btnDecode.TabIndex = 1;
            btnDecode.Text = "Decode";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(17, 350);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Путь: ";
            // 
            // pathToFile
            // 
            pathToFile.AutoSize = true;
            pathToFile.Location = new Point(47, 10);
            pathToFile.Name = "pathToFile";
            pathToFile.Size = new Size(0, 15);
            pathToFile.TabIndex = 4;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 28);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(75, 23);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "Открыть";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDownKey
            // 
            numericUpDownKey.Location = new Point(12, 133);
            numericUpDownKey.Name = "numericUpDownKey";
            numericUpDownKey.Size = new Size(120, 23);
            numericUpDownKey.TabIndex = 6;
            numericUpDownKey.ValueChanged += numericUpDownKey_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 115);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 7;
            label2.Text = "Секретный ключ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 374);
            Controls.Add(label2);
            Controls.Add(numericUpDownKey);
            Controls.Add(btnOpenFile);
            Controls.Add(pathToFile);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(btnDecode);
            Controls.Add(btnEncode);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncode;
        private Button btnDecode;
        private Label lblResult;
        private Label label1;
        private Label pathToFile;
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown numericUpDownKey;
        private Label label2;
    }
}