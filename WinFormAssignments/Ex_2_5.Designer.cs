namespace WinFormAssignments
{
    partial class _2_5
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
            this.gboSize = new System.Windows.Forms.GroupBox();
            this.optBig = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStraw = new System.Windows.Forms.RadioButton();
            this.optChoc = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gboSize.SuspendLayout();
            this.gboFlavor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.optBig);
            this.gboSize.Controls.Add(this.optMedium);
            this.gboSize.Controls.Add(this.optSmall);
            this.gboSize.Location = new System.Drawing.Point(11, 11);
            this.gboSize.Margin = new System.Windows.Forms.Padding(2);
            this.gboSize.Name = "gboSize";
            this.gboSize.Padding = new System.Windows.Forms.Padding(2);
            this.gboSize.Size = new System.Drawing.Size(147, 121);
            this.gboSize.TabIndex = 6;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // optBig
            // 
            this.optBig.AutoSize = true;
            this.optBig.Location = new System.Drawing.Point(25, 94);
            this.optBig.Margin = new System.Windows.Forms.Padding(2);
            this.optBig.Name = "optBig";
            this.optBig.Size = new System.Drawing.Size(49, 21);
            this.optBig.TabIndex = 2;
            this.optBig.Text = "Big";
            this.optBig.UseVisualStyleBackColor = true;
            this.optBig.CheckedChanged += new System.EventHandler(this.optBig_CheckedChanged);
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Location = new System.Drawing.Point(25, 56);
            this.optMedium.Margin = new System.Windows.Forms.Padding(2);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(78, 21);
            this.optMedium.TabIndex = 1;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            this.optMedium.CheckedChanged += new System.EventHandler(this.optMedium_CheckedChanged);
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Checked = true;
            this.optSmall.Location = new System.Drawing.Point(25, 20);
            this.optSmall.Margin = new System.Windows.Forms.Padding(2);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(63, 21);
            this.optSmall.TabIndex = 0;
            this.optSmall.TabStop = true;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            this.optSmall.CheckedChanged += new System.EventHandler(this.optSmall_CheckedChanged);
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStraw);
            this.gboFlavor.Controls.Add(this.optChoc);
            this.gboFlavor.Location = new System.Drawing.Point(11, 178);
            this.gboFlavor.Margin = new System.Windows.Forms.Padding(2);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Padding = new System.Windows.Forms.Padding(2);
            this.gboFlavor.Size = new System.Drawing.Size(147, 93);
            this.gboFlavor.TabIndex = 7;
            this.gboFlavor.TabStop = false;
            this.gboFlavor.Text = "Flavor";
            // 
            // optStraw
            // 
            this.optStraw.AutoSize = true;
            this.optStraw.Location = new System.Drawing.Point(20, 57);
            this.optStraw.Margin = new System.Windows.Forms.Padding(2);
            this.optStraw.Name = "optStraw";
            this.optStraw.Size = new System.Drawing.Size(97, 21);
            this.optStraw.TabIndex = 3;
            this.optStraw.Text = "Strawberry";
            this.optStraw.UseVisualStyleBackColor = true;
            this.optStraw.CheckedChanged += new System.EventHandler(this.optStraw_CheckedChanged);
            // 
            // optChoc
            // 
            this.optChoc.AutoSize = true;
            this.optChoc.Checked = true;
            this.optChoc.Location = new System.Drawing.Point(20, 27);
            this.optChoc.Margin = new System.Windows.Forms.Padding(2);
            this.optChoc.Name = "optChoc";
            this.optChoc.Size = new System.Drawing.Size(92, 21);
            this.optChoc.TabIndex = 2;
            this.optChoc.TabStop = true;
            this.optChoc.Text = "Chocolate";
            this.optChoc.UseVisualStyleBackColor = true;
            this.optChoc.CheckedChanged += new System.EventHandler(this.optChoc_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(11, 288);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(138, 31);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "GetOrder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // _2_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 341);
            this.Controls.Add(this.gboSize);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.btnOrder);
            this.Name = "_2_5";
            this.Text = "_2_5";
            this.Load += new System.EventHandler(this._2_5_Load);
            this.gboSize.ResumeLayout(false);
            this.gboSize.PerformLayout();
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.RadioButton optBig;
        private System.Windows.Forms.RadioButton optMedium;
        private System.Windows.Forms.RadioButton optSmall;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStraw;
        private System.Windows.Forms.RadioButton optChoc;
        private System.Windows.Forms.Button btnOrder;
    }
}