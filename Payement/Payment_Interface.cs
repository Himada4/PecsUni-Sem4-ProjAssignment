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
            fillStaticFields();
            fillDynamicFields();
        }

        private void fillStaticFields()
        {
            
            Label labelWSC = new Label();
            Label labelWC = new Label();
            Label labelTMC = new Label();
            Label labelTST = new Label();
            Label labelTSC = new Label();
            Label labelT = new Label();

            labelWSC.AutoSize = true;
            labelWSC.Text = "Registered Worksheets:";
            labelWC.Text = "Registered Works:";
            labelTMC.Text = "Total Material Cost:";
            labelTST.Text = "Total Service Cost:";
            labelTSC.AutoSize = true;
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
        void fillDynamicFields()
        {
            /*
             *Numberof registered worksheets
              Numberof registered works
              Material cost
              Service cost
              Total invoiced service time
              Total amount to pay
             */

            Common common = new Common();
            
            Label worksheetCount_Label = new Label();     //
            Label workCount_Label = new Label();          //
            Label totalMaterialCost_Label = new Label();  //
            Label totalServiceCost_Label = new Label();   //
            Label totalInvoiceTime_Label = new Label();
            Label total_Label = new Label();              //

            int workCount = 0;
            int totalMaterialCost = 0;
            int totalInvoiceTime = 0;
            for (int i = 0; i < work_list.Count; i++)
            {
                for (int j = 0; j < work_list[i].Count; j++)
                {
                    workCount++;
                    totalMaterialCost += work_list[i][j].MaterialCosts;
                    totalInvoiceTime += common.RoundUpToMultipleOf30(work_list[i][j].ServiceMinute);
                }

            }
            //Worksheet Count:
            worksheetCount_Label.Text = work_list.Count.ToString();

            //Work Count:
            workCount_Label.Text = workCount.ToString();

            //Total Material Cost:
            totalMaterialCost_Label.Text = totalMaterialCost.ToString();

            //Total Service Cost
            totalServiceCost_Label.Text = common.getServiceFee(totalInvoiceTime).ToString();

            //Total Usage Service Invoice
            totalInvoiceTime_Label.Text = totalInvoiceTime.ToString() + " minutes";

            //Final Total Cost
            total_Label.Text = (totalMaterialCost + common.getServiceFee(totalInvoiceTime)).ToString();// + getFee()).ToString();

            List<Label> labels = new List<Label>() { worksheetCount_Label, workCount_Label, totalMaterialCost_Label, totalServiceCost_Label, totalInvoiceTime_Label, total_Label };

            int Xpos = 160;
            int Ypos = 10;
            foreach (Label label in labels)
            {
                label.Location = new Point(Xpos, Ypos);
                Ypos += 30;
                Main_Container.Controls.Add(label);
            }
        }
    }
}
