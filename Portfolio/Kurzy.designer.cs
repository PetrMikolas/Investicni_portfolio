
namespace Portfolio {
    partial class Kurzy {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kurzy));
            this.dataGridViewKurzy = new System.Windows.Forms.DataGridView();
            this.zeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnozstvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPopisek = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurzy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKurzy
            // 
            this.dataGridViewKurzy.AllowUserToDeleteRows = false;
            this.dataGridViewKurzy.AllowUserToResizeColumns = false;
            this.dataGridViewKurzy.AllowUserToResizeRows = false;
            this.dataGridViewKurzy.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewKurzy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKurzy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKurzy.ColumnHeadersHeight = 25;
            this.dataGridViewKurzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKurzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zeme,
            this.mena,
            this.mnozstvi,
            this.kod,
            this.kurz});
            this.dataGridViewKurzy.Location = new System.Drawing.Point(17, 27);
            this.dataGridViewKurzy.Name = "dataGridViewKurzy";
            this.dataGridViewKurzy.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKurzy.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewKurzy.RowHeadersVisible = false;
            this.dataGridViewKurzy.RowHeadersWidth = 30;
            this.dataGridViewKurzy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKurzy.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewKurzy.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewKurzy.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewKurzy.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKurzy.RowTemplate.ReadOnly = true;
            this.dataGridViewKurzy.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKurzy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewKurzy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKurzy.Size = new System.Drawing.Size(353, 751);
            this.dataGridViewKurzy.TabIndex = 1;
            // 
            // zeme
            // 
            this.zeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.zeme.DefaultCellStyle = dataGridViewCellStyle2;
            this.zeme.FillWeight = 60F;
            this.zeme.HeaderText = "Země";
            this.zeme.Name = "zeme";
            this.zeme.ReadOnly = true;
            this.zeme.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.zeme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.zeme.Width = 110;
            // 
            // mena
            // 
            this.mena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mena.FillWeight = 60F;
            this.mena.HeaderText = "Měna";
            this.mena.Name = "mena";
            this.mena.ReadOnly = true;
            this.mena.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mena.Width = 70;
            // 
            // mnozstvi
            // 
            this.mnozstvi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.mnozstvi.DefaultCellStyle = dataGridViewCellStyle3;
            this.mnozstvi.HeaderText = "Množství";
            this.mnozstvi.Name = "mnozstvi";
            this.mnozstvi.ReadOnly = true;
            this.mnozstvi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mnozstvi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mnozstvi.Width = 60;
            // 
            // kod
            // 
            this.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kod.DefaultCellStyle = dataGridViewCellStyle4;
            this.kod.HeaderText = "Kód";
            this.kod.Name = "kod";
            this.kod.ReadOnly = true;
            this.kod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kod.Width = 50;
            // 
            // kurz
            // 
            this.kurz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.kurz.DefaultCellStyle = dataGridViewCellStyle5;
            this.kurz.HeaderText = "Kurz";
            this.kurz.Name = "kurz";
            this.kurz.ReadOnly = true;
            this.kurz.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kurz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kurz.Width = 62;
            // 
            // labelPopisek
            // 
            this.labelPopisek.AutoSize = true;
            this.labelPopisek.Location = new System.Drawing.Point(17, 7);
            this.labelPopisek.Name = "labelPopisek";
            this.labelPopisek.Size = new System.Drawing.Size(71, 13);
            this.labelPopisek.TabIndex = 2;
            this.labelPopisek.Text = "Kurzy ze dne:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(89, 7);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(0, 13);
            this.labelDatum.TabIndex = 3;
            // 
            // FormularKurzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(386, 794);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelPopisek);
            this.Controls.Add(this.dataGridViewKurzy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularKurzy";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kurzy devizového trhu - Česká národní banka";            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurzy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPopisek;
        private System.Windows.Forms.Label labelDatum;
        public System.Windows.Forms.DataGridView dataGridViewKurzy;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn mena;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnozstvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurz;
    }
}

