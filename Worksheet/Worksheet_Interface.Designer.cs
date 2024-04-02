namespace FM91U5.Worksheet
{
    partial class Worksheet_Interface
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
            this.Register_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_Container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Time_Cost_Display = new System.Windows.Forms.Label();
            this.Material_Cost_Display = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Register_Btn
            // 
            this.Register_Btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Register_Btn.Location = new System.Drawing.Point(0, 67);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(484, 36);
            this.Register_Btn.TabIndex = 0;
            this.Register_Btn.Text = "Register";
            this.Register_Btn.UseVisualStyleBackColor = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Time_Cost_Display);
            this.panel1.Controls.Add(this.Material_Cost_Display);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Register_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 103);
            this.panel1.TabIndex = 1;
            // 
            // Main_Container
            // 
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.Size = new System.Drawing.Size(484, 458);
            this.Main_Container.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(15, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 2);
            this.panel4.TabIndex = 10;
            // 
            // Time_Cost_Display
            // 
            this.Time_Cost_Display.AutoSize = true;
            this.Time_Cost_Display.Location = new System.Drawing.Point(272, 41);
            this.Time_Cost_Display.Name = "Time_Cost_Display";
            this.Time_Cost_Display.Size = new System.Drawing.Size(32, 13);
            this.Time_Cost_Display.TabIndex = 9;
            this.Time_Cost_Display.Text = "0 min";
            // 
            // Material_Cost_Display
            // 
            this.Material_Cost_Display.AutoSize = true;
            this.Material_Cost_Display.Location = new System.Drawing.Point(272, 17);
            this.Material_Cost_Display.Name = "Material_Cost_Display";
            this.Material_Cost_Display.Size = new System.Drawing.Size(13, 13);
            this.Material_Cost_Display.TabIndex = 8;
            this.Material_Cost_Display.Text = "0";
            this.Material_Cost_Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Costs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Material Cost:";
            // 
            // Worksheet_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.Main_Container);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Worksheet_Interface";
            this.Text = "Worksheet_Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Worksheet_Interface_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Main_Container;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Time_Cost_Display;
        private System.Windows.Forms.Label Material_Cost_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}