namespace MarkovGui
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.maxLengthTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileDataSet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.removeFileBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.respLengthLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(336, 374);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButtonClick);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(417, 26);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(350, 342);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // maxLengthTb
            // 
            this.maxLengthTb.Location = new System.Drawing.Point(230, 375);
            this.maxLengthTb.Name = "maxLengthTb";
            this.maxLengthTb.Size = new System.Drawing.Size(100, 20);
            this.maxLengthTb.TabIndex = 4;
            this.maxLengthTb.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "max length";
            // 
            // fileDataSet
            // 
            this.fileDataSet.FormattingEnabled = true;
            this.fileDataSet.Location = new System.Drawing.Point(12, 184);
            this.fileDataSet.Name = "fileDataSet";
            this.fileDataSet.Size = new System.Drawing.Size(262, 186);
            this.fileDataSet.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.respLengthLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(280, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "info";
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(12, 373);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(67, 23);
            this.addFileBtn.TabIndex = 8;
            this.addFileBtn.Text = "add file";
            this.addFileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // removeFileBtn
            // 
            this.removeFileBtn.Location = new System.Drawing.Point(85, 373);
            this.removeFileBtn.Name = "removeFileBtn";
            this.removeFileBtn.Size = new System.Drawing.Size(67, 23);
            this.removeFileBtn.TabIndex = 9;
            this.removeFileBtn.Text = "remove";
            this.removeFileBtn.UseVisualStyleBackColor = true;
            this.removeFileBtn.Click += new System.EventHandler(this.removeFileBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(69, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "resp_length:";
            // 
            // respLengthLabel
            // 
            this.respLengthLabel.AutoSize = true;
            this.respLengthLabel.Location = new System.Drawing.Point(69, 50);
            this.respLengthLabel.Name = "respLengthLabel";
            this.respLengthLabel.Size = new System.Drawing.Size(10, 13);
            this.respLengthLabel.TabIndex = 3;
            this.respLengthLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeFileBtn);
            this.Controls.Add(this.addFileBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileDataSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxLengthTb);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Content generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox maxLengthTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fileDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.Button removeFileBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label respLengthLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label4;
    }
}

