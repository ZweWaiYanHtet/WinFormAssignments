namespace WinFormAssignments
{
    partial class Ex_2_9
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
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.gboFlavor = new System.Windows.Forms.GroupBox();
            this.optStraw = new System.Windows.Forms.RadioButton();
            this.optChoc = new System.Windows.Forms.RadioButton();
            this.gboTopping = new System.Windows.Forms.GroupBox();
            this.lboTopping = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gboSize.SuspendLayout();
            this.gboFlavor.SuspendLayout();
            this.gboTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSize
            // 
            this.gboSize.Controls.Add(this.cboSize);
            this.gboSize.Location = new System.Drawing.Point(11, 11);
            this.gboSize.Margin = new System.Windows.Forms.Padding(2);
            this.gboSize.Name = "gboSize";
            this.gboSize.Padding = new System.Windows.Forms.Padding(2);
            this.gboSize.Size = new System.Drawing.Size(147, 121);
            this.gboSize.TabIndex = 18;
            this.gboSize.TabStop = false;
            this.gboSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.cboSize.Location = new System.Drawing.Point(38, 29);
            this.cboSize.Margin = new System.Windows.Forms.Padding(2);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(62, 24);
            this.cboSize.TabIndex = 0;
            // 
            // gboFlavor
            // 
            this.gboFlavor.Controls.Add(this.optStraw);
            this.gboFlavor.Controls.Add(this.optChoc);
            this.gboFlavor.Location = new System.Drawing.Point(11, 164);
            this.gboFlavor.Margin = new System.Windows.Forms.Padding(2);
            this.gboFlavor.Name = "gboFlavor";
            this.gboFlavor.Padding = new System.Windows.Forms.Padding(2);
            this.gboFlavor.Size = new System.Drawing.Size(147, 93);
            this.gboFlavor.TabIndex = 19;
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
            // gboTopping
            // 
            this.gboTopping.Controls.Add(this.lboTopping);
            this.gboTopping.Location = new System.Drawing.Point(11, 286);
            this.gboTopping.Margin = new System.Windows.Forms.Padding(2);
            this.gboTopping.Name = "gboTopping";
            this.gboTopping.Padding = new System.Windows.Forms.Padding(2);
            this.gboTopping.Size = new System.Drawing.Size(147, 115);
            this.gboTopping.TabIndex = 21;
            this.gboTopping.TabStop = false;
            this.gboTopping.Text = "Topping";
            // 
            // lboTopping
            // 
            this.lboTopping.FormattingEnabled = true;
            this.lboTopping.ItemHeight = 16;
            this.lboTopping.Items.AddRange(new object[] {
            "Chocolate Chips",
            "Nuts",
            "Raisins"});
            this.lboTopping.Location = new System.Drawing.Point(12, 32);
            this.lboTopping.Margin = new System.Windows.Forms.Padding(2);
            this.lboTopping.MultiColumn = true;
            this.lboTopping.Name = "lboTopping";
            this.lboTopping.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboTopping.Size = new System.Drawing.Size(124, 68);
            this.lboTopping.Sorted = true;
            this.lboTopping.TabIndex = 0;
            this.lboTopping.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(16, 421);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(138, 31);
            this.btnOrder.TabIndex = 20;
            this.btnOrder.Text = "GetOrder";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Ex_2_9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 501);
            this.Controls.Add(this.gboSize);
            this.Controls.Add(this.gboFlavor);
            this.Controls.Add(this.gboTopping);
            this.Controls.Add(this.btnOrder);
            this.Name = "Ex_2_9";
            this.Text = "Ex_2_9";
            this.Load += new System.EventHandler(this.Ex_2_9_Load);
            this.gboSize.ResumeLayout(false);
            this.gboFlavor.ResumeLayout(false);
            this.gboFlavor.PerformLayout();
            this.gboTopping.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox gboFlavor;
        private System.Windows.Forms.RadioButton optStraw;
        private System.Windows.Forms.RadioButton optChoc;
        private System.Windows.Forms.GroupBox gboTopping;
        private System.Windows.Forms.ListBox lboTopping;
        private System.Windows.Forms.Button btnOrder;
    }
}