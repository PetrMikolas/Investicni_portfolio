using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Portfolio {
    public partial class HlavniFormular : Form {

        // Instance třídy Kurzy
        Kurzy kurzy = new Kurzy();

        // Cesta ke složce InvesticniPortfolio
        static string pathSlozkaInvesticniPortfolio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "InvesticniPortfolio");

        // Cesta k souboru XML
        static string pathSouborXml = $"{pathSlozkaInvesticniPortfolio}{Path.DirectorySeparatorChar}Data.xml";

        // Datové složky
        public string Nazev { get; set; }
        public int Hodnota { get; set; }
        public string Kod { get; set; }
        public string TrimmedValue { get; set; }
        public bool PlatnyFormat { get; set; } = true;
        public bool RadekOznacen { get; set; }
        public bool ZmenaHodnot { get; set; }

        public HlavniFormular() {
            InitializeComponent();
            comboBoxProcenta.SelectedIndex = 0;
        }

        private void HlavniFormular_Load(object sender, EventArgs e) {
            vytvorSouborXml();
            kurzy.stahniKurzy();
            kurzy.nactiKurzy();
            nactiXml();
            smenNaKc();
            sectiKc();
            zobrazGraf();
        }

        /// <summary>
        /// Vytvoří soubor XML pro uložení dat
        /// </summary>
        private void vytvorSouborXml() {
            if (!Directory.Exists(pathSlozkaInvesticniPortfolio)) {
                Directory.CreateDirectory(pathSlozkaInvesticniPortfolio);
            }

            if (!File.Exists(pathSouborXml)) {
                using (StreamWriter sw = new StreamWriter(pathSouborXml)) {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw.WriteLine("<Portfolio />");
                }
            }
        }

        /// <summary>
        /// Očísluje záhlaví řádků
        /// </summary>
        private void ocislujRadky() {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++) {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                dataGridView.Rows[i].HeaderCell.Style.BackColor = Color.FromArgb(192, 255, 192);
            }
        }

        // Při stisku klávesy volá funkci Control_KeyPress (událost KeyPress bez zavolání nefunguje správně!)
        private void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        // Při stisku klávesy validuje ve sloupci s indexem 1 celá kladná čísla 
        private void Control_KeyPress(object sender, KeyPressEventArgs e) {
            if (dataGridView.CurrentCell.ColumnIndex == 1) {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                    e.Handled = true;
                }
            }
        }

        // nastaví v combo boxu defaltní hodnotu na CZK
        private void dataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e) {
            e.Row.Cells["kod"].Value = "CZK";
        }

        // při každé změně dat z klávesnice provede změny, viz kody v metodě
        private void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            ZmenaHodnot = true;

            // změní text a barvu v záhlaví řádků, ve kterých došlo ke změně hodnot
            dataGridView.Rows[dataGridView.CurrentCell.RowIndex].HeaderCell.Style.BackColor = Color.Orange;
            dataGridView.Rows[dataGridView.CurrentCell.RowIndex].HeaderCell.Value = null;

            // změní barvu a písmo tlačítka Uložit
            buttonUlozit.BackColor = Color.Orange;
            buttonUlozit.Font = new Font("Microsoft Sans Serif", 12F);

            // při změně hodnot v Combo boxu zavolá metodu smenNaKc
            if (dataGridView.CurrentCell is DataGridViewComboBoxCell) {
                smenNaKc();
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            // při změně hodnot ve sloupci s indexem 1 zavolá metodu smenNaKc
            if (dataGridView.CurrentCell is DataGridViewTextBoxCell && dataGridView.CurrentCell.ColumnIndex == 1) {
                smenNaKc();
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // Formátuje obsah buňky na celá čísla s oddělovačem tisíců     
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 1 && e.RowIndex != dataGridView.NewRowIndex || e.ColumnIndex == 3 && e.RowIndex != dataGridView.NewRowIndex) {
                smenNaKc();
                if (dataGridView.Rows[e.RowIndex].Cells[1].Value != null && dataGridView.Rows[e.RowIndex].Cells[3].Value != null) {
                    TrimmedValue = string.Concat(e.Value.ToString().Where(c => !char.IsWhiteSpace(c)));  // musí být pro případ, kdy uživatel edituje již dříve zadaná čísla a po editaci nechá mezi čísly oddělovač tisíců
                    if (!int.TryParse(TrimmedValue.ToString(), out int number)) {                        // TryParse musí být pro přídap, kdy uživatel při editaci již dříve zadaných čísel číslo vymaže a buňku nechá prázdnou
                        e.Value = null;
                    }
                    else {
                        e.Value = number.ToString("N0");
                    }
                }
            }
        }

        // tabulátor přeskakuje sloupec s indexem 2, který je pouze na čtení
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Tab && dataGridView.CurrentCell.ColumnIndex == 2 && dataGridView.CurrentCell.RowIndex < dataGridView.Rows.Count - 1) {
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex + 1].Cells[0];
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Načte data z uloženého XML souboru
        /// </summary>
        private void nactiXml() {
            using (XmlReader xr = XmlReader.Create(pathSouborXml)) {
                string nazev = string.Empty;
                int hodnota = 0;
                string kod = string.Empty;
                string element = string.Empty;
                try {
                    while (xr.Read()) {

                        // načítá element
                        if (xr.NodeType == XmlNodeType.Element) {
                            element = xr.Name; // název aktuálního elementu
                        }

                        // načítá hodnotu elementu
                        else if (xr.NodeType == XmlNodeType.Text) {
                            switch (element) {
                                case "Nazev":
                                    nazev = xr.Value;
                                    break;
                                case "Hodnota":
                                    hodnota = int.Parse(xr.Value);
                                    break;
                                case "Kod":
                                    kod = xr.Value;
                                    break;
                            }
                        }

                        // načítá konec elementu
                        else if ((xr.NodeType == XmlNodeType.EndElement) && (xr.Name == "Investice")) {

                            // zapisuje hodnoty do buněk DataGridView
                            DataGridViewRow novyRadek = new DataGridViewRow();
                            novyRadek.CreateCells(dataGridView);
                            novyRadek.Cells[0].Value = nazev;
                            novyRadek.Cells[1].Value = hodnota.ToString();
                            novyRadek.Cells[2].Value = kod;
                            dataGridView.Rows.Add(novyRadek);
                        }
                    }
                }
                catch (XmlException) { MessageBox.Show("Chybí kořenový element", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            ocislujRadky();
        }

        /// <summary>
        /// Uloží data do XML souboru
        /// </summary>
        private void ulozXml() {
            if (ZmenaHodnot) {

                int i = 0; int j = 0;

                // nastavení XMLWriteru
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                try {
                    using (XmlWriter xw = XmlWriter.Create(pathSouborXml, settings)) {
                        xw.WriteStartDocument();            // hlavička
                        xw.WriteStartElement("Portfolio");  // otevření kořenového elementu

                        for (i = 0; i < dataGridView.Rows.Count - 1; i++) {
                            j = 0; Nazev = dataGridView.Rows[i].Cells[0].Value.ToString();
                            j = 1; TrimmedValue = string.Concat(dataGridView.Rows[i].Cells[1].Value.ToString().Where(c => !char.IsWhiteSpace(c)));  // musí být pro případ, kdy uživatel edituje již dříve zadaná čísla a po editaci nechá mezi čísly oddělovač tisíců
                            Hodnota = int.Parse(TrimmedValue);
                            j = 2; Kod = dataGridView.Rows[i].Cells[2].Value.ToString();
                            xw.WriteStartElement("Investice");
                            xw.WriteElementString("Nazev", Nazev);
                            xw.WriteElementString("Hodnota", Hodnota.ToString());
                            xw.WriteElementString("Kod", Kod);
                            xw.WriteEndElement();
                        }
                        xw.WriteEndElement();   // uzavření kořenového elementu
                        xw.WriteEndDocument();  // konec dokument
                        xw.Flush();
                    }
                }
                catch (NullReferenceException) { PlatnyFormat = false; dataGridView[j, i].Style.BackColor = Color.Red; MessageBox.Show("Před uložením musí být vyplněny všechny buňky řádku", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); dataGridView[j, i].Style.BackColor = Color.White; }
                catch (FormatException) { PlatnyFormat = false; dataGridView[j, i].Style.BackColor = Color.Red; MessageBox.Show("Před uložením musí být vyplněny všechny buňky řádku", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); dataGridView[j, i].Style.BackColor = Color.White; }

                if (PlatnyFormat) {
                    sectiKc();
                    zobrazGraf();
                    ocislujRadky();
                    buttonUlozit.BackColor = Color.FromArgb(192, 255, 192);
                    buttonUlozit.Font = new Font("Microsoft Sans Serif", 8.25F);
                    ZmenaHodnot = false;
                    MessageBox.Show("Data byla uložena", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PlatnyFormat = true;    // musí být až na konci metody            
            }
        }

        /// <summary>
        /// Sečte hodnotu investic v Kč
        /// </summary>
        private void sectiKc() {
            int sumaCelkem = 0;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++) {
                if (dataGridView.Rows[i].Cells[3].Value != null) {
                    sumaCelkem += int.Parse(dataGridView.Rows[i].Cells[3].Value.ToString());
                }
            }
            labelSumaCelkem.Text = sumaCelkem.ToString("# ### ##0 Kč");
        }

        /// <summary>
        /// Zobrazí výsečový graf
        /// </summary>
        private void zobrazGraf() {
            chartPortfolio.Series["Investice"].Points.Clear();
            try {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++) {
                    chartPortfolio.Series["Investice"].Points.AddXY(i, dataGridView.Rows[i].Cells[3].Value);
                    chartPortfolio.Series["Investice"].Points[i].LegendText = dataGridView.Rows[i].Cells[0].Value.ToString() + " (#PERCENT{P1})";
                }
            }
            catch (FormatException) { MessageBox.Show("Před uložením musí být vyplněny všechny buňky řádku", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (NullReferenceException) { MessageBox.Show("Nejsou vyplněny všechny údaje pro zobrazení grafu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Přepočte cízí měnu na Kč
        /// </summary>
        private void smenNaKc() {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++) {
                string kodMenyPortfolio = dataGridView.Rows[i].Cells[2].Value.ToString();

                if (kodMenyPortfolio == "CZK") {
                    dataGridView.Rows[i].Cells[3].Value = dataGridView.Rows[i].Cells[1].Value;
                }
                foreach (Kurzy polozka in kurzy.KurzovniListek) {
                    string kodMenyKurzy = polozka.KodMeny;
                    if (kodMenyPortfolio == kodMenyKurzy) {
                        if (dataGridView.Rows[i].Cells[1].Value != null) {
                            TrimmedValue = string.Concat(dataGridView.Rows[i].Cells[1].Value.ToString().Where(c => !char.IsWhiteSpace(c)));  // musí být pro případ, kdy uživatel edituje již dříve zadaná čísla a po editaci nechá mezi čísly oddělovač tisíců
                            int deviza = int.Parse(TrimmedValue);
                            int mnozstvi = int.Parse(polozka.Mnozstvi);
                            double kurzCnb = double.Parse(polozka.Kurz);
                            double hodnotaKc = Math.Round(deviza / mnozstvi * kurzCnb);
                            dataGridView.Rows[i].Cells[3].Value = hodnotaKc.ToString();
                        }
                        else {
                            dataGridView.Rows[i].Cells[3].Value = null;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Vymaže všechna data z tabulky
        /// </summary>
        private void vymazVse() {
            DialogResult result = MessageBox.Show("Opravdu chceš vymazat všechny údaje?", "Varování", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                dataGridView.Rows.Clear();
                ZmenaHodnot = true;
                ulozXml();
                sectiKc();
                zobrazGraf();
            }
        }

        /// <summary>
        /// Vymaže data pouze z vybraných řádků v tabulce
        /// </summary>
        private void vymazRadek() {
            if (RadekOznacen) {
                DialogResult result = MessageBox.Show("Opravdu chceš vymazat vybrané řádky?", "Varování", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                try {
                    if (result == DialogResult.Yes) {
                        foreach (DataGridViewRow item in dataGridView.SelectedRows) {
                            dataGridView.Rows.RemoveAt(item.Index);
                        }
                        ZmenaHodnot = true;
                        ulozXml();
                        sectiKc();
                        zobrazGraf();
                        ocislujRadky();
                    }
                }
                catch (InvalidOperationException) { MessageBox.Show("Poslední řádek nelze odstranit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }

        // při kliknutí na záhlaví řádku se změní barva vybraného záhlaví na žlutou barvu a datová složka RedekOznacen se nastaví na true, aby se aktivovala funkce vymazRadek
        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            dataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 160);
            dataGridView.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            RadekOznacen = true;
        }

        // když uživatel klikne do buňky v tabulce, tak se datová složka RadekOznacen nastaví na false, aby se deaktivovala funkce vymazRadek
        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e) {
            RadekOznacen = false;
        }

        /// <summary>
        /// Umožní uživateli nastavit hodnotu pro spojení výsečí grafu v rozsahu 0 - 5 %
        /// </summary>
        private void spojVyseceGrafu() {
            string hodnota = comboBoxProcenta.Text.ToString();
            switch (hodnota) {
                case "0":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=0, Colle" + "ctedLegendText=";
                    break;
                case "1":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=1, Colle" + "ctedLegendText=ostatní (< 1 %)";
                    break;
                case "2":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=2, Colle" + "ctedLegendText=ostatní (< 2 %)";
                    break;
                case "3":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=3, Colle" + "ctedLegendText=ostatní (< 3 %)";
                    break;
                case "4":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=4, Colle" + "ctedLegendText=ostatní (< 4 %)";
                    break;
                case "5":
                    chartPortfolio.Series["Investice"].CustomProperties = "PieDrawingStyle=Concave, CollectedThreshold=5, Colle" + "ctedLegendText=ostatní (< 5 %)";
                    break;
            }
        }

        // naformátuje barvu rámečku u panelu
        private void panel_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }

        private void buttonUlozit_Click(object sender, EventArgs e) {
            ulozXml();
        }

        private void buttonVymazatRadek_Click(object sender, EventArgs e) {
            vymazRadek();
        }

        private void buttonVymazatVse_Click(object sender, EventArgs e) {
            vymazVse();
        }

        private void buttonKonec_Click(object sender, EventArgs e) {
            Close();
        }

        // stáhne aktuální kurzy ČNB, zavolá metody které pracují s kurzy a zobrazí formulář s kurzy
        private void buttonKurzy_Click(object sender, EventArgs e) {
            kurzy.dataGridViewKurzy.Rows.Clear(); // z dataDridView se vymažou původní hodnoty načtené při spuštění programu
            kurzy.stahniKurzy();
            kurzy.nactiKurzy();
            smenNaKc();
            sectiKc();                            // sečtou se aktualní hodnoty v Kč
            zobrazGraf();                         // zobrazí se graf s aktuálními hodnotami v Kč
            kurzy.ShowDialog();
        }

        private void comboBoxProcenta_SelectedIndexChanged(object sender, EventArgs e) {
            spojVyseceGrafu();
        }
    }
}



