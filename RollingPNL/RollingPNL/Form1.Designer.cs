namespace RollingPNL
{
    partial class RollingPNL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comBoxMonth = new System.Windows.Forms.ComboBox();
            this.comBoxStrike = new System.Windows.Forms.ComboBox();
            this.rdBtnCall = new System.Windows.Forms.RadioButton();
            this.rdBtnPut = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comBoxStartDate = new System.Windows.Forms.ComboBox();
            this.comBoxEndDate = new System.Windows.Forms.ComboBox();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.txtRolling = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFuturesPnL = new System.Windows.Forms.Label();
            this.lblOptionsPnL = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSlippage = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPriceDiff = new System.Windows.Forms.Label();
            this.btnRollingPnL = new System.Windows.Forms.Button();
            this.dataGridViewRolling = new System.Windows.Forms.DataGridView();
            this.lblDaysUsing = new System.Windows.Forms.Label();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.dateEnding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futuresPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsPnL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTradeFutures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slippage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRolling)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxMonth
            // 
            this.comBoxMonth.FormattingEnabled = true;
            this.comBoxMonth.Location = new System.Drawing.Point(13, 38);
            this.comBoxMonth.Name = "comBoxMonth";
            this.comBoxMonth.Size = new System.Drawing.Size(90, 21);
            this.comBoxMonth.TabIndex = 0;
            this.comBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comBoxMonth_SelectedIndexChanged);
            // 
            // comBoxStrike
            // 
            this.comBoxStrike.FormattingEnabled = true;
            this.comBoxStrike.Location = new System.Drawing.Point(109, 38);
            this.comBoxStrike.Name = "comBoxStrike";
            this.comBoxStrike.Size = new System.Drawing.Size(90, 21);
            this.comBoxStrike.TabIndex = 1;
            this.comBoxStrike.SelectedIndexChanged += new System.EventHandler(this.comBoxStrike_SelectedIndexChanged);
            // 
            // rdBtnCall
            // 
            this.rdBtnCall.AutoSize = true;
            this.rdBtnCall.Location = new System.Drawing.Point(212, 35);
            this.rdBtnCall.Name = "rdBtnCall";
            this.rdBtnCall.Size = new System.Drawing.Size(42, 17);
            this.rdBtnCall.TabIndex = 2;
            this.rdBtnCall.TabStop = true;
            this.rdBtnCall.Text = "Call";
            this.rdBtnCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdBtnCall.UseVisualStyleBackColor = true;
            this.rdBtnCall.CheckedChanged += new System.EventHandler(this.rdBtnCall_CheckedChanged);
            // 
            // rdBtnPut
            // 
            this.rdBtnPut.AutoSize = true;
            this.rdBtnPut.Location = new System.Drawing.Point(212, 49);
            this.rdBtnPut.Name = "rdBtnPut";
            this.rdBtnPut.Size = new System.Drawing.Size(41, 17);
            this.rdBtnPut.TabIndex = 3;
            this.rdBtnPut.TabStop = true;
            this.rdBtnPut.Text = "Put";
            this.rdBtnPut.UseVisualStyleBackColor = true;
            this.rdBtnPut.CheckedChanged += new System.EventHandler(this.rdBtnPut_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(109, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Strike";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "From";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(95, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(177, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "# of Days";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBoxStartDate
            // 
            this.comBoxStartDate.FormattingEnabled = true;
            this.comBoxStartDate.Location = new System.Drawing.Point(13, 118);
            this.comBoxStartDate.Name = "comBoxStartDate";
            this.comBoxStartDate.Size = new System.Drawing.Size(76, 21);
            this.comBoxStartDate.TabIndex = 10;
            this.comBoxStartDate.SelectedIndexChanged += new System.EventHandler(this.comBoxStartDate_SelectedIndexChanged);
            // 
            // comBoxEndDate
            // 
            this.comBoxEndDate.FormattingEnabled = true;
            this.comBoxEndDate.Location = new System.Drawing.Point(95, 118);
            this.comBoxEndDate.Name = "comBoxEndDate";
            this.comBoxEndDate.Size = new System.Drawing.Size(76, 21);
            this.comBoxEndDate.TabIndex = 11;
            this.comBoxEndDate.SelectedIndexChanged += new System.EventHandler(this.comBoxEndDate_SelectedIndexChanged);
            // 
            // lblNumDays
            // 
            this.lblNumDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumDays.Location = new System.Drawing.Point(177, 118);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(76, 23);
            this.lblNumDays.TabIndex = 12;
            this.lblNumDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRolling
            // 
            this.txtRolling.Location = new System.Drawing.Point(95, 173);
            this.txtRolling.Name = "txtRolling";
            this.txtRolling.Size = new System.Drawing.Size(76, 20);
            this.txtRolling.TabIndex = 14;
            this.txtRolling.Text = "20";
            this.txtRolling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRolling.TextChanged += new System.EventHandler(this.txtRolling_TextChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Days to Use";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(95, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rolling";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(177, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "# of Outputs";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(279, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(941, 324);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(95, 196);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(76, 23);
            this.btnOutput.TabIndex = 20;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(13, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Options PnL:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(13, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Futures PnL:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(13, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Subtotal:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(13, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Slippage:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "TOTAL:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFuturesPnL
            // 
            this.lblFuturesPnL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuturesPnL.Location = new System.Drawing.Point(109, 258);
            this.lblFuturesPnL.Name = "lblFuturesPnL";
            this.lblFuturesPnL.Size = new System.Drawing.Size(76, 23);
            this.lblFuturesPnL.TabIndex = 26;
            this.lblFuturesPnL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOptionsPnL
            // 
            this.lblOptionsPnL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOptionsPnL.Location = new System.Drawing.Point(109, 291);
            this.lblOptionsPnL.Name = "lblOptionsPnL";
            this.lblOptionsPnL.Size = new System.Drawing.Size(76, 23);
            this.lblOptionsPnL.TabIndex = 27;
            this.lblOptionsPnL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(109, 323);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(76, 23);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlippage
            // 
            this.lblSlippage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlippage.Location = new System.Drawing.Point(109, 375);
            this.lblSlippage.Name = "lblSlippage";
            this.lblSlippage.Size = new System.Drawing.Size(76, 23);
            this.lblSlippage.TabIndex = 29;
            this.lblSlippage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(109, 408);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 23);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(13, 474);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Price Diff:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceDiff
            // 
            this.lblPriceDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPriceDiff.Location = new System.Drawing.Point(109, 474);
            this.lblPriceDiff.Name = "lblPriceDiff";
            this.lblPriceDiff.Size = new System.Drawing.Size(76, 23);
            this.lblPriceDiff.TabIndex = 32;
            this.lblPriceDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollingPnL
            // 
            this.btnRollingPnL.Location = new System.Drawing.Point(177, 196);
            this.btnRollingPnL.Name = "btnRollingPnL";
            this.btnRollingPnL.Size = new System.Drawing.Size(77, 23);
            this.btnRollingPnL.TabIndex = 33;
            this.btnRollingPnL.Text = "Rolling PnL";
            this.btnRollingPnL.UseVisualStyleBackColor = true;
            this.btnRollingPnL.Click += new System.EventHandler(this.btnRollingPnL_Click);
            // 
            // dataGridViewRolling
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRolling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRolling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRolling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateEnding,
            this.futuresPnL,
            this.optionsPnL,
            this.dayTradeFutures,
            this.slippage,
            this.total,
            this.priceDiff});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRolling.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRolling.Location = new System.Drawing.Point(279, 342);
            this.dataGridViewRolling.Name = "dataGridViewRolling";
            this.dataGridViewRolling.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRolling.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRolling.Size = new System.Drawing.Size(941, 402);
            this.dataGridViewRolling.TabIndex = 38;
            // 
            // lblDaysUsing
            // 
            this.lblDaysUsing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDaysUsing.Location = new System.Drawing.Point(13, 170);
            this.lblDaysUsing.Name = "lblDaysUsing";
            this.lblDaysUsing.Size = new System.Drawing.Size(76, 23);
            this.lblDaysUsing.TabIndex = 39;
            this.lblDaysUsing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputs
            // 
            this.lblOutputs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutputs.Location = new System.Drawing.Point(177, 170);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(76, 23);
            this.lblOutputs.TabIndex = 40;
            this.lblOutputs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(109, 537);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(76, 23);
            this.btnChart.TabIndex = 41;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // dateEnding
            // 
            this.dateEnding.HeaderText = "Date Ending";
            this.dateEnding.Name = "dateEnding";
            this.dateEnding.ReadOnly = true;
            // 
            // futuresPnL
            // 
            this.futuresPnL.HeaderText = "Futures PnL";
            this.futuresPnL.Name = "futuresPnL";
            this.futuresPnL.ReadOnly = true;
            // 
            // optionsPnL
            // 
            this.optionsPnL.HeaderText = "Options PnL";
            this.optionsPnL.Name = "optionsPnL";
            this.optionsPnL.ReadOnly = true;
            // 
            // dayTradeFutures
            // 
            this.dayTradeFutures.HeaderText = "Day Trade Futures";
            this.dayTradeFutures.Name = "dayTradeFutures";
            this.dayTradeFutures.ReadOnly = true;
            // 
            // slippage
            // 
            this.slippage.HeaderText = "Slippage";
            this.slippage.Name = "slippage";
            this.slippage.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // priceDiff
            // 
            this.priceDiff.HeaderText = "Price Diff";
            this.priceDiff.Name = "priceDiff";
            this.priceDiff.ReadOnly = true;
            // 
            // RollingPNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1232, 756);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.lblDaysUsing);
            this.Controls.Add(this.dataGridViewRolling);
            this.Controls.Add(this.btnRollingPnL);
            this.Controls.Add(this.lblPriceDiff);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSlippage);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblOptionsPnL);
            this.Controls.Add(this.lblFuturesPnL);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRolling);
            this.Controls.Add(this.lblNumDays);
            this.Controls.Add(this.comBoxEndDate);
            this.Controls.Add(this.comBoxStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBtnPut);
            this.Controls.Add(this.rdBtnCall);
            this.Controls.Add(this.comBoxStrike);
            this.Controls.Add(this.comBoxMonth);
            this.Name = "RollingPNL";
            this.Text = "Rolling PNL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRolling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxMonth;
        private System.Windows.Forms.ComboBox comBoxStrike;
        private System.Windows.Forms.RadioButton rdBtnCall;
        private System.Windows.Forms.RadioButton rdBtnPut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comBoxStartDate;
        private System.Windows.Forms.ComboBox comBoxEndDate;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.TextBox txtRolling;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFuturesPnL;
        private System.Windows.Forms.Label lblOptionsPnL;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSlippage;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPriceDiff;
        private System.Windows.Forms.Button btnRollingPnL;
        private System.Windows.Forms.DataGridView dataGridViewRolling;
        private System.Windows.Forms.Label lblDaysUsing;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnding;
        private System.Windows.Forms.DataGridViewTextBoxColumn futuresPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionsPnL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTradeFutures;
        private System.Windows.Forms.DataGridViewTextBoxColumn slippage;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDiff;
    }
}

