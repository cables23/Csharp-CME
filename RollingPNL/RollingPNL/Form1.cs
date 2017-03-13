using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RollingPNL
{
    public partial class RollingPNL : Form
    {
        public static DataSet ds;
        public static DataSet fs;
        public static DataTable dt;
        public static DataTable ft;
        public static double[] rollingPosPnL;
        public static double[] rollingOptionsPnL;
        public static int[] rollingDayTradeFutures;
        public static string[] dateEndin;
        public static double[] rollingSubtotalPnL;
        bool outputRun = false;
        const string ROUNDEDDELTA = "Rounded Delta";
        const string POSITION = "Position";
        const string DAYTRADEFUTS = "Day Trade Futures";
        const string FUTURESSETS = "Futures Settles";
        const string POSPNL = "Position P&L";
        const string SUBTOT = "Position Subtotal";
        const string CHANGEINOPTION = "Change in Option Settle";
        const string DAILY100CP = "Daily P&L / 100 Options";
        const string SUBTOT100CP = "Subtotal / 100 Options";
        const string DAILYSUBTOT = "Daily Position & Option P&L";
        const string DAILYTOT = "Daily Total";

        public RollingPNL()
        {
            InitializeComponent();
            rdBtnCall.Checked = false;
            rdBtnPut.Checked = false;
            getAllMonths();
        }

        private int getNumericalMonth(string month)
        {
            if (month == "F")
                return 1;
            else if (month == "G")
                return 2;
            else if (month == "H")
                return 3;
            else if (month == "J")
                return 4;
            else if (month == "K")
                return 5;
            else if (month == "M")
                return 6;
            else if (month == "N")
                return 7;
            else if (month == "Q")
                return 8;
            else if (month == "U")
                return 9;
            else if (month == "V")
                return 10;
            else if (month == "X")
                return 11;
            else if (month == "Z")
                return 12;
            return 0;
        }

        private string getCharMonth(int month)
        {
            if (month == 1)
                return "F";
            else if (month == 2)
                return "G";
            else if (month == 3)
                return "H";
            else if (month == 4)
                return "J";
            else if (month == 5)
                return "K";
            else if (month == 6)
                return "M";
            else if (month == 7)
                return "N";
            else if (month == 8)
                return "Q";
            else if (month == 9)
                return "U";
            else if (month == 10)
                return "V";
            else if (month == 11)
                return "X";
            else if (month == 12)
                return "Z";
            return "";
        }

        private int getYear(string year)
        {
            int yr = 1;
            int.TryParse(year, out yr);
            if (yr < 80) //year will be in the 2000's
                return 2000 + yr;
            else
                return 1900 + yr;
        }

        private DataSet runSQLQuery(string selectStmt, string prodCode, string strike, string month, string year, string c_p, string dateRange, string tableName)
        {
            string connection_string = "server=localhost;database=data;uid=root;password=nyco777";
            MySqlConnection connection = new MySqlConnection(connection_string);
            string query = selectStmt + " FROM cme_data WHERE " + prodCode + strike
            + month + year + c_p + dateRange;
            //MessageBox.Show(query);
            MySqlDataAdapter mda = new MySqlDataAdapter();
            mda.SelectCommand = new MySqlCommand(query, connection);
            mda.SelectCommand.CommandTimeout = 100000;
            ds = new DataSet();
            mda.Fill(ds, tableName);
            return ds;
        }

        private void getAllMonths()
        {
            ds = new DataSet();
            dt = new DataTable();
            string select = "SELECT DISTINCT productCode, CYear, DMonth";
            string dateRange = " ORDER BY CYear, DMonth, productCode";
            string prodCode = "productCode = 'E0' OR productCode = 'E2' OR productCode = 'E3' OR productCode = 'E4' OR productCode = 'E5'";
            string mth = "";
            string yr = "";
            string strike = "";
            string c_p = "";
            string prod = "";
            ds = runSQLQuery(select, prodCode, strike, mth, yr, c_p, dateRange, "productCode");

            dt = ds.Tables["productCode"];
            foreach (DataRow dr in dt.Rows)
            {
                string year = dr[1].ToString().Substring(2, 2);

                int month = 0;
                int.TryParse(dr[2].ToString(), out month);
                mth = getCharMonth(month);
                prod = dr[0].ToString() + mth + year;
                comBoxMonth.Items.Add(prod);

                //    MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
            }
        }

        private void getStrikes()
        {
            DataSet ds = new DataSet();
            string selectStmt = "SELECT DISTINCT strikePrice";
            string dateRange = " ORDER BY strikePrice";
            string prodCode = "productCode='" + comBoxMonth.SelectedItem.ToString().Substring(0, 2) + "'";
            string month_S = comBoxMonth.SelectedItem.ToString().Substring(2, 1);
            int month = getNumericalMonth(month_S);
            string mth = " AND DMonth='" + month.ToString() + "'";
            string year_S = comBoxMonth.SelectedItem.ToString().Substring(3, 2);
            int year = getYear(year_S);
            string yr = " AND CYear='" + year.ToString() + "'";
            string strike = "";
            string c_p = " AND CPF='P'";
            bool call = rdBtnCall.Checked;
            if (call)
                c_p = " AND CPF='C'";
            // get the date range for this month/strike
            ds = runSQLQuery(selectStmt, prodCode, strike, mth, yr, c_p, dateRange, "strikePrice");

            DataView dv = new DataView(ds.Tables["strikePrice"]);

            comBoxStrike.DisplayMember = "strikePrice";
            comBoxStrike.ValueMember = "strikePrice";
            comBoxStrike.DataSource = dv;

            //MessageBox.Show(comBoxStartDate.SelectedValue.ToString());
        }

        private void dateRangeSelected()
        {
            ds = new DataSet();
            string selectStmt = "SELECT DISTINCT tradeDay";
            string dateRange = "";
            string prodCode = "productCode='" + comBoxMonth.SelectedItem.ToString().Substring(0, 2) + "'";
            string month_S = comBoxMonth.SelectedItem.ToString().Substring(2, 1);
            int month = getNumericalMonth(month_S);
            string mth = " AND DMonth='" + month.ToString() + "'";
            string year_S = comBoxMonth.SelectedItem.ToString().Substring(3, 2);
            int year = getYear(year_S);
            string yr = " AND CYear='" + year.ToString() + "'";
            string strike = " AND strikePrice ='";
            strike += comBoxStrike.SelectedValue.ToString();
            strike += "'";
            string c_p = " AND CPF='P'";
            bool call = rdBtnCall.Checked;
            if (call)
                c_p = " AND CPF='C'";
            // get the date range for this month/strike
            ds = runSQLQuery(selectStmt, prodCode, strike, mth, yr, c_p, dateRange, "tradeDay");

            DataView dvStart = new DataView(ds.Tables["tradeDay"]);
            DataView dvEnd = new DataView(ds.Tables["tradeDay"]);

            comBoxStartDate.DisplayMember = "tradeDay";
            comBoxStartDate.ValueMember = "tradeDay";
            comBoxStartDate.DataSource = dvStart;
            comBoxEndDate.DisplayMember = "tradeDay";
            comBoxEndDate.ValueMember = "tradeDay";
            comBoxEndDate.DataSource = dvEnd;
            comBoxEndDate.SelectedIndex = ds.Tables["tradeDay"].Rows.Count - 1;

            //MessageBox.Show(comBoxStartDate.SelectedValue.ToString());
        }

        private void comBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdBtnCall.Checked = false;
            rdBtnPut.Checked = false;
            getStrikes();
        }

        private void rdBtnCall_CheckedChanged(object sender, EventArgs e)
        {
            dateRangeSelected();
        }

        private void rdBtnPut_CheckedChanged(object sender, EventArgs e)
        {
            dateRangeSelected();
        }

        private void comBoxStartDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxEndDate.SelectedValue != null)
            {
                string sDate = comBoxStartDate.SelectedValue.ToString();
                int start = Convert.ToInt32(sDate);
                string eDate = comBoxEndDate.SelectedValue.ToString();
                int end = Convert.ToInt32(eDate);
                if (start > end)
                {
                    MessageBox.Show("Start date must be before end date", "Input error");
                    return;
                }
                else
                {
                    int counter = 0;
                    for (int i = comBoxStartDate.SelectedIndex; i <= comBoxEndDate.SelectedIndex; i++) // count date range
                    {
                        counter++;
                    }
                    lblNumDays.Text = counter.ToString();
                    lblDaysUsing.Text = lblNumDays.Text;
                    int outputs = Convert.ToInt32(lblDaysUsing.Text) - Convert.ToInt32(txtRolling.Text) + 1;
                    lblOutputs.Text = outputs.ToString();
                }
            }
        }

        private void comBoxEndDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sDate = comBoxStartDate.SelectedValue.ToString();
            int start = Convert.ToInt32(sDate);
            string eDate = comBoxEndDate.SelectedValue.ToString();
            int end = Convert.ToInt32(eDate);
            if (start > end)
            {
                MessageBox.Show("Start date must be before end date", "Input error");
                return;
            }
            else
            {
                int counter = 0;
                for (int i = comBoxStartDate.SelectedIndex; i <= comBoxEndDate.SelectedIndex; i++) // count date range
                {
                    counter++;
                }
                lblNumDays.Text = counter.ToString();
                lblDaysUsing.Text = lblNumDays.Text;
                int outputs = Convert.ToInt32(lblDaysUsing.Text) - Convert.ToInt32(txtRolling.Text) + 1;
                lblOutputs.Text = outputs.ToString();
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (!rdBtnCall.Checked && !rdBtnPut.Checked)
            {
                MessageBox.Show("Please select the month, strike, call or put, and date range.", "Error");
                return;
            }
            int rollingPeriod = Convert.ToInt32(txtRolling.Text);
            int numDays = Convert.ToInt32(lblNumDays.Text);
            if (numDays < rollingPeriod)
            {
                MessageBox.Show("Too big of a rolling period, must be " + lblNumDays.Text + " or less.", "Error");
                return;
            }
            string selectStmt = "SELECT tradeDay, settle, delta, IV";
            ds = new DataSet();
            dt = new DataTable();
            string prodCode = "productCode='" + comBoxMonth.SelectedItem.ToString().Substring(0, 2) + "'";
            string month_S = comBoxMonth.SelectedItem.ToString().Substring(2, 1);
            int month = getNumericalMonth(month_S);
            string mth = " AND DMonth='" + month.ToString() + "'";
            string year_S = comBoxMonth.SelectedItem.ToString().Substring(3, 2);
            int year = getYear(year_S);
            string yr = " AND CYear='" + year.ToString() + "'";
            string strike = " AND strikePrice ='";
            strike += comBoxStrike.SelectedValue.ToString();
            strike += "'";
            //MessageBox.Show(str.ToString());
            //str = str * 100;

            string c_p = " AND CPF='P'";
            bool call = rdBtnCall.Checked;
            if (call)
                c_p = " AND CPF='C'";

            string dateRange = "";
            string sDate = comBoxStartDate.SelectedValue.ToString();
            int start = Convert.ToInt32(sDate);
            string eDate = comBoxEndDate.SelectedValue.ToString();
            int end = Convert.ToInt32(eDate);
            if (start > end)
            {
                MessageBox.Show("Start date must be before end date", "Input error");
                return;
            }
            else
            {
                dateRange = " AND tradeDay >='" + start.ToString() + "' AND tradeDay <='" + end.ToString() + "'" + " GROUP BY tradeDay, settle, delta";
            }

            ds = runSQLQuery(selectStmt, prodCode, strike, mth, yr, c_p, dateRange, "tradeDay");
            dt = ds.Tables["tradeDay"];
            dt.Columns.Add(ROUNDEDDELTA, typeof(Double));
            dt.Columns.Add(POSITION, typeof(int));
            dt.Columns.Add(DAYTRADEFUTS, typeof(int));
            dt.Columns.Add(FUTURESSETS, typeof(double));
            dt.Columns.Add(POSPNL, typeof(double));
            dt.Columns.Add(SUBTOT, typeof(double));
            dt.Columns.Add(CHANGEINOPTION, typeof(double));
            dt.Columns.Add(DAILY100CP, typeof(double));
            dt.Columns.Add(SUBTOT100CP, typeof(double));
            dt.Columns.Add(DAILYSUBTOT, typeof(double));
            dt.Columns.Add(DAILYTOT, typeof(double));
            fs = new DataSet();
            ft = new DataTable();
            selectStmt = "SELECT settle";
            prodCode = "productCode='ED'";
            strike = "";
            int quarterlyMonth = getQuarterlyMonth(month);
            mth = " AND DMonth='" + quarterlyMonth.ToString() + "'";
            int midFuts = getMidcurveFuturesCorrectYear(comBoxMonth.SelectedItem.ToString().Substring(0, 2));
            year += midFuts;
            yr = " AND CYear='" + year.ToString() + "'";
            c_p = "";
            dateRange = " AND tradeDay >='" + start.ToString() + "' AND tradeDay <='" + end.ToString() + "'" + " GROUP BY tradeDay, settle";

            fs = runSQLQuery(selectStmt, prodCode, strike, mth, yr, c_p, dateRange, "settle");
            ft = fs.Tables["settle"];

            outputRun = true;
            formatGrid(dt, ft);
        }

        private int getMidcurveFuturesCorrectYear(string prodCode)
        {
            switch (prodCode)
            {
                case "E0":
                    return 1;
                case "E2":
                    return 2;
                case "E3":
                    return 3;
                case "E4":
                    return 4;
                case "E5":
                    return 5;
            }
            return 0;
        }

        private int getQuarterlyMonth(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    return 3;
                case 4:
                case 5:
                case 6:
                    return 6;
                case 7:
                case 8:
                case 9:
                    return 9;
                case 10:
                case 11:
                case 12:
                    return 12;
            }
            return 0;
        }

        private void formatGrid(DataTable dt, DataTable ft)
        {
            //int counter = 0;
            double delta = 0;
           // foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            string[] futuresSettles = new string[ft.Rows.Count];
            //int counter = 0;
            //string test = "";
            for (int i = 0; i < ft.Rows.Count; i++) //(DataRow dtr in ft.Rows)
            {
                DataRow dtr = ft.Rows[i];
                futuresSettles[i] = dtr["settle"].ToString();
                //test = dtr["settle"].ToString();
                //counter++;
           } 
            int previousDayTrade = 0;
            int previousDelta = 0;
            double settle = 0;
            double pnl = 0;
            double subtotal = 0;
            double optionsPnL = 0;
            double optionsSubtotal = 0;
            double previousSettle = 0;
            double changeInPrice = 0;
            double slippage = 0;
            double dailySubtotal = 0;
            double dailyTotal = 0;
            int pos = 0;
            //counter = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                //DataRow dr = ((DataRowView)dgvr.DataBoundItem).Row;
                //DataRow dr = dt.Rows[counter];
                
                delta = Convert.ToDouble(dr["delta"]);
                delta = Math.Round(delta, 2) * 100;
                bool call = rdBtnCall.Checked;
                if (call)
                    delta = delta * -1;
                int deltaInt = Convert.ToInt32(delta);
              //  dataGridView1.Rows[counter].cells
                dr[ROUNDEDDELTA] = deltaInt;
                if (i == 0)
                {
                    dr[POSITION] = 0;
                    dr[DAYTRADEFUTS] = deltaInt;
                    previousDayTrade = deltaInt;
                    slippage = Math.Abs(previousDayTrade);
                    previousSettle = Convert.ToDouble(dr["settle"]);
                    dr[POSPNL] = 0;
                    dr[SUBTOT] = 0;
                    dr[CHANGEINOPTION] = 0;
                    dr[DAILY100CP] = 0;
                    dr[SUBTOT100CP] = 0;
                    dr[DAILYSUBTOT] = 0;
                    dr[DAILYTOT] = 0;
                }
                else
                {
                    // position pnl
                    pos += previousDayTrade;
                    dr[POSITION] = pos;
                    pnl = Math.Round(pos * (Convert.ToDouble(futuresSettles[i]) - Convert.ToDouble(futuresSettles[i - 1])) * 100 * 25, 2);
                    dr[POSPNL] = pnl;
                    subtotal += pnl;
                    dr[SUBTOT] = subtotal;
                    previousDayTrade = deltaInt - previousDelta;
                    slippage += Math.Abs(previousDayTrade);
                    dr[DAYTRADEFUTS] = previousDayTrade;
                    // options pnl
                    settle = Convert.ToDouble(dr["settle"]);
                    changeInPrice = Math.Round((settle - previousSettle) * 100, 2);
                    dr[CHANGEINOPTION] = changeInPrice;
                    previousSettle = settle;
                    optionsPnL = changeInPrice * 100 * 25;
                    Math.Round(optionsPnL, 2);
                    dr[DAILY100CP] = optionsPnL;
                    optionsSubtotal += optionsPnL;
                    dr[SUBTOT100CP] = optionsSubtotal;
                    dailySubtotal = pnl + optionsPnL;
                    dr[DAILYSUBTOT] = dailySubtotal;
                    dailyTotal += dailySubtotal;
                    dr[DAILYTOT] = dailyTotal;


                    
                }
                previousDelta = deltaInt;
                dr[FUTURESSETS] = futuresSettles[i];
                //counter++;
            }
            lblFuturesPnL.Text = subtotal.ToString();
            lblOptionsPnL.Text = optionsSubtotal.ToString();
            subtotal += optionsSubtotal;
            lblSubtotal.Text = subtotal.ToString();
            slippage = slippage * .5 * 25 * -1;
            lblSlippage.Text = slippage.ToString();
            subtotal += slippage;
            lblTotal.Text = subtotal.ToString();
            subtotal = Math.Round(subtotal / (25 * 100), 2);
            lblPriceDiff.Text = subtotal.ToString();
            dataGridView1.DataSource = dt;
            rollingPnLGrid();
        }

        private void rollingPnLGrid()
        {
            if (!outputRun)
            {
                MessageBox.Show("Please run the Output first, no data has been pulled.", "Error");
                return;
            }
            int rollingPeriod = Convert.ToInt32(txtRolling.Text);
            dataGridViewRolling.Rows.Clear();
            if (dt.Rows.Count < rollingPeriod)
            {
                MessageBox.Show("Too big of a rolling period, must be " + lblNumDays.Text + " or less.", "Error");
                return;
            }
            int numRollingPeriods = dt.Rows.Count - rollingPeriod + 1;
            double subtotal = 0;
            double slippage = 0;
            double priceDiff = 0;

            rollingPosPnL = new double[numRollingPeriods];
            rollingOptionsPnL = new double[numRollingPeriods];
            rollingDayTradeFutures = new int[numRollingPeriods];
            dateEndin = new string[numRollingPeriods];
            rollingSubtotalPnL = new double[numRollingPeriods];

            for (int i = 0; i < numRollingPeriods; i++) // initialize matrix to 0
            {
                rollingPosPnL[i] = 0;
                rollingOptionsPnL[i] = 0;
                rollingDayTradeFutures[i] = 0;
                rollingSubtotalPnL[i] = 0;
            }

            for (int i = 0; i < numRollingPeriods; i++) // How many rolling 20 day periods are there in the dataset?
            {
                for (int j = 0; j < rollingPeriod; j++) // Sum the day's subtotal's together into the correct spot in the matrix
                { 
                    DataRow dr = dt.Rows[i + j];
                    rollingPosPnL[i] += Convert.ToDouble(dr[POSPNL]);
                    rollingOptionsPnL[i] += Convert.ToDouble(dr[DAILY100CP]);
                    rollingDayTradeFutures[i] += Math.Abs(Convert.ToInt32(dr[DAYTRADEFUTS])); // futures count for slippage
                    if (j == rollingPeriod - 1)
                        dateEndin[i] = dr["tradeDay"].ToString();
                    // MessageBox.Show(rollingPosPnL[i].ToString() + " " + rollingOptionsPnL[i].ToString() + " " + rollingDayTradeFutures[i].ToString());
                }
                //MessageBox.Show(rollingPosPnL[i].ToString() + " " + rollingOptionsPnL[i].ToString() + " " + rollingDayTradeFutures[i].ToString());
            }

            string[] test = new string[7];
            for (int i = 0; i < numRollingPeriods; i++) // initialize matrix to 0
            {
                test[0] = dateEndin[i];
                test[1] = rollingPosPnL[i].ToString();
                test[2] = rollingOptionsPnL[i].ToString();
                test[3] = rollingDayTradeFutures[i].ToString();
                slippage = rollingDayTradeFutures[i] * .5 * 25 * -1;
                test[4] = slippage.ToString();
                subtotal = rollingPosPnL[i] + rollingOptionsPnL[i] + slippage;
                rollingSubtotalPnL[i] = subtotal;
                test[5] = subtotal.ToString();
                priceDiff = Math.Round(subtotal / (25 * 100), 2);
                test[6] = priceDiff.ToString();
                dataGridViewRolling.Rows.Add(test);
            }
        }

        private void btnRollingPnL_Click(object sender, EventArgs e)
        {
            rollingPnLGrid();
        }

        private void txtRolling_TextChanged(object sender, EventArgs e)
        {
            
            int outputs = Convert.ToInt32(lblDaysUsing.Text) - Convert.ToInt32(txtRolling.Text) + 1;
            if (outputs <= 0)
                outputs -= 1;
            lblOutputs.Text = outputs.ToString();
        }

        private void comBoxStrike_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdBtnPut.Checked = false;
            rdBtnCall.Checked = false;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

    }
}
