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
            this.LayoutUse3 = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Panel();
            this.Invoiced_Service_Cost_Display = new System.Windows.Forms.Label();
            this.Material_Cost_Display = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Main_Container = new System.Windows.Forms.TableLayoutPanel();
            this.Container_Parent = new System.Windows.Forms.Panel();
            this.Header_Container = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutUse2 = new System.Windows.Forms.Panel();
            this.LayoutUse1 = new System.Windows.Forms.Panel();
            this.LayoutUse3.SuspendLayout();
            this.Container_Parent.SuspendLayout();
            this.LayoutUse2.SuspendLayout();
            this.LayoutUse1.SuspendLayout();
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
            // LayoutUse3
            // 
            this.LayoutUse3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LayoutUse3.Controls.Add(this.Line);
            this.LayoutUse3.Controls.Add(this.Invoiced_Service_Cost_Display);
            this.LayoutUse3.Controls.Add(this.Material_Cost_Display);
            this.LayoutUse3.Controls.Add(this.label2);
            this.LayoutUse3.Controls.Add(this.label1);
            this.LayoutUse3.Controls.Add(this.Register_Btn);
            this.LayoutUse3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutUse3.Location = new System.Drawing.Point(0, 458);
            this.LayoutUse3.Name = "LayoutUse3";
            this.LayoutUse3.Size = new System.Drawing.Size(484, 103);
            this.LayoutUse3.TabIndex = 1;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Line.Location = new System.Drawing.Point(15, 35);
            this.Line.Margin = new System.Windows.Forms.Padding(0);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(455, 2);
            this.Line.TabIndex = 10;
            // 
            // Invoiced_Service_Cost_Display
            // 
            this.Invoiced_Service_Cost_Display.AutoSize = true;
            this.Invoiced_Service_Cost_Display.Location = new System.Drawing.Point(272, 41);
            this.Invoiced_Service_Cost_Display.Name = "Invoiced_Service_Cost_Display";
            this.Invoiced_Service_Cost_Display.Size = new System.Drawing.Size(13, 13);
            this.Invoiced_Service_Cost_Display.TabIndex = 9;
            this.Invoiced_Service_Cost_Display.Text = "0";
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
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Invoiced Time Cost:";
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
            // Main_Container
            // 
            this.Main_Container.AutoSize = true;
            this.Main_Container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Main_Container.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Main_Container.ColumnCount = 5;
            this.Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Main_Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.Main_Container.Location = new System.Drawing.Point(0, 0);
            this.Main_Container.Name = "Main_Container";
            this.Main_Container.RowCount = 2;
            this.Main_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.32323F));
            this.Main_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.67677F));
            this.Main_Container.Size = new System.Drawing.Size(484, 4);
            this.Main_Container.TabIndex = 2;
            // 
            // Container_Parent
            // 
            this.Container_Parent.AutoScroll = true;
            this.Container_Parent.Controls.Add(this.Main_Container);
            this.Container_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Parent.Location = new System.Drawing.Point(0, 0);
            this.Container_Parent.Name = "Container_Parent";
            this.Container_Parent.Size = new System.Drawing.Size(484, 456);
            this.Container_Parent.TabIndex = 3;
            // 
            // Header_Container
            // 
            this.Header_Container.AutoSize = true;
            this.Header_Container.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Header_Container.ColumnCount = 5;
            this.Header_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.95798F));
            this.Header_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.04202F));
            this.Header_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.Header_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.Header_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.Header_Container.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Container.Location = new System.Drawing.Point(0, 0);
            this.Header_Container.Name = "Header_Container";
            this.Header_Container.RowCount = 1;
            this.Header_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Header_Container.Size = new System.Drawing.Size(484, 2);
            this.Header_Container.TabIndex = 4;
            // 
            // LayoutUse2
            // 
            this.LayoutUse2.AutoSize = true;
            this.LayoutUse2.Controls.Add(this.Header_Container);
            this.LayoutUse2.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutUse2.Location = new System.Drawing.Point(0, 0);
            this.LayoutUse2.Name = "LayoutUse2";
            this.LayoutUse2.Size = new System.Drawing.Size(484, 2);
            this.LayoutUse2.TabIndex = 5;
            // 
            // LayoutUse1
            // 
            this.LayoutUse1.Controls.Add(this.Container_Parent);
            this.LayoutUse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutUse1.Location = new System.Drawing.Point(0, 2);
            this.LayoutUse1.Name = "LayoutUse1";
            this.LayoutUse1.Size = new System.Drawing.Size(484, 456);
            this.LayoutUse1.TabIndex = 6;
            // 
            // Worksheet_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.LayoutUse1);
            this.Controls.Add(this.LayoutUse2);
            this.Controls.Add(this.LayoutUse3);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Worksheet_Interface";
            this.Text = "Worksheet_Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Worksheet_Interface_FormClosing);
            this.LayoutUse3.ResumeLayout(false);
            this.LayoutUse3.PerformLayout();
            this.Container_Parent.ResumeLayout(false);
            this.Container_Parent.PerformLayout();
            this.LayoutUse2.ResumeLayout(false);
            this.LayoutUse2.PerformLayout();
            this.LayoutUse1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.Panel LayoutUse3;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Label Invoiced_Service_Cost_Display;
        private System.Windows.Forms.Label Material_Cost_Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel Main_Container;
        private System.Windows.Forms.Panel Container_Parent;
        private System.Windows.Forms.TableLayoutPanel Header_Container;
        private System.Windows.Forms.Panel LayoutUse2;
        private System.Windows.Forms.Panel LayoutUse1;
    }
}