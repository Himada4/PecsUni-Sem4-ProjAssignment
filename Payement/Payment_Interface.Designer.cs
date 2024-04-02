namespace FM91U5.Payement
{
    partial class Payment_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Interface));
            this.Main_Container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Main_Container
            // 
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.Size = new System.Drawing.Size(194, 181);
            this.Main_Container.TabIndex = 0;
            // 
            // Payment_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 181);
            this.Controls.Add(this.Main_Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(210, 220);
            this.MinimumSize = new System.Drawing.Size(210, 220);
            this.Name = "Payment_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment_Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Container;
    }
}