namespace SymulatorHamowania
{
    partial class Form2TEST
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2TEST));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPredkosc = new System.Windows.Forms.NumericUpDown();
            this.tbDlugoscHamowania = new System.Windows.Forms.TextBox();
            this.btnWyliczDlugoscHamowania = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlRysowanie = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFINISH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHamulceStan = new System.Windows.Forms.TextBox();
            this.tbTarcie = new System.Windows.Forms.TextBox();
            this.comHamulce = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comNawierzchnia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRzeczDrogaHamowOSTATNIE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comCzasyReakcji = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReakcjaMetryWDECYZJI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Red;
            this.chart1.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Przebieg drogi hamowania:";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-319, -163);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Przebieg drogi hamowania:";
            series3.Name = "Prędkość";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Przebieg drogi hamowania:";
            series4.Name = "Droga hamowania";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(382, 300);
            this.chart1.TabIndex = 23;
            this.chart1.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numPredkosc);
            this.panel2.Controls.Add(this.tbDlugoscHamowania);
            this.panel2.Controls.Add(this.btnWyliczDlugoscHamowania);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-379, -442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 264);
            this.panel2.TabIndex = 18;
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
            this.numPredkosc.Name = "numPredkosc";
            this.numPredkosc.Size = new System.Drawing.Size(138, 28);
            this.numPredkosc.TabIndex = 0;
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
            this.btnWyliczDlugoscHamowania.BackColor = System.Drawing.Color.Silver;
            this.btnWyliczDlugoscHamowania.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWyliczDlugoscHamowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyliczDlugoscHamowania.Location = new System.Drawing.Point(18, 71);
            this.btnWyliczDlugoscHamowania.Name = "btnWyliczDlugoscHamowania";
            this.btnWyliczDlugoscHamowania.Size = new System.Drawing.Size(519, 104);
            this.btnWyliczDlugoscHamowania.TabIndex = 1;
            this.btnWyliczDlugoscHamowania.Text = "Wylicz Dlugość Drogi Hamowania - laboratoryjnie \r\n(bez uwzględnienia\r\n opóźnień, " +
    "na które wpływają różne czynniki, jak np. opóźniony czas reakcji\r\n.\r\n)";
            this.btnWyliczDlugoscHamowania.UseVisualStyleBackColor = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-383, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1488, 400);
            this.label12.TabIndex = 20;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // pnlRysowanie
            // 
            this.pnlRysowanie.Location = new System.Drawing.Point(-360, 184);
            this.pnlRysowanie.Name = "pnlRysowanie";
            this.pnlRysowanie.Size = new System.Drawing.Size(200, 100);
            this.pnlRysowanie.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-383, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1566, 280);
            this.label13.TabIndex = 21;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // tbFINISH
            // 
            this.tbFINISH.Location = new System.Drawing.Point(394, 578);
            this.tbFINISH.Name = "tbFINISH";
            this.tbFINISH.Size = new System.Drawing.Size(100, 26);
            this.tbFINISH.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(36, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Wynik\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 88);
            this.label6.TabIndex = 1;
            this.label6.Text = "Długość drogi hamowania z uwzgl. tarcia \r\no nawierzchnię drogi, w m/s.:\r\n\r\n\r\n";
            // 
            // tbHamulceStan
            // 
            this.tbHamulceStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHamulceStan.Location = new System.Drawing.Point(101, 468);
            this.tbHamulceStan.Name = "tbHamulceStan";
            this.tbHamulceStan.Size = new System.Drawing.Size(195, 28);
            this.tbHamulceStan.TabIndex = 18;
            // 
            // tbTarcie
            // 
            this.tbTarcie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTarcie.Location = new System.Drawing.Point(370, 133);
            this.tbTarcie.Name = "tbTarcie";
            this.tbTarcie.Size = new System.Drawing.Size(188, 28);
            this.tbTarcie.TabIndex = 3;
            // 
            // comHamulce
            // 
            this.comHamulce.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comHamulce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comHamulce.FormattingEnabled = true;
            this.comHamulce.Items.AddRange(new object[] {
            "Hamulce sprawne",
            "Hamulce na granicy sprawności",
            "Hamulce niesprawne"});
            this.comHamulce.Location = new System.Drawing.Point(40, 413);
            this.comHamulce.Name = "comHamulce";
            this.comHamulce.Size = new System.Drawing.Size(280, 28);
            this.comHamulce.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
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
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(26, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(304, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Wybierz Stanu układu hamulcowego:\r\n";
            // 
            // comNawierzchnia
            // 
            this.comNawierzchnia.CausesValidation = false;
            this.comNawierzchnia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comNawierzchnia.Size = new System.Drawing.Size(188, 30);
            this.comNawierzchnia.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(296, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "metry:";
            // 
            // tbRzeczDrogaHamowOSTATNIE
            // 
            this.tbRzeczDrogaHamowOSTATNIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRzeczDrogaHamowOSTATNIE.Location = new System.Drawing.Point(676, 478);
            this.tbRzeczDrogaHamowOSTATNIE.Name = "tbRzeczDrogaHamowOSTATNIE";
            this.tbRzeczDrogaHamowOSTATNIE.Size = new System.Drawing.Size(121, 28);
            this.tbRzeczDrogaHamowOSTATNIE.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "MOŻLIWE PRZYCZYNY OPÓŹNIEŃ:\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz czas reakcji kierowcy:\r\n";
            // 
            // comCzasyReakcji
            // 
            this.comCzasyReakcji.CausesValidation = false;
            this.comCzasyReakcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCzasyReakcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comCzasyReakcji.FormatString = "N2";
            this.comCzasyReakcji.FormattingEnabled = true;
            this.comCzasyReakcji.Items.AddRange(new object[] {
            "1 sekunda",
            "2 sekundy",
            "3 sekundy",
            "4 sekundy",
            "5 sekund"});
            this.comCzasyReakcji.Location = new System.Drawing.Point(30, 232);
            this.comCzasyReakcji.Name = "comCzasyReakcji";
            this.comCzasyReakcji.Size = new System.Drawing.Size(188, 30);
            this.comCzasyReakcji.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbFINISH);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbHamulceStan);
            this.panel1.Controls.Add(this.tbTarcie);
            this.panel1.Controls.Add(this.comHamulce);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comNawierzchnia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbRzeczDrogaHamowOSTATNIE);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comCzasyReakcji);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbReakcjaMetryWDECYZJI);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(199, -442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 687);
            this.panel1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(233, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "2)  Rzeczywista droga hamowania pojazdu:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(27, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "metry:";
            // 
            // tbReakcjaMetryWDECYZJI
            // 
            this.tbReakcjaMetryWDECYZJI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbReakcjaMetryWDECYZJI.Location = new System.Drawing.Point(31, 312);
            this.tbReakcjaMetryWDECYZJI.Name = "tbReakcjaMetryWDECYZJI";
            this.tbReakcjaMetryWDECYZJI.ReadOnly = true;
            this.tbReakcjaMetryWDECYZJI.Size = new System.Drawing.Size(168, 28);
            this.tbReakcjaMetryWDECYZJI.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(285, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(774, 110);
            this.label4.TabIndex = 5;
            this.label4.Text = "1) Droga hamowania podczas podejmowania decyzji = reakcji kierowcy\r\n\r\ndystans, ja" +
    "ki samochód przejeżdża od chwili wciśnięcia hamulca do całkowitego zatrzymania s" +
    "ię.\r\n\r\n\r\n";
            // 
            // Form2TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 817);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pnlRysowanie);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Name = "Form2TEST";
            this.Text = "Form2TEST";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPredkosc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.NumericUpDown numPredkosc;
        public System.Windows.Forms.TextBox tbDlugoscHamowania;
        public System.Windows.Forms.Button btnWyliczDlugoscHamowania;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlRysowanie;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tbFINISH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbHamulceStan;
        public System.Windows.Forms.TextBox tbTarcie;
        public System.Windows.Forms.ComboBox comHamulce;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comNawierzchnia;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbRzeczDrogaHamowOSTATNIE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comCzasyReakcji;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbReakcjaMetryWDECYZJI;
        private System.Windows.Forms.Label label4;
    }
}