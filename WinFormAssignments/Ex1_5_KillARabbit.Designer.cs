﻿namespace WinFormAssignments
{
    partial class Ex1_5_KillARabbit
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
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.AutoSize = true;
            this.btnRabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRabbit.Location = new System.Drawing.Point(360, 156);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(75, 27);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.Text = "Rabbit";
            this.btnRabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseDown);
            this.btnRabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseUp);
            // 
            // Ex1_5_KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.btnRabbit);
            this.Name = "Ex1_5_KillARabbit";
            this.Text = "Ex1_5_KillARabbit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}