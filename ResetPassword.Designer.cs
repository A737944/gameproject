﻿namespace GameProject
{
    partial class ResetPassword
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(149, 28);
            label1.Name = "label1";
            label1.Size = new Size(123, 35);
            label1.TabIndex = 0;
            label1.Text = "忘記密碼";
            // 
            // button2
            // 
            button2.Location = new Point(262, 231);
            button2.Name = "button2";
            button2.Size = new Size(125, 44);
            button2.TabIndex = 16;
            button2.Text = "上一頁";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 231);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 15;
            button1.Text = "重製";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 14.25F);
            textBox3.Location = new Point(149, 164);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 35);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 14.25F);
            textBox2.Location = new Point(149, 129);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 35);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 14.25F);
            textBox1.Location = new Point(149, 94);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 35);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20.25F);
            label3.Location = new Point(23, 164);
            label3.Name = "label3";
            label3.Size = new Size(129, 35);
            label3.TabIndex = 11;
            label3.Text = "確認密碼:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F);
            label2.Location = new Point(77, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 35);
            label2.TabIndex = 10;
            label2.Text = "密碼:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20.25F);
            label4.Location = new Point(77, 94);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 9;
            label4.Text = "帳號:";
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 298);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "ResetPassword";
            Text = "忘記密碼";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}