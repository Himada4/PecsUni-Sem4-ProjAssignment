using FM91U5.Load_File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM91U5.Worksheet
{
    public partial class Worksheet_Interface : Form
    {
        public event EventHandler<List<Work>> WorksheetUpdated;
        
        private List<Work> works = new List<Work>();
        private bool hasUnsavedChanges = true;

        public Worksheet_Interface(List<Work> works)
        {
            this.works = works;
            InitializeComponent();
            fillForm();
        }

        private void fillForm()
        {
            Main_Container.HorizontalScroll.Maximum = 0;
            Main_Container.VerticalScroll.Visible = false;
            Main_Container.AutoScroll = true;
            Main_Container.AutoScrollPosition = Point.Empty;
            int XposNOW = 10;
            int XposRTIM = 170;
            int XposMC = 280;
            int XposCB = 350;

            //Nameof work; Required time in minutes; Material costs
            Label NOW = new Label();
            Label RTIM = new Label();
            Label MC = new Label();

            NOW.Text = "Name Of Work";
            RTIM.Text = "Required Time In Minutes";
            MC.Text = "Material Costs";

            NOW.Location = new Point(XposNOW, 20);
            RTIM.Location = new Point(XposRTIM, 20);
            MC.Location = new Point(XposMC, 20);

            NOW.Font = new Font(NOW.Font, FontStyle.Bold);
            RTIM.Font = new Font(RTIM.Font, FontStyle.Bold);
            MC.Font = new Font(MC.Font, FontStyle.Bold);

            Main_Container.Controls.Add(NOW);
            Main_Container.Controls.Add(RTIM);
            Main_Container.Controls.Add(MC);

             
            int Ypos = 50;
            int id = 0;

            foreach (Work work in works)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = $"{id++}";
                checkBox.Location = new Point(XposCB, Ypos - 5);
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                Main_Container.Controls.Add(checkBox);

                Label labelNOW = new Label();
                Label labelRTIM = new Label();
                Label labelMC = new Label();

                labelNOW.Text = work.NameOfWork;
                labelRTIM.Text = work.RequiredTimeInMinutes.ToString() + " mins";
                labelMC.Text = work.MaterialCosts.ToString();

                labelNOW.Location = new Point(XposNOW, Ypos);
                labelRTIM.Location = new Point(XposRTIM, Ypos);
                labelMC.Location = new Point(XposMC, Ypos);

                Main_Container.Controls.Add(labelNOW);
                Main_Container.Controls.Add(labelRTIM);
                Main_Container.Controls.Add(labelMC);


                

                Ypos += 100;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;

            if (clickedCheckBox.Checked)
            {
                int previousValueMC = int.Parse(Material_Cost_Display.Text);
                int updatedValueMC = previousValueMC + works[int.Parse(clickedCheckBox.Name)].MaterialCosts;

                int previousValueTC = int.Parse(Time_Cost_Display.Text.Replace(" ", "").Replace("min", ""));
                int updatedValueTC = previousValueTC + works[int.Parse(clickedCheckBox.Name)].RequiredTimeInMinutes;

                Material_Cost_Display.Text = updatedValueMC.ToString();
                Time_Cost_Display.Text = updatedValueTC.ToString() + " min";
            }
            else
            {
                int previousValueMC = int.Parse(Material_Cost_Display.Text);
                int updatedValueMC = previousValueMC - works[int.Parse(clickedCheckBox.Name)].MaterialCosts;

                int previousValueTC = int.Parse(Time_Cost_Display.Text.Replace(" ", "").Replace("min", ""));
                int updatedValueTC = previousValueTC - works[int.Parse(clickedCheckBox.Name)].RequiredTimeInMinutes;

                Material_Cost_Display.Text = updatedValueMC.ToString();
                Time_Cost_Display.Text = updatedValueTC.ToString() + " min";
            }
            
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            List<Work> updatedWorks = new List<Work>();

            foreach (Control control in Main_Container.Controls)
            {
                if (!(control is CheckBox checkBox)) continue;
                
                bool isChecked = checkBox.Checked;
                if (isChecked) updatedWorks.Add(works[int.Parse(checkBox.Name)]);
            }

            hasUnsavedChanges = false;

            WorksheetUpdated?.Invoke(this, updatedWorks);
            this.Close();
        }

        private void Worksheet_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasUnsavedChanges)
            {
                DialogResult response = MessageBox.Show("You have unsaved changes. Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
