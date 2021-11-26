
namespace Portfolio {
    partial class HlavniFormular {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HlavniFormular));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nazev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hodnota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hodnotaKc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonVymazatVse = new System.Windows.Forms.Button();
            this.buttonVymazatRadek = new System.Windows.Forms.Button();
            this.buttonKonec = new System.Windows.Forms.Button();
            this.chartPortfolio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPopisekSumaCelkem = new System.Windows.Forms.Label();
            this.labelSumaCelkem = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProcenta = new System.Windows.Forms.ComboBox();
            this.labelPopisekSpojeniVyseci = new System.Windows.Forms.Label();
            this.labelPopisekProcenta = new System.Windows.Forms.Label();
            this.buttonKurzy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTipUlozit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVymazatRadek = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVymazatVse = new System.Windows.Forms.ToolTip(this.components);
            this.investiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipKurzy = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPortfolio)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 25;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazev,
            this.hodnota,
            this.kod,
            this.hodnotaKc});
            this.dataGridView.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(504, 397);
            this.dataGridView.TabIndex = 0;
            
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            this.dataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_DefaultValuesNeeded);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
           
            // 
            // nazev
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nazev.DefaultCellStyle = dataGridViewCellStyle2;
            this.nazev.HeaderText = "Název investice";
            this.nazev.Name = "nazev";
            this.nazev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nazev.Width = 200;
            // 
            // hodnota
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.hodnota.DefaultCellStyle = dataGridViewCellStyle3;
            this.hodnota.HeaderText = " Hodnota";
            this.hodnota.Name = "hodnota";
            this.hodnota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hodnota.Width = 80;
            // 
            // kod
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kod.DefaultCellStyle = dataGridViewCellStyle4;
            this.kod.DisplayStyleForCurrentCellOnly = true;
            this.kod.HeaderText = "Kód měny";
            this.kod.Items.AddRange(new object[] {
            "CZK",
            "AUD",
            "BRL",
            "BGN",
            "CNY",
            "DKK",
            "EUR",
            "PHP",
            "HKD",
            "HRK",
            "INR",
            "IDR",
            "ISK",
            "ILS",
            "JPY",
            "ZAR",
            "CAD",
            "KRW",
            "HUF",
            "MYR",
            "MXN",
            "XDR",
            "NOK",
            "NZD",
            "PLN",
            "RON",
            "RUB",
            "SGD",
            "SEK",
            "CHF",
            "THB",
            "TRY",
            "USD",
            "GBP"});
            this.kod.MaxDropDownItems = 35;
            this.kod.Name = "kod";
            this.kod.ToolTipText = "Vyberte kód měny, ve které jste zadali hodnotu investice";
            this.kod.Width = 69;
            // 
            // hodnotaKc
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.hodnotaKc.DefaultCellStyle = dataGridViewCellStyle5;
            this.hodnotaKc.HeaderText = "Hodnota Kč";
            this.hodnotaKc.Name = "hodnotaKc";
            this.hodnotaKc.ReadOnly = true;
            this.hodnotaKc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hodnotaKc.Width = 80;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUlozit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozit.Location = new System.Drawing.Point(23, 12);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(88, 28);
            this.buttonUlozit.TabIndex = 1;
            this.buttonUlozit.Text = "&Uložit";
            this.toolTipUlozit.SetToolTip(this.buttonUlozit, "Uloží všechna data  Alt + U");
            this.buttonUlozit.UseVisualStyleBackColor = false;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // buttonVymazatVse
            // 
            this.buttonVymazatVse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonVymazatVse.Location = new System.Drawing.Point(251, 12);
            this.buttonVymazatVse.Name = "buttonVymazatVse";
            this.buttonVymazatVse.Size = new System.Drawing.Size(88, 28);
            this.buttonVymazatVse.TabIndex = 3;
            this.buttonVymazatVse.Text = "Vymazat vš&e";
            this.toolTipVymazatVse.SetToolTip(this.buttonVymazatVse, "Vymaže všechna data  Alt + E");
            this.buttonVymazatVse.UseVisualStyleBackColor = false;
            this.buttonVymazatVse.Click += new System.EventHandler(this.buttonVymazatVse_Click);
            // 
            // buttonVymazatRadek
            // 
            this.buttonVymazatRadek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.buttonVymazatRadek.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVymazatRadek.Location = new System.Drawing.Point(137, 12);
            this.buttonVymazatRadek.Name = "buttonVymazatRadek";
            this.buttonVymazatRadek.Size = new System.Drawing.Size(88, 28);
            this.buttonVymazatRadek.TabIndex = 2;
            this.buttonVymazatRadek.Text = "&Vymazat řádek";
            this.toolTipVymazatRadek.SetToolTip(this.buttonVymazatRadek, "Vymaže pouze označené řádky  Alt + V");
            this.buttonVymazatRadek.UseVisualStyleBackColor = false;
            this.buttonVymazatRadek.Click += new System.EventHandler(this.buttonVymazatRadek_Click);
            // 
            // buttonKonec
            // 
            this.buttonKonec.BackColor = System.Drawing.SystemColors.Control;
            this.buttonKonec.Location = new System.Drawing.Point(504, 12);
            this.buttonKonec.Name = "buttonKonec";
            this.buttonKonec.Size = new System.Drawing.Size(88, 28);
            this.buttonKonec.TabIndex = 5;
            this.buttonKonec.Text = "Konec";
            this.buttonKonec.UseVisualStyleBackColor = false;
            this.buttonKonec.Click += new System.EventHandler(this.buttonKonec_Click);
            // 
            // chartPortfolio
            // 
            this.chartPortfolio.BorderlineColor = System.Drawing.SystemColors.ControlDark;
            this.chartPortfolio.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartPortfolio.ChartAreas.Add(chartArea1);
            legend1.IsEquallySpacedItems = true;
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 45;
            legend1.Title = "Investice";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartPortfolio.Legends.Add(legend1);
            this.chartPortfolio.Location = new System.Drawing.Point(476, 0);
            this.chartPortfolio.Name = "chartPortfolio";
            this.chartPortfolio.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieDrawingStyle=Concave, CollectedLegendText=";
            series1.Legend = "Legend1";
            series1.Name = "Investice";
            dataPoint1.CustomProperties = "OriginalPointIndex=0";
            dataPoint1.IsValueShownAsLabel = false;
            series1.Points.Add(dataPoint1);
            this.chartPortfolio.Series.Add(series1);
            this.chartPortfolio.Size = new System.Drawing.Size(611, 398);
            this.chartPortfolio.TabIndex = 6;
            this.chartPortfolio.TabStop = false;
            // 
            // labelPopisekSumaCelkem
            // 
            this.labelPopisekSumaCelkem.AutoSize = true;
            this.labelPopisekSumaCelkem.Location = new System.Drawing.Point(6, 12);
            this.labelPopisekSumaCelkem.Name = "labelPopisekSumaCelkem";
            this.labelPopisekSumaCelkem.Size = new System.Drawing.Size(116, 13);
            this.labelPopisekSumaCelkem.TabIndex = 7;
            this.labelPopisekSumaCelkem.Text = "Celková suma investic:";
            this.labelPopisekSumaCelkem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelSumaCelkem
            // 
            this.labelSumaCelkem.Location = new System.Drawing.Point(120, 12);
            this.labelSumaCelkem.Name = "labelSumaCelkem";
            this.labelSumaCelkem.Size = new System.Drawing.Size(84, 13);
            this.labelSumaCelkem.TabIndex = 7;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.buttonKurzy);
            this.panel.Controls.Add(this.buttonUlozit);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.buttonVymazatVse);
            this.panel.Controls.Add(this.buttonVymazatRadek);
            this.panel.Controls.Add(this.buttonKonec);
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Location = new System.Drawing.Point(-1, 397);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1088, 58);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxProcenta);
            this.groupBox2.Controls.Add(this.labelPopisekSpojeniVyseci);
            this.groupBox2.Controls.Add(this.labelPopisekProcenta);
            this.groupBox2.Location = new System.Drawing.Point(622, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 33);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxProcenta
            // 
            this.comboBoxProcenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcenta.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxProcenta.Location = new System.Drawing.Point(151, 9);
            this.comboBoxProcenta.Name = "comboBoxProcenta";
            this.comboBoxProcenta.Size = new System.Drawing.Size(34, 21);
            this.comboBoxProcenta.TabIndex = 10;
            this.comboBoxProcenta.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcenta_SelectedIndexChanged);
            // 
            // labelPopisekSpojeniVyseci
            // 
            this.labelPopisekSpojeniVyseci.AutoSize = true;
            this.labelPopisekSpojeniVyseci.Location = new System.Drawing.Point(6, 12);
            this.labelPopisekSpojeniVyseci.Name = "labelPopisekSpojeniVyseci";
            this.labelPopisekSpojeniVyseci.Size = new System.Drawing.Size(143, 13);
            this.labelPopisekSpojeniVyseci.TabIndex = 7;
            this.labelPopisekSpojeniVyseci.Text = "Spojení výsečí menších než";
            this.labelPopisekSpojeniVyseci.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPopisekProcenta
            // 
            this.labelPopisekProcenta.Location = new System.Drawing.Point(186, 12);
            this.labelPopisekProcenta.Name = "labelPopisekProcenta";
            this.labelPopisekProcenta.Size = new System.Drawing.Size(19, 13);
            this.labelPopisekProcenta.TabIndex = 7;
            this.labelPopisekProcenta.Text = "%";
            // 
            // buttonKurzy
            // 
            this.buttonKurzy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonKurzy.Location = new System.Drawing.Point(365, 12);
            this.buttonKurzy.Name = "buttonKurzy";
            this.buttonKurzy.Size = new System.Drawing.Size(88, 28);
            this.buttonKurzy.TabIndex = 4;
            this.buttonKurzy.Text = "&Kurzy ČNB";
            this.toolTipKurzy.SetToolTip(this.buttonKurzy, "Zobrazí tabulku s kurzy devizového trhu  Alt + K");
            this.buttonKurzy.UseVisualStyleBackColor = false;
            this.buttonKurzy.Click += new System.EventHandler(this.buttonKurzy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelPopisekSumaCelkem);
            this.groupBox1.Controls.Add(this.labelSumaCelkem);
            this.groupBox1.Location = new System.Drawing.Point(855, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 33);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // toolTipUlozit
            // 
            this.toolTipUlozit.AutomaticDelay = 2000;
            this.toolTipUlozit.AutoPopDelay = 5000;
            this.toolTipUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolTipUlozit.InitialDelay = 20;
            this.toolTipUlozit.IsBalloon = true;
            this.toolTipUlozit.ReshowDelay = 20;
            // 
            // toolTipVymazatRadek
            // 
            this.toolTipVymazatRadek.AutomaticDelay = 2000;
            this.toolTipVymazatRadek.AutoPopDelay = 5000;
            this.toolTipVymazatRadek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.toolTipVymazatRadek.InitialDelay = 20;
            this.toolTipVymazatRadek.IsBalloon = true;
            this.toolTipVymazatRadek.ReshowDelay = 20;
            // 
            // toolTipVymazatVse
            // 
            this.toolTipVymazatVse.AutomaticDelay = 2000;
            this.toolTipVymazatVse.AutoPopDelay = 5000;
            this.toolTipVymazatVse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolTipVymazatVse.InitialDelay = 20;
            this.toolTipVymazatVse.IsBalloon = true;
            this.toolTipVymazatVse.ReshowDelay = 20;
            // 
            // toolTipKurzy
            // 
            this.toolTipKurzy.AutomaticDelay = 2000;
            this.toolTipKurzy.AutoPopDelay = 5000;
            this.toolTipKurzy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTipKurzy.InitialDelay = 20;
            this.toolTipKurzy.IsBalloon = true;
            this.toolTipKurzy.ReshowDelay = 20;
            // 
            // HlavniFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.chartPortfolio);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "HlavniFormular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investiční portfolio";
            this.Load += new System.EventHandler(this.HlavniFormular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPortfolio)).EndInit();
            this.panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.investiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.BindingSource investiceBindingSource;
        private System.Windows.Forms.Button buttonVymazatVse;
        private System.Windows.Forms.Button buttonVymazatRadek;
        private System.Windows.Forms.Button buttonKonec;
        private System.Windows.Forms.Label labelPopisekSumaCelkem;
        private System.Windows.Forms.Label labelSumaCelkem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPortfolio;
        private System.Windows.Forms.ToolTip toolTipUlozit;
        private System.Windows.Forms.ToolTip toolTipVymazatRadek;
        private System.Windows.Forms.ToolTip toolTipVymazatVse;
        private System.Windows.Forms.Button buttonKurzy;
        private System.Windows.Forms.ToolTip toolTipKurzy;
        private System.Windows.Forms.ComboBox comboBoxProcenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPopisekSpojeniVyseci;
        private System.Windows.Forms.Label labelPopisekProcenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazev;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodnota;
        private System.Windows.Forms.DataGridViewComboBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn hodnotaKc;
    }
}

