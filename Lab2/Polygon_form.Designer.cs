﻿namespace Lab2
{
    partial class Polygon_form
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dots_count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dot_x = new System.Windows.Forms.TextBox();
            this.dot_y = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Enabled = false;
            this.btnDraw.Location = new System.Drawing.Point(26, 175);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(315, 38);
            this.btnDraw.TabIndex = 21;
            this.btnDraw.Text = "Нарисовать многоугольник";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(315, 38);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Добавить точку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dots_count
            // 
            this.dots_count.Location = new System.Drawing.Point(263, 27);
            this.dots_count.Name = "dots_count";
            this.dots_count.Size = new System.Drawing.Size(78, 22);
            this.dots_count.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите количество точек многоугольника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Введите Y координату точки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите X координату точки:";
            // 
            // dot_x
            // 
            this.dot_x.Enabled = false;
            this.dot_x.Location = new System.Drawing.Point(263, 65);
            this.dot_x.Name = "dot_x";
            this.dot_x.Size = new System.Drawing.Size(78, 22);
            this.dot_x.TabIndex = 15;
            // 
            // dot_y
            // 
            this.dot_y.Enabled = false;
            this.dot_y.Location = new System.Drawing.Point(263, 93);
            this.dot_y.Name = "dot_y";
            this.dot_y.Size = new System.Drawing.Size(78, 22);
            this.dot_y.TabIndex = 14;
            // 
            // Polygon_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 256);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dots_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dot_x);
            this.Controls.Add(this.dot_y);
            this.Name = "Polygon_form";
            this.Text = "Polygon_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox dots_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dot_x;
        private System.Windows.Forms.TextBox dot_y;
    }
}