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
        public Main_Interface()
        {
            InitializeComponent();
            worksheetToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = false;
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                    filePath = openFileDialog.FileName;
                }

                Loader<Work> loader = new Loader<Work>();
                works = loader.LoadFile(filePath);
                MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                worksheetToolStripMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("An error occurred, please select a valid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet_Interface worksheet_Interface = new Worksheet_Interface(works);
            worksheet_Interface.WorksheetUpdated += WorksheetUpdatedHandler;
            worksheet_Interface.FormClosed += menuClosed;
            menuStrip.Enabled = false;
            worksheet_Interface.Show();            
        }

        private void WorksheetUpdatedHandler(object sender, List<Work> updatedWorks)
        {
            works = updatedWorks;
            
            worksheetToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = true;
            works_list.Add(works);
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Payment_Interface payment_Interface = new Payment_Interface(works_list);
            payment_Interface.FormClosed += menuClosed;
            menuStrip.Enabled = false;
            payment_Interface.Show();
            works_list.Clear();
            works.Clear();
            paymentToolStripMenuItem.Enabled = false;
            worksheetToolStripMenuItem.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("MMMM dd, yyyy");
            MessageBox.Show($"Current Date: {currentDate}\nNeptun Code: FM91U5", "Project Details");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No) e.Cancel = true;
        }

        private void menuClosed(object sender, EventArgs e)
        {
            menuStrip.Enabled = true;
        }
    }
}
