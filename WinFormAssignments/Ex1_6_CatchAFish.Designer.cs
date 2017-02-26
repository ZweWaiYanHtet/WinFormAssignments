namespace WinFormAssignments
{
    partial class Ex1_6_CatchAFish
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
            this.btnFish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFish
            // 
            this.btnFish.AutoSize = true;
            this.btnFish.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFish.Location = new System.Drawing.Point(299, 194);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(75, 27);
            this.btnFish.TabIndex = 1;
            this.btnFish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFish.UseVisualStyleBackColor = true;
            this.btnFish.MouseEnter += new System.EventHandler(this.btnFish_MouseEnter);
            // 
            // Ex1_6_CatchAFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.btnFish);
            this.Name = "Ex1_6_CatchAFish";
            this.Text = "Ex1_6_CatchAFish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFish;
    }
}