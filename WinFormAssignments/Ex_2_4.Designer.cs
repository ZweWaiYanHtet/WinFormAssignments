namespace WinFormAssignments
{
    partial class _2_4
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.optBig = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(29, 191);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 26);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "GetOrder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // optBig
            // 
            this.optBig.AutoSize = true;
            this.optBig.Location = new System.Drawing.Point(29, 136);
            this.optBig.Margin = new System.Windows.Forms.Padding(2);
            this.optBig.Name = "optBig";
            this.optBig.Size = new System.Drawing.Size(49, 21);
            this.optBig.TabIndex = 10;
            this.optBig.Text = "Big";
            this.optBig.UseVisualStyleBackColor = true;
            this.optBig.CheckedChanged += new System.EventHandler(this.optBig_CheckedChanged);
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Location = new System.Drawing.Point(29, 80);
            this.optMedium.Margin = new System.Windows.Forms.Padding(2);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(78, 21);
            this.optMedium.TabIndex = 9;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            this.optMedium.CheckedChanged += new System.EventHandler(this.optMedium_CheckedChanged);
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Location = new System.Drawing.Point(29, 29);
            this.optSmall.Margin = new System.Windows.Forms.Padding(2);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(63, 21);
            this.optSmall.TabIndex = 8;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            this.optSmall.CheckedChanged += new System.EventHandler(this.optSmall_CheckedChanged);
            // 
            // _2_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 253);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.optBig);
            this.Controls.Add(this.optMedium);
            this.Controls.Add(this.optSmall);
            this.Name = "_2_4";
            this.Text = "_2_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton optBig;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.RadioButton optSmall;
    }
}