namespace DepositCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCalc = new System.Windows.Forms.Button();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.lbMethod = new System.Windows.Forms.Label();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.nudPeriod = new System.Windows.Forms.NumericUpDown();
            this.nudSum = new System.Windows.Forms.NumericUpDown();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbResInCurrency = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCalc
            // 
            this.bCalc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCalc.Location = new System.Drawing.Point(486, 89);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(151, 50);
            this.bCalc.TabIndex = 0;
            this.bCalc.Text = "Расчитать";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // cbMethod
            // 
            this.cbMethod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.DropDownWidth = 300;
            this.cbMethod.Items.AddRange(new object[] {
            "Вклад без капитализации процентов",
            "Вклад с капитализацией процентов"});
            this.cbMethod.Location = new System.Drawing.Point(242, 111);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(210, 28);
            this.cbMethod.TabIndex = 8;
            // 
            // lbMethod
            // 
            this.lbMethod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(242, 89);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(198, 20);
            this.lbMethod.TabIndex = 7;
            this.lbMethod.Text = "Метод выплаты процентов";
            // 
            // nudRate
            // 
            this.nudRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudRate.DecimalPlaces = 2;
            this.nudRate.Location = new System.Drawing.Point(242, 45);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(210, 27);
            this.nudRate.TabIndex = 6;
            this.nudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRate
            // 
            this.lbRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(242, 22);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(136, 20);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "Годовая ставка(%)";
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(12, 89);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(107, 20);
            this.lbPeriod.TabIndex = 4;
            this.lbPeriod.Text = "Срок(месяцы)";
            // 
            // nudPeriod
            // 
            this.nudPeriod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudPeriod.Location = new System.Drawing.Point(12, 112);
            this.nudPeriod.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeriod.Name = "nudPeriod";
            this.nudPeriod.Size = new System.Drawing.Size(192, 27);
            this.nudPeriod.TabIndex = 3;
            this.nudPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSum
            // 
            this.nudSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudSum.DecimalPlaces = 2;
            this.nudSum.Location = new System.Drawing.Point(12, 45);
            this.nudSum.Maximum = new decimal(new int[] {
            -1649267443,
            1271310319,
            4294967,
            0});
            this.nudSum.Name = "nudSum";
            this.nudSum.Size = new System.Drawing.Size(192, 27);
            this.nudSum.TabIndex = 2;
            this.nudSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSum
            // 
            this.lbSum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(12, 22);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(55, 20);
            this.lbSum.TabIndex = 0;
            this.lbSum.Text = "Сумма";
            // 
            // lbCurrency
            // 
            this.lbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(486, 22);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(60, 20);
            this.lbCurrency.TabIndex = 9;
            this.lbCurrency.Text = "Валюта";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbCurrency.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR"});
            this.cbCurrency.Location = new System.Drawing.Point(486, 45);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(151, 28);
            this.cbCurrency.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(600, 150);
            this.splitContainer1.Panel1.Controls.Add(this.cbCurrency);
            this.splitContainer1.Panel1.Controls.Add(this.nudSum);
            this.splitContainer1.Panel1.Controls.Add(this.lbCurrency);
            this.splitContainer1.Panel1.Controls.Add(this.lbSum);
            this.splitContainer1.Panel1.Controls.Add(this.cbMethod);
            this.splitContainer1.Panel1.Controls.Add(this.nudPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.bCalc);
            this.splitContainer1.Panel1.Controls.Add(this.lbPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.lbMethod);
            this.splitContainer1.Panel1.Controls.Add(this.lbRate);
            this.splitContainer1.Panel1.Controls.Add(this.nudRate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(600, 100);
            this.splitContainer1.Panel2.Controls.Add(this.tbResInCurrency);
            this.splitContainer1.Panel2.Controls.Add(this.tbResult);
            this.splitContainer1.Panel2.Controls.Add(this.lbResult);
            this.splitContainer1.Size = new System.Drawing.Size(671, 315);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 2;
            // 
            // tbResInCurrency
            // 
            this.tbResInCurrency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResInCurrency.Location = new System.Drawing.Point(178, 93);
            this.tbResInCurrency.Name = "tbResInCurrency";
            this.tbResInCurrency.ReadOnly = true;
            this.tbResInCurrency.Size = new System.Drawing.Size(308, 27);
            this.tbResInCurrency.TabIndex = 8;
            this.tbResInCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResult
            // 
            this.tbResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResult.Location = new System.Drawing.Point(178, 60);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(308, 27);
            this.tbResult.TabIndex = 7;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbResult
            // 
            this.lbResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(259, 24);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(140, 20);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Ожидаемый доход";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Депозитный калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bCalc;
        private ComboBox cbMethod;
        private Label lbMethod;
        private NumericUpDown nudRate;
        private Label lbRate;
        private Label lbPeriod;
        private NumericUpDown nudPeriod;
        private NumericUpDown nudSum;
        private Label lbSum;
        private Label lbCurrency;
        private ComboBox cbCurrency;
        private SplitContainer splitContainer1;
        private TextBox tbResult;
        private Label lbResult;
        private TextBox tbResInCurrency;
    }
}