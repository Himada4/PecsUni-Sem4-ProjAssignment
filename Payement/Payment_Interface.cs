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

namespace FM91U5.Payement
{
    public partial class Payment_Interface : Form
    {
        List<List<Work>> work_list;
        
        public Payment_Interface(List<List<Work>> work_list)
        {
            this.work_list = work_list;
            
            InitializeComponent();
            
            FillForm();
        }

        private void FillForm()
        {
            /*
             * Worksheet Count:
             * Work Count:
             * 
             * Total Material Cost:
             * Service Cost:
             * Invoiced Service Time:
             * Total:
             * 
             *  
             *
             * 
             */

            

            //dynamic
            Label worksheetCount = new Label();     //
            Label workCount = new Label();          //
            Label totalMaterialCost = new Label();  //
            Label totalServiceCost = new Label();   //
            Label usageInvoice = new Label();
            Label total = new Label();              //


           

            int workAmt = 0;
            int materialCost = 0;
            int serviceTime = 0;
            int serviceCost = 0;
            for (int i = 0; i < work_list.Count; i++)
            {
                for (int j = 0; j < work_list[i].Count; j++) 
                {
                    workAmt++;
                    materialCost += work_list[i][j].MaterialCosts;
                    //serviceTime += work_list[i][j].ServiceMinute;
                }
                
            }
            //Worksheet Count:
            worksheetCount.Text = work_list.Count.ToString();

            //Work Count:
            workCount.Text = workAmt.ToString();

            //Total Material Cost:
            totalMaterialCost.Text = materialCost.ToString();
            
            //Total Service Cost
            totalServiceCost.Text = serviceTime.ToString();

            //Total Usage Service Invoice
            usageInvoice.Text = "s";//getFee().ToString();

            //Final Total Cost
            total.Text = (materialCost + serviceCost).ToString();// + getFee()).ToString();

            List<Label> labels = new List<Label>() { worksheetCount, workCount, totalMaterialCost, totalServiceCost, usageInvoice, total};

            int Xpos = 160;
            int Ypos = 10;
            foreach (Label label in labels)
            {
                label.Location = new Point(Xpos, Ypos);
                Ypos += 30;
                Main_Container.Controls.Add(label);
            }
        }

        private void setStaticLabels()
        {
            //static
            Label labelWSC = new Label();
            Label labelWC = new Label();
            Label labelTMC = new Label();
            Label labelTST = new Label();
            Label labelTSC = new Label();
            Label labelT = new Label();

            labelWSC.Text = "Registered Worksheets:";
            labelWC.Text = "Registered Works:";
            labelTMC.Text = "Total Material Cost:";
            labelTST.Text = "Total Service Cost:";
            labelTSC.Text = "Invoiced Service Time:";
            labelT.Text = "Total:";

            List<Label> staticLables = new List<Label>() { labelWSC, labelWC, labelTMC, labelTST, labelTSC, labelT };

            int Xpos = 10;
            int Ypos = 10;
            foreach (Label label in staticLables)
            {
                label.Location = new Point(Xpos, Ypos);
                Ypos += 30;
                Main_Container.Controls.Add(label);
            }

        }
    }
}
