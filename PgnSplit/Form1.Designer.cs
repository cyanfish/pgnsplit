namespace PgnSplit
{
    partial class Form1
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnFilePrompt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKeepOriginal = new System.Windows.Forms.CheckBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtPartSize = new System.Windows.Forms.TextBox();
            this.cbSizeUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(12, 25);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(329, 20);
            this.txtFile.TabIndex = 0;
            // 
            // btnFilePrompt
            // 
            this.btnFilePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilePrompt.Location = new System.Drawing.Point(347, 25);
            this.btnFilePrompt.Name = "btnFilePrompt";
            this.btnFilePrompt.Size = new System.Drawing.Size(25, 20);
            this.btnFilePrompt.TabIndex = 1;
            this.btnFilePrompt.Text = "...";
            this.btnFilePrompt.UseVisualStyleBackColor = true;
            this.btnFilePrompt.Click += new System.EventHandler(this.btnFilePrompt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Part size:";
            // 
            // cbKeepOriginal
            // 
            this.cbKeepOriginal.AutoSize = true;
            this.cbKeepOriginal.Location = new System.Drawing.Point(113, 82);
            this.cbKeepOriginal.Name = "cbKeepOriginal";
            this.cbKeepOriginal.Size = new System.Drawing.Size(103, 17);
            this.cbKeepOriginal.TabIndex = 6;
            this.cbKeepOriginal.Text = "Keep original file";
            this.cbKeepOriginal.UseVisualStyleBackColor = true;
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplit.Location = new System.Drawing.Point(297, 78);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 7;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtPartSize
            // 
            this.txtPartSize.Location = new System.Drawing.Point(12, 80);
            this.txtPartSize.Name = "txtPartSize";
            this.txtPartSize.Size = new System.Drawing.Size(28, 20);
            this.txtPartSize.TabIndex = 8;
            this.txtPartSize.Text = "1";
            // 
            // cbSizeUnit
            // 
            this.cbSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSizeUnit.FormattingEnabled = true;
            this.cbSizeUnit.ItemHeight = 13;
            this.cbSizeUnit.Items.AddRange(new object[] {
            "MB",
            "GB"});
            this.cbSizeUnit.Location = new System.Drawing.Point(45, 80);
            this.cbSizeUnit.Name = "cbSizeUnit";
            this.cbSizeUnit.Size = new System.Drawing.Size(41, 21);
            this.cbSizeUnit.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 113);
            this.Controls.Add(this.cbSizeUnit);
            this.Controls.Add(this.txtPartSize);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.cbKeepOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilePrompt);
            this.Controls.Add(this.txtFile);
            this.MaximumSize = new System.Drawing.Size(1000, 152);
            this.MinimumSize = new System.Drawing.Size(350, 152);
            this.Name = "Form1";
            this.Text = "PGN Split";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnFilePrompt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbKeepOriginal;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtPartSize;
        private System.Windows.Forms.ComboBox cbSizeUnit;
    }
}

