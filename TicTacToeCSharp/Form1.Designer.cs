﻿namespace TicTacToeCSharp
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
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 426);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(326, 313);
            button9.Name = "button9";
            button9.Size = new Size(78, 78);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(181, 313);
            button8.Name = "button8";
            button8.Size = new Size(78, 78);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(32, 313);
            button7.Name = "button7";
            button7.Size = new Size(78, 78);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(326, 160);
            button6.Name = "button6";
            button6.Size = new Size(78, 78);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(181, 160);
            button5.Name = "button5";
            button5.Size = new Size(78, 78);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(32, 160);
            button4.Name = "button4";
            button4.Size = new Size(78, 78);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(326, 20);
            button3.Name = "button3";
            button3.Size = new Size(78, 78);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(181, 20);
            button2.Name = "button2";
            button2.Size = new Size(78, 78);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 80.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(32, 20);
            button1.Name = "button1";
            button1.Size = new Size(78, 78);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(469, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
    }
}