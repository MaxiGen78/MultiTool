using System;
using System.IO;
using System.ComponentModel;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = NetOffice.ExcelApi;
using System.Collections.Generic;

namespace MultiTool
{
    delegate void SetTextCallback(string text);
    public partial class mtForm : Form
    {

        Excel.Application xlApp = new Excel.Application();
        Excel.Range range;

        string criteria1 = "At Iron Mountain";
        string criteria2 = "Checked Out From I.M.";
        long rowcountFinal = 0;
        int panel1_pBar = 0;
        int panel2_pBar = 0;
        

        public mtForm()
        {
            InitializeComponent();
        }


        private void bW1_DoWork(object sender, DoWorkEventArgs e)
        {
            xlApp.Visible = false;
            string[] files = e.Argument as string[];
            var num = files.Count();
            numberOfFiles.Text = num.ToString();
            int percent = 0;
            rowcountFinal = 0;
            foreach (string fileEntrie in files)
            {

                    Excel.Workbook wb = xlApp.Workbooks.Open(fileEntrie);
                    Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
                    range = ws.UsedRange;


                //-2146827864


                percent++;
                //checkboxes status check
                if (atIM.Checked && chkdOut.Checked)
                {
                    range.AutoFilter(28, criteria1, Excel.Enums.XlAutoFilterOperator.xlOr, criteria2, true);
                }
                else if (atIM.Checked && !chkdOut.Checked)
                {
                    range.AutoFilter(28, criteria1);
                }
                else if (!atIM.Checked && chkdOut.Checked)
                {
                    range.AutoFilter(28, criteria2);
                }
                //---------------------------------------

                var visrange = range.SpecialCells(Excel.Enums.XlCellType.xlCellTypeVisible, Type.Missing);
                var rowcount = visrange.Count / visrange.Columns.Count;

                if (eHead.Checked)
                {
                    rowcount = rowcount - 1;
                }
                rowcountFinal = rowcountFinal + rowcount;
                string text = rowcountFinal.ToString();
                if (numberOfLines.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(FormUpdate);
                    Invoke(d, new object[] {text});
                }
                else
                {
                    // It's on the same thread, no need for Invoke
                    numberOfLines.Text = text ;
                }


                if (bW1.CancellationPending)
                {
                    e.Cancel = true;
                    wb.Close(false);
                    xlApp.Application.Quit();
                    xlApp.Application.Dispose();
                    break;
                }
                double i = ((double)percent / num)*100;
                int currentPercentage = (int)i;
                bW1.ReportProgress(currentPercentage);
                wb.Close(false);
            }

        }

        private void FormUpdate(string text)
        {
            numberOfLines.Text = text.ToString();
        }
        
        private void bW1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBar.Value = e.ProgressPercentage;
            drawPercentage(pBar.Value);
        }




        private void bW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            b1_1.Enabled = true;
            btnToggle.Enabled = true;
            
            xlApp.Application.Quit();
            xlApp.Application.Dispose();
        }


        private void b1_Click(object sender, EventArgs e)
        {

            DialogResult result = fbd1.ShowDialog();
            if (result == DialogResult.OK)

            {
                var files = Directory.EnumerateFiles(fbd1.SelectedPath, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".csv", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".xls", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase)).ToArray();
                int num = files.Count();
                numberOfFiles.Text = num.ToString();

                bW1.RunWorkerAsync(files);
                b1_1.Enabled = false;
                btnToggle.Enabled = false;
            }
        }

        private void b1_2_Click(object sender, EventArgs e)
        {

        }

        private void oFolder_Click(object sender, EventArgs e)
        {
            
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {

            if (panel1.Visible)
            {
                panel1_pBar = pBar.Value;
                panel1.Visible = false;
                panel2.Visible = true;
                pBar.Value = panel2_pBar;
                drawPercentage(pBar.Value);
                
            }
            else if (panel2.Visible)
            {
                panel2_pBar = pBar.Value;
                panel2.Visible = false;
                panel1.Visible = true;
                pBar.Value = panel1_pBar;
                drawPercentage(pBar.Value);

            }
       
        }

        private void b1_Click_1(object sender, EventArgs e)
        {

        }

        private void b2_2_Click(object sender, EventArgs e)
        {

        }

        private void b1_2_Click_1(object sender, EventArgs e)
        {
            bW1.CancelAsync();
            b1_1.Enabled = true;
        }


        public void drawPercentage(int percent)
        {
            // Percent text in the middle of the progress bar
            percent = (int)(((double)(pBar.Value - pBar.Minimum) / (double)(pBar.Maximum - pBar.Minimum)) * 100);

            //Change text color inside progress bar based on percentage
            var txtColor = (percent <= 50) ? (Color)new ColorConverter().ConvertFrom("Black") : (Color)new ColorConverter().ConvertFrom("White");
            using (var brush = new SolidBrush(txtColor))

            using (Graphics gr = pBar.CreateGraphics())
            {
                if (percent > 0)
                {
                    gr.DrawString(percent.ToString() + "%", SystemFonts.DefaultFont, brush,
                        new PointF(pBar.Width / 2 - (gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont).Width / 2.0F),
                        pBar.Height / 2 - (gr.MeasureString(percent.ToString() + "%", SystemFonts.DefaultFont).Height / 2.0F)));
                }
            }
        }

        private void btn_Criteria_Save_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btn_Criteria_Cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void customChecked(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
        }

    }
}
