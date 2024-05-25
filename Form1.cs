using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.Numerics;

namespace ProvaGestioneCinemaWF
{
    public partial class Form1 : Form
    {
        #region Variabili
        private string filePath = "cinema.json";
        private FilmController filmController;
        #endregion

        #region Costruttore
        public Form1()
        {
            InitializeComponent();

            // Evento di chiusura del form
            this.FormClosing += Form1_FormClosing;
        }
        #endregion

        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            filmController = new FilmController();

            // Carica File JSON
            bool success = filmController.CaricaDaFile(filePath);
            if (!success)
            {
                MessageBox.Show("Errore durante il caricamento dei dati. Creazione di un nuovo elenco...", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AggiornaDataGridViewCinema();
        }
        #endregion

        #region AggiornaDataGridViewCinema
        private void AggiornaDataGridViewCinema()
        {
            dataGridView1.Rows.Clear();

            foreach (var film in filmController.ElencoFilm)
            {
                AggiungiFilmDataGridView(film.Titolo, film.Regista, film.AnnoDiUscita, film.Attori);
            }
        }
        #endregion

        #region AggiungiFilmDataGridView
        private void AggiungiFilmDataGridView(string titolo, string regista, int annoUscita, List<string> attori)
        {
            dataGridView1.Rows.Add(titolo, regista, annoUscita, string.Join(", ", attori));
        }
        #endregion

        #region btnAggiungi_Click
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                string titolo = txtTitolo.Text;
                string regista = txtRegista.Text;
                int annoUscita = Convert.ToInt32(txtAnno.Text);
                List<string> attori = new List<string>();

                // Finestra di Dialogo - Attori
                int numAttori = Convert.ToInt32(txtNumAttori.Text);
                for (int i = 0; i < numAttori; i++)
                {
                    string attore = Interaction.InputBox($"Inserisci il nome dell'attore {i + 1}:", "Inserimento Attore", "");
                    attori.Add(attore);
                }

                filmController.AggiungiFilm(new Cinema(titolo, regista, attori, annoUscita));

                AggiornaDataGridViewCinema();

                MessageBox.Show("Film aggiunto con successo!", "Aggiungi Film", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'aggiunta del film: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnPulisci_Click
        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtTitolo.Text = "";
            txtRegista.Text = "";
            txtAnno.Text = "";
            txtNumAttori.Text = "";
        }
        #endregion

        #region btnModifica_Click
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indiceRiga = dataGridView1.SelectedRows[0].Index;

                string titolo = dataGridView1.Rows[indiceRiga].Cells["Titolo"].Value.ToString();
                string regista = dataGridView1.Rows[indiceRiga].Cells["Regista"].Value.ToString();
                int annoUscita = Convert.ToInt32(dataGridView1.Rows[indiceRiga].Cells["Anno"].Value);
                List<string> attori = dataGridView1.Rows[indiceRiga].Cells["Attori"].Value.ToString().Split(',').ToList();

                // Form di Modifica
                ModificaFilmForm modificaFilmForm = new ModificaFilmForm(filmController, titolo, regista, annoUscita, attori);
                if (modificaFilmForm.ShowDialog() == DialogResult.OK)
                {
                    // Aggiornamento Dati Film con quelli modificati
                    filmController.GetFilmByIndex(indiceRiga).Titolo = modificaFilmForm.Titolo;
                    filmController.GetFilmByIndex(indiceRiga).Regista = modificaFilmForm.Regista;
                    filmController.GetFilmByIndex(indiceRiga).AnnoDiUscita = modificaFilmForm.Anno;
                    filmController.GetFilmByIndex(indiceRiga).Attori = modificaFilmForm.Attori;

                    AggiornaDataGridViewCinema();

                    MessageBox.Show("Modifiche salvate con successo!", "Modifica Film", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleziona una riga da modificare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnVisualizza_Click
        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indiceRiga = dataGridView1.SelectedRows[0].Index;

                string titolo = dataGridView1.Rows[indiceRiga].Cells["Titolo"].Value.ToString();
                string regista = dataGridView1.Rows[indiceRiga].Cells["Regista"].Value.ToString();
                int annoUscita = Convert.ToInt32(dataGridView1.Rows[indiceRiga].Cells["Anno"].Value);
                List<string> attori = dataGridView1.Rows[indiceRiga].Cells["Attori"].Value.ToString().Split(',').ToList();

                // Form di Visualizza
                VisualizzaFilmForm visualizzaFilmForm = new VisualizzaFilmForm(titolo, regista, annoUscita, attori);
                visualizzaFilmForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleziona una riga da visualizzare dettagli del film.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnElimina_Click
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    filmController.EliminaFilm(row.Index);

                    AggiornaDataGridViewCinema();
                }
            }
            else
            {
                MessageBox.Show("Errore: Devi selezionare almeno una riga da rimuovere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnSalva_Click
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                filmController.SalvaSuFile(filePath);
                MessageBox.Show("Elenco film salvato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il salvataggio dell'elenco film: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region btnEsci_Click
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Form1_FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Vuoi salvare i dati prima di uscire?", "Conferma Uscita", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    filmController.SalvaSuFile(filePath);
                    MessageBox.Show("Elenco film salvato con successo.", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il salvataggio dell'elenco film: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.Cancel)
            {
                // Annulla la chiusura
                e.Cancel = true;
            }
        }
        #endregion
    }
}