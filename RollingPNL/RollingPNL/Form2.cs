using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace RollingPNL
{
    public partial class Form2 : Form
    {
        Bitmap memoryImage;
        private PrintDocument printChart = new PrintDocument();

        public Form2()
        {
            InitializeComponent();
            //printChart.PrintPage += new PrintPageEventHandler(printChart_PrintPage);
            chart();
        }

 //       void printChart_PrintPage(object sender, PrintPageEventArgs e)
   //     {
     //       throw new NotImplementedException();
       // }

        private void chart()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;
            for (int i = 0; i < RollingPNL.rollingPosPnL.Length; i++)
            {
                chart1.Series["Series1"].Points.AddXY(RollingPNL.dateEndin[i], RollingPNL.rollingSubtotalPnL[i]);
            }

            chart1.Printing.PrintDocument.Print();

            //pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);


            /*
            string test = "";
            for (int i = 0; i < RollingPNL.rollingPosPnL.Length; i++)
            {
                test += RollingPNL.rollingPosPnL[i].ToString() + "\n";
            }
            MessageBox.Show(test);
             * */

        }

        private void captureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printChart_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //captureScreen();
            //printChart.Print();
            chart1.Printing.PrintDocument.Print();
        }


    }

}
