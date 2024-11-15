namespace Vector_Generator
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
            label1 = new Label();
            txtSize = new TextBox();
            btnGenerate = new Button();
            lstVector = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Array size:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Segoe UI", 15F);
            txtSize.Location = new Point(40, 55);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(85, 34);
            txtSize.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(158, 55);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(118, 34);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate vector";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lstVector
            // 
            lstVector.FormattingEnabled = true;
            lstVector.ItemHeight = 15;
            lstVector.Location = new Point(36, 126);
            lstVector.Name = "lstVector";
            lstVector.Size = new Size(344, 64);
            lstVector.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstVector);
            Controls.Add(btnGenerate);
            Controls.Add(txtSize);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSize;
        private Button btnGenerate;
        private ListBox lstVector;
    }
}
