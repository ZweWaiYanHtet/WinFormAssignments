namespace WinFormAssignments
{
    partial class Ex_1_7_CatchAGenie
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
            this.picGenie = new System.Windows.Forms.PictureBox();
            this.picLamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp)).BeginInit();
            this.SuspendLayout();
            // 
            // picGenie
            // 
            this.picGenie.Image = global::WinFormAssignments.Properties.Resources.Genie;
            this.picGenie.Location = new System.Drawing.Point(350, 158);
            this.picGenie.Name = "picGenie";
            this.picGenie.Size = new System.Drawing.Size(128, 128);
            this.picGenie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGenie.TabIndex = 1;
            this.picGenie.TabStop = false;
            this.picGenie.Visible = false;
            // 
            // picLamp
            // 
            this.picLamp.Image = global::WinFormAssignments.Properties.Resources.magic_lamp;
            this.picLamp.Location = new System.Drawing.Point(122, 309);
            this.picLamp.Name = "picLamp";
            this.picLamp.Size = new System.Drawing.Size(50, 40);
            this.picLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLamp.TabIndex = 0;
            this.picLamp.TabStop = false;
            this.picLamp.Click += new System.EventHandler(this.picLamp_Click);
            this.picLamp.DoubleClick += new System.EventHandler(this.picLamp_DoubleClick);
            this.picLamp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picLamp_MouseMove);
            // 
            // Ex_1_7_CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.picGenie);
            this.Controls.Add(this.picLamp);
            this.Name = "Ex_1_7_CatchAGenie";
            this.Text = "Ex_1_7_CatchAGenie";
            ((System.ComponentModel.ISupportInitialize)(this.picGenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLamp;
        private System.Windows.Forms.PictureBox picGenie;
    }
}