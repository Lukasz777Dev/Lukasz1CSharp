namespace SymulatorHamowania
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.numPredkosc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDlugoscHamowania = new System.Windows.Forms.TextBox();
            this.btnWyliczDlugoscHamowania = new System.Windows.Forms.Button();
            this.comCzasyReakcji = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReakcjaMetryWDECYZJI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRzeczDrogaHamowOSTATNIE = new System.Windows.Forms.TextBox();
            this.tbFINISH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHamulceStan = new System.Windows.Forms.TextBox();
            this.tbTarcie = new System.Windows.Forms.TextBox();
            this.comHamulce = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comNawierzchnia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numPredkosc
            // 
            this.numPredkosc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numPredkosc.DecimalPlaces = 2;
            this.numPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numPredkosc.Location = new System.Drawing.Point(18, 37);
            this.numPredkosc.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numPredkosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPredkosc.Name = "numPredkosc";
            this.numPredkosc.Size = new System.Drawing.Size(138, 28);
            this.numPredkosc.TabIndex = 0;
            this.numPredkosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Podaj prędkość pojazdu [km/h]";
            // 
            // tbDlugoscHamowania
            // 
            this.tbDlugoscHamowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDlugoscHamowania.Location = new System.Drawing.Point(18, 204);
            this.tbDlugoscHamowania.Name = "tbDlugoscHamowania";
            this.tbDlugoscHamowania.Size = new System.Drawing.Size(251, 28);
            this.tbDlugoscHamowania.TabIndex = 2;
            // 
            // btnWyliczDlugoscHamowania
            // 
            this.btnWyliczDlugoscHamowania.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWyliczDlugoscHamowania.BackColor = System.Drawing.Color.LightGreen;
            this.btnWyliczDlugoscHamowania.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWyliczDlugoscHamowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyliczDlugoscHamowania.Location = new System.Drawing.Point(18, 71);
            this.btnWyliczDlugoscHamowania.Name = "btnWyliczDlugoscHamowania";
            this.btnWyliczDlugoscHamowania.Size = new System.Drawing.Size(519, 104);
            this.btnWyliczDlugoscHamowania.TabIndex = 1;
            this.btnWyliczDlugoscHamowania.Text = "Wylicz Dlugość Drogi Hamowania - laboratoryjnie \r\n(bez uwzględnienia\r\n opóźnień, " +
    "na które wpływają różne czynniki, jak np. opóźniony czas reakcji\r\n.\r\n)";
            this.btnWyliczDlugoscHamowania.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWyliczDlugoscHamowania.UseVisualStyleBackColor = false;
            this.btnWyliczDlugoscHamowania.Click += new System.EventHandler(this.btnWyliczDlugoscHamowania_Click);
            // 
            // comCzasyReakcji
            // 
            this.comCzasyReakcji.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comCzasyReakcji.CausesValidation = false;
            this.comCzasyReakcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCzasyReakcji.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comCzasyReakcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comCzasyReakcji.FormatString = "N2";
            this.comCzasyReakcji.FormattingEnabled = true;
            this.comCzasyReakcji.Items.AddRange(new object[] {
            "1 sekunda",
            "2 sekundy",
            "3 sekundy",
            "4 sekundy",
            "5 sekund"});
            this.comCzasyReakcji.Location = new System.Drawing.Point(28, 292);
            this.comCzasyReakcji.Name = "comCzasyReakcji";
            this.comCzasyReakcji.Size = new System.Drawing.Size(185, 30);
            this.comCzasyReakcji.TabIndex = 2;
            this.comCzasyReakcji.SelectedIndexChanged += new System.EventHandler(this.comCzasyReakcji_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz czas reakcji kierowcy:\r\n";
            // 
            // tbReakcjaMetryWDECYZJI
            // 
            this.tbReakcjaMetryWDECYZJI.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbReakcjaMetryWDECYZJI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReakcjaMetryWDECYZJI.Location = new System.Drawing.Point(89, 336);
            this.tbReakcjaMetryWDECYZJI.Name = "tbReakcjaMetryWDECYZJI";
            this.tbReakcjaMetryWDECYZJI.ReadOnly = true;
            this.tbReakcjaMetryWDECYZJI.Size = new System.Drawing.Size(168, 28);
            this.tbReakcjaMetryWDECYZJI.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(24, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "metry:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbRzeczDrogaHamowOSTATNIE);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbHamulceStan);
            this.panel1.Controls.Add(this.tbTarcie);
            this.panel1.Controls.Add(this.comHamulce);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comNawierzchnia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comCzasyReakcji);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbReakcjaMetryWDECYZJI);
            this.panel1.Location = new System.Drawing.Point(590, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 652);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tbFINISH);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(25, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 98);
            this.panel3.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(39, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rzeczywista droga hamowania pojazdu:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(113, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "metry:";
            // 
            // tbRzeczDrogaHamowOSTATNIE
            // 
            this.tbRzeczDrogaHamowOSTATNIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRzeczDrogaHamowOSTATNIE.Location = new System.Drawing.Point(49, 608);
            this.tbRzeczDrogaHamowOSTATNIE.Name = "tbRzeczDrogaHamowOSTATNIE";
            this.tbRzeczDrogaHamowOSTATNIE.Size = new System.Drawing.Size(148, 28);
            this.tbRzeczDrogaHamowOSTATNIE.TabIndex = 13;
            this.tbRzeczDrogaHamowOSTATNIE.Text = " ";
            this.tbRzeczDrogaHamowOSTATNIE.Visible = false;
            this.tbRzeczDrogaHamowOSTATNIE.TextChanged += new System.EventHandler(this.tbRzeczDrogaHamowOSTATNIE_TextChanged);
            // 
            // tbFINISH
            // 
            this.tbFINISH.Location = new System.Drawing.Point(200, 42);
            this.tbFINISH.Name = "tbFINISH";
            this.tbFINISH.Size = new System.Drawing.Size(100, 26);
            this.tbFINISH.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(24, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "metry:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 110);
            this.label6.TabIndex = 1;
            this.label6.Text = "Długość drogi hamowania z uwzgl. tarcia \r\no nawierzchnię drogi,wynosi\r\n w m/s.:\r\n" +
    "\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbHamulceStan
            // 
            this.tbHamulceStan.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbHamulceStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHamulceStan.Location = new System.Drawing.Point(110, 443);
            this.tbHamulceStan.Name = "tbHamulceStan";
            this.tbHamulceStan.Size = new System.Drawing.Size(195, 28);
            this.tbHamulceStan.TabIndex = 18;
            // 
            // tbTarcie
            // 
            this.tbTarcie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbTarcie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTarcie.Location = new System.Drawing.Point(25, 217);
            this.tbTarcie.Name = "tbTarcie";
            this.tbTarcie.Size = new System.Drawing.Size(188, 28);
            this.tbTarcie.TabIndex = 3;
            // 
            // comHamulce
            // 
            this.comHamulce.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comHamulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comHamulce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comHamulce.FormattingEnabled = true;
            this.comHamulce.Items.AddRange(new object[] {
            "Hamulce sprawne",
            "Hamulce na granicy sprawności",
            "Hamulce niesprawne"});
            this.comHamulce.Location = new System.Drawing.Point(25, 406);
            this.comHamulce.Name = "comHamulce";
            this.comHamulce.Size = new System.Drawing.Size(280, 28);
            this.comHamulce.TabIndex = 3;
            this.comHamulce.SelectedIndexChanged += new System.EventHandler(this.comHamulce_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(27, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(328, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "Wybierz jakość stanu nawierzchni drogi:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(21, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Wybierz Stanu układu hamulcowego:\r\n";
            // 
            // comNawierzchnia
            // 
            this.comNawierzchnia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comNawierzchnia.CausesValidation = false;
            this.comNawierzchnia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comNawierzchnia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comNawierzchnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comNawierzchnia.FormatString = "N2";
            this.comNawierzchnia.FormattingEnabled = true;
            this.comNawierzchnia.Items.AddRange(new object[] {
            "sucha",
            "mokra",
            "ośnieżona",
            "oblodzona",
            "glazura"});
            this.comNawierzchnia.Location = new System.Drawing.Point(30, 62);
            this.comNawierzchnia.Name = "comNawierzchnia";
            this.comNawierzchnia.Size = new System.Drawing.Size(183, 30);
            this.comNawierzchnia.TabIndex = 0;
            this.comNawierzchnia.SelectedIndexChanged += new System.EventHandler(this.comNawierzchnia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(27, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "MOŻLIWE PRZYCZYNY OPÓŹNIEŃ:\r\n\r\n";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Red;
            this.chart1.BorderlineWidth = 2;
            chartArea3.CursorY.LineColor = System.Drawing.Color.Navy;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Przebieg drogi hamowania:";
            legend3.ShadowColor = System.Drawing.Color.Silver;
            legend3.Title = "LEGENDA:";
            legend3.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(22, 297);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Przebieg drogi hamowania:";
            series5.MarkerColor = System.Drawing.Color.Red;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series5.Name = "Prędkość";
            dataPoint5.AxisLabel = "Prędkość:";
            dataPoint5.BorderColor = System.Drawing.Color.Red;
            dataPoint5.BorderWidth = 10;
            dataPoint5.Color = System.Drawing.Color.Red;
            dataPoint5.CustomProperties = "LabelStyle=Bottom";
            dataPoint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataPoint5.Label = "";
            dataPoint5.LabelAngle = 0;
            dataPoint5.MarkerColor = System.Drawing.Color.White;
            dataPoint5.MarkerSize = 5;
            dataPoint5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            series5.Points.Add(dataPoint5);
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Legend = "Przebieg drogi hamowania:";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series6.Name = "Droga hamowania";
            dataPoint6.AxisLabel = "Hamowanie:";
            dataPoint6.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataPoint6.MarkerSize = 3;
            series6.Points.Add(dataPoint6);
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValuesPerPoint = 32;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(562, 367);
            this.chart1.TabIndex = 17;
            this.chart1.Text = " Przebieg drogi hamowania:";
            title3.Name = "Title1";
            this.chart1.Titles.Add(title3);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numPredkosc);
            this.panel2.Controls.Add(this.tbDlugoscHamowania);
            this.panel2.Controls.Add(this.btnWyliczDlugoscHamowania);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 264);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1053, 826);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comCzasyReakcji;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.NumericUpDown numPredkosc;
        public System.Windows.Forms.TextBox tbReakcjaMetryWDECYZJI;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox comNawierzchnia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comHamulce;
        public System.Windows.Forms.TextBox tbDlugoscHamowania;
        public System.Windows.Forms.Button btnWyliczDlugoscHamowania;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tbRzeczDrogaHamowOSTATNIE;
        public System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tbTarcie;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.TextBox tbHamulceStan;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.TextBox tbFINISH;
        private System.Windows.Forms.Panel panel3;
    }
}

