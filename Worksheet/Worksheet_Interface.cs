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
            fillHeader();
            fillItems();
        }

        private void fillItems()
        {
            Main_Container.ColumnCount = 5;
            Main_Container.RowCount = works.Count;
            
            Main_Container.ColumnStyles.Clear();
            for (int i = 0; i < Main_Container.ColumnCount; i++)
            {
                Main_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / Main_Container.ColumnCount));
            }
            int currentRow = 0;
            int id = 0;
            Main_Container.RowStyles.Clear();
            foreach (var work in works)
            {
                
                Main_Container.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F)); 
                

                
                Main_Container.Controls.Add(new Label() { Text = work.NameOfWork, Anchor = AnchorStyles.Left }, 0, currentRow);
                Main_Container.Controls.Add(new Label() { Text = $"{work.MaterialCosts}", Anchor = AnchorStyles.Left }, 1, currentRow);
                Main_Container.Controls.Add(new Label() { Text = $"{work.ServiceHour} Hours {work.ServiceMinute} Min", Anchor = AnchorStyles.Left}, 2, currentRow);

                
                double ratio = (double)work.RequiredTimeInMinutes / 60;
                int serviceFee = (int)(ratio * 15000);
                Main_Container.Controls.Add(new Label() { Text = "0", Name = $"{id}_l",Anchor = AnchorStyles.Left , TextAlign = ContentAlignment.MiddleCenter}, 4, currentRow);

               
                CheckBox selectCheckBox = new CheckBox();
                selectCheckBox.Name = $"{id++}";
                selectCheckBox.Padding = new Padding(36, 0, 0, 0);
                selectCheckBox.CheckedChanged += CheckBox_CheckedChanged;
                Main_Container.Controls.Add(selectCheckBox, 3, currentRow);

                currentRow++;
            }

            
        }

        private void fillHeader()
        {
            Header_Container.ColumnCount = 5;
            Header_Container.ColumnStyles.Clear();
            for (int i = 0; i < Header_Container.ColumnCount - 1; i++)
            {
                Header_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            }
            int scrollBarWidth = SystemInformation.VerticalScrollBarWidth;
            float lastColumnWidth = 25f + (works.Count > 14 ? (100f * scrollBarWidth / Header_Container.Width) : 0);
            Header_Container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, lastColumnWidth));


            
            Header_Container.Controls.Add(new Label() { Text = "Name Of Work", Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
            Header_Container.Controls.Add(new Label() { Text = "Material Cost", Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
            Header_Container.Controls.Add(new Label() { Text = "Time", Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleCenter }, 2, 0);
            Header_Container.Controls.Add(new Label() { Text = "Select", Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleCenter }, 3, 0);
            Header_Container.Controls.Add(new Label() { Text = "Service Fee", Anchor = AnchorStyles.Left , TextAlign = ContentAlignment.MiddleCenter }, 4, 0);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = (CheckBox)sender;
            Common common = new Common();

            if (clickedCheckBox.Checked)
            {
                int previousValueMC = int.Parse(Material_Cost_Display.Text);
                int updatedValueMC = previousValueMC + works[int.Parse(clickedCheckBox.Name)].MaterialCosts;

                int previousValueSC = int.Parse(Invoiced_Service_Cost_Display.Text);
                int updatedValueSC = previousValueSC + common.getServiceFee(common.RoundUpToMultipleOf30(works[int.Parse(clickedCheckBox.Name)].RequiredTimeInMinutes));

                foreach (Control control in Main_Container.Controls)
                {
                    if (control is Label label && label.Name == $"{clickedCheckBox.Name}_l")
                    {
                        label.Text = common.getServiceFee(works[int.Parse(clickedCheckBox.Name)].RequiredTimeInMinutes).ToString();
                    }
                }

                Material_Cost_Display.Text = updatedValueMC.ToString();
                Invoiced_Service_Cost_Display.Text = updatedValueSC.ToString();
            }
            else
            {
                int previousValueMC = int.Parse(Material_Cost_Display.Text);
                int updatedValueMC = previousValueMC - works[int.Parse(clickedCheckBox.Name)].MaterialCosts;

                int previousValueSC = int.Parse(Invoiced_Service_Cost_Display.Text);
                int updatedValueSC = previousValueSC - common.getServiceFee(common.RoundUpToMultipleOf30(works[int.Parse(clickedCheckBox.Name)].RequiredTimeInMinutes));

                foreach (Control control in Main_Container.Controls)
                {
                    if (control is Label label && label.Name == $"{clickedCheckBox.Name}_l")
                    {
                        label.Text = "0";
                    }
                }

                Material_Cost_Display.Text = updatedValueMC.ToString();
                Invoiced_Service_Cost_Display.Text = updatedValueSC.ToString();
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
                DialogResult response = MessageBox.Show("You have unsaved changes. Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
