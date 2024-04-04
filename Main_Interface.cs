using FM91U5.Load_File;
using FM91U5.Payement;
using FM91U5.Worksheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM91U5
{
    public partial class Main_Interface : Form
    {
        List<Work> works;
        List<List<Work>> works_list = new List<List<Work>>();
        private DateTime startTime;
        public Main_Interface()
        {
            InitializeComponent();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                filePath = openFileDialog.FileName;
            }

            Loader<Work> loader = new Loader<Work>();
            works = loader.LoadFile(filePath);
        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet_Interface worksheet_Interface = new Worksheet_Interface(works);
            worksheet_Interface.WorksheetUpdated += WorksheetUpdatedHandler;
            worksheet_Interface.Show();
        }

        private void WorksheetUpdatedHandler(object sender, List<Work> updatedWorks)
        {
            works = updatedWorks;
            //Disable Worksheet, enable Payement or Load file

            //prevent user from clicking worksheet again, oh wait just disable the worksheet button after "register" just do it

            works_list.Add(works);
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Payment_Interface payment_Interface = new Payment_Interface(works_list);
            payment_Interface.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("MMMM dd, yyyy");
            MessageBox.Show($"Current Date: {currentDate}\nNeptun Code: FM91U5", "Project Details");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes) Application.Exit();
        }
    }
}
