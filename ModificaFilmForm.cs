using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGestioneCinemaWF
{
    public partial class ModificaFilmForm : Form
    {
        #region Variabili
        private bool modificheSalvate = false;
        private FilmController filmController;
        #endregion

        #region Proprietà
        public string Titolo { get; private set; }
        public string Regista { get; private set; }
        public int Anno { get; private set; }
        public List<string> Attori { get; private set; }
        #endregion

        #region Costruttori
        public ModificaFilmForm()
        {
            // Overloading - Costruttore senza parametri
            InitializeComponent();

            Titolo = "";
            Regista = "";
            Anno = DateTime.Now.Year;
            Attori = new List<string>();
        }

        public ModificaFilmForm(FilmController controller)
        {
            // Overloading - Costruttore 
            InitializeComponent();
            this.filmController = controller;
        }

        public ModificaFilmForm(FilmController controller, string titolo, string regista, int anno, List<string> attori)
        {
            // Overloading - Costruttore 
            InitializeComponent();

            this.filmController = controller;
            Titolo = titolo;
            Regista = regista;
            Anno = anno;
            Attori = attori;
        }
        #endregion

        #region OnLoad
        protected override void OnLoad(EventArgs e)
        {
            // Overriding - Sovrascrivere Classe Base Form.
            base.OnLoad(e);

            txtTitoloM.Text = Titolo;
            txtRegistaM.Text = Regista;
            txtAnnoM.Text = Anno.ToString();
            AggiornaDataGridViewAttori(Attori);
        }
        #endregion

        #region OnFormClosing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Overriding - Sovrascrivere Classe Base Form.
            base.OnFormClosing(e);

            if (!modificheSalvate)
            {
                MessageBox.Show("Non hai salvato le modifiche. \nClicca sul pulsante 'Salva Modifiche' per salvare.", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        #endregion

        #region ContieneNumeri
        private bool ContieneNumeri(string valore)
        {
            return valore.Any(char.IsDigit);
        }
        #endregion

        #region AggiornaDataGridViewAttori
        private void AggiornaDataGridViewAttori(List<string> attori)
        {
            dataGridViewAttori.Rows.Clear();
            foreach (var attore in attori)
            {
                dataGridViewAttori.Rows.Add(attore);
            }
        }
        #endregion

        #region PopolaCampi
        public void PopolaCampi(string titolo, string regista, int anno)
        {
            txtTitoloM.Text = titolo;
            txtRegistaM.Text = regista;
            txtAnnoM.Text = anno.ToString();
        }
        #endregion

        #region btnSalvaModifiche_Click
        private void btnSalvaModifiche_Click(object sender, EventArgs e)
        {
            try
            {
                Titolo = txtTitoloM.Text;
                Regista = txtRegistaM.Text;
                Anno = Convert.ToInt32(txtAnnoM.Text);

                List<string> attoriModificati = new List<string>();
                foreach (DataGridViewRow row in dataGridViewAttori.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        attoriModificati.Add(row.Cells[0].Value.ToString());
                    }
                }
                Attori = attoriModificati;

                if (string.IsNullOrWhiteSpace(Titolo))
                    throw new ArgumentException("Il titolo del film è obbligatorio.");
                if (Anno < 1800 || Anno > DateTime.Now.Year)
                    throw new ArgumentException($"L'anno di uscita deve essere compreso tra 1800 e {DateTime.Now.Year}.");
                if (string.IsNullOrWhiteSpace(Regista))
                    throw new ArgumentException("Il regista del film è obbligatorio.");
                if (ContieneNumeri(Regista))
                    throw new ArgumentException("Il nome del regista non può contenere numeri.");
                if (Attori == null || Attori.Count == 0 || Attori.Any(string.IsNullOrWhiteSpace))
                    throw new ArgumentException("La lista degli attori è obbligatoria e non può contenere valori vuoti.");
                if (Attori.Any(ContieneNumeri))
                    throw new ArgumentException("I nomi degli attori non possono contenere numeri.");

                modificheSalvate = true;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Errore di validazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato anno non valido.", "Errore di validazione", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore durante il salvataggio delle modifiche: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnAggiungiAttore_Click
        private void btnAggiungiAttore_Click(object sender, EventArgs e)
        {
            string nuovoAttore = Interaction.InputBox("Inserisci il nome dell'attore:", "Nuovo Attore", "");

            if (!string.IsNullOrEmpty(nuovoAttore))
            {
                Attori.Add(nuovoAttore);
                AggiornaDataGridViewAttori(Attori);
            }
        }
        #endregion

        #region btnRimuoviAttore_Click
        private void btnRimuoviAttore_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttori.SelectedRows.Count > 0)
            {
                Attori.RemoveAt(dataGridViewAttori.SelectedRows[0].Index);
                AggiornaDataGridViewAttori(Attori);
            }
            else
            {
                MessageBox.Show("Seleziona un attore da rimuovere.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region btnModificaAttore_Click
        private void btnModificaAttore_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttori.SelectedRows.Count > 0)
            {
                int indiceRiga = dataGridViewAttori.SelectedRows[0].Index;

                string attoreSelezionato = dataGridViewAttori.Rows[indiceRiga].Cells[0].Value.ToString();
                string nuovoNomeAttore = Interaction.InputBox("Modifica il nome dell'attore:", "Modifica Attore", attoreSelezionato);

                if (!string.IsNullOrEmpty(nuovoNomeAttore))
                {
                    //dataGridViewAttori.Rows[indiceRiga].Cells[0].Value = nuovoNomeAttore;
                    Attori.Add(nuovoNomeAttore);
                    Attori.Remove(attoreSelezionato);
                    AggiornaDataGridViewAttori(Attori);
                }
            }
            else
            {
                MessageBox.Show("Seleziona un attore da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}