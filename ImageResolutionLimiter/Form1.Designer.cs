namespace ImageResolutionLimiter
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
            richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            buttonStart = new System.Windows.Forms.Button();
            textBoxX = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxY = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            checkBoxBackup = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            textBoxFolder = new System.Windows.Forms.TextBox();
            buttonSelectFolder = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richTextBoxOutput.Location = new System.Drawing.Point(12, 253);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.Size = new System.Drawing.Size(459, 196);
            richTextBoxOutput.TabIndex = 0;
            richTextBoxOutput.Text = "";
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(12, 455);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(200, 27);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new System.Drawing.Point(12, 110);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new System.Drawing.Size(200, 23);
            textBoxX.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Resolution X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 136);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Resolution Y";
            // 
            // textBoxY
            // 
            textBoxY.Location = new System.Drawing.Point(12, 154);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new System.Drawing.Size(200, 23);
            textBoxY.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Output";
            // 
            // checkBoxBackup
            // 
            checkBoxBackup.AutoSize = true;
            checkBoxBackup.Location = new System.Drawing.Point(12, 197);
            checkBoxBackup.Name = "checkBoxBackup";
            checkBoxBackup.Size = new System.Drawing.Size(107, 19);
            checkBoxBackup.TabIndex = 7;
            checkBoxBackup.Text = "Create backups";
            checkBoxBackup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 9;
            label4.Text = "Folder";
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new System.Drawing.Point(12, 27);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.Size = new System.Drawing.Size(200, 23);
            textBoxFolder.TabIndex = 8;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buttonSelectFolder.Location = new System.Drawing.Point(12, 56);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new System.Drawing.Size(200, 27);
            buttonSelectFolder.TabIndex = 10;
            buttonSelectFolder.Text = "Select folder";
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(483, 495);
            Controls.Add(buttonSelectFolder);
            Controls.Add(label4);
            Controls.Add(textBoxFolder);
            Controls.Add(checkBoxBackup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxY);
            Controls.Add(label1);
            Controls.Add(textBoxX);
            Controls.Add(buttonStart);
            Controls.Add(richTextBoxOutput);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Image Resolution Limiter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
    }
}
