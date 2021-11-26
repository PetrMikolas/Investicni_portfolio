using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Portfolio {
    public partial class Kurzy : Form {

        // Cesta ke složce InvesticniPortfolio
        static string pathSlozkaInvesticniPortfolio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "InvesticniPortfolio");

        // Cesta k souboru Kurzy.txt
        static string pathSouborKurzy = $"{pathSlozkaInvesticniPortfolio}{Path.DirectorySeparatorChar}Kurzy.txt";

        // Datové složky
        public string Mnozstvi { get; set; }
        public string KodMeny { get; set; }
        public string Kurz { get; set; }
        public List<Kurzy> KurzovniListek { get; set; } = new List<Kurzy>();

        // Konstruktor
        public Kurzy(string Mnozstvi, string KodMeny, string Kurz) {
            this.Mnozstvi = Mnozstvi;
            this.KodMeny = KodMeny;
            this.Kurz = Kurz;
        }

        public Kurzy() {
            InitializeComponent();
        }
              
        /// <summary>
        /// Stáhne z API České národní banky aktuální kurzy devizového trhu
        /// </summary>
        public void stahniKurzy() {
            try {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://www.cnb.cz/cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.txt", pathSouborKurzy);
            }
            catch (WebException) { MessageBox.Show("Nepodařilo se připojit k serveru ČNB\n\nZkontrolujte své připojení k internetu", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Načte stáhnuté kurzy do kolekce List a DataGridView
        /// </summary>
        public void nactiKurzy() {
            try {
                using (StreamReader sr = new StreamReader(pathSouborKurzy)) {
                    string radek = sr.ReadLine();                   // načte data 1. řádku tabulky
                    string[] datum = radek.Split('#');
                    labelDatum.Text = datum[0];                     // zobrazí datum z 1. řádku
                    radek = sr.ReadLine();                          // načte data 2. řádku tabulky
                    while ((radek = sr.ReadLine()) != null) {       // načte data od 3. řádku tabulky až k poslednímu řádku
                        string[] bunkyRadku = radek.Split('|');

                        // načte data do kolekce List
                        KurzovniListek.Add(new Kurzy(bunkyRadku[2], bunkyRadku[3], bunkyRadku[4]));
                        
                        // načte data do DataGridView
                        DataGridViewRow novyRadek = new DataGridViewRow();
                        novyRadek.CreateCells(dataGridViewKurzy);
                        for (int i = 0; i < bunkyRadku.Length; i++) {
                            novyRadek.Cells[i].Value = bunkyRadku[i].ToString();
                        }
                        dataGridViewKurzy.Rows.Add(novyRadek);
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("Nebyl stažen soubor s kurzy", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}





