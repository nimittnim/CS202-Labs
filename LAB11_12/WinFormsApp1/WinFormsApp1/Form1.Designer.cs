﻿namespace WinFormsApp1
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
            txtTime = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 120);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Time (HH:MM:SS):";
            label1.Click += label1_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(322, 152);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 1;
            txtTime.TextChanged += textBox1_TextChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(332, 192);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Timer";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(txtTime);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTime;
        private Button btnStart;
    }
}
