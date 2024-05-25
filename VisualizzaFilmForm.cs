using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGestioneCinemaWF
{
    public partial class VisualizzaFilmForm : Form
    {
        #region Proprietà
        public string Titolo { get; private set; }
        public string Regista { get; private set; }
        public int Anno { get; private set; }
        public List<string> Attori { get; private set; }
        #endregion

        #region Costruttore
        public VisualizzaFilmForm(string titolo, string regista, int anno, List<string> attori)
        {
            InitializeComponent();

            Titolo = titolo;
            Regista = regista;
            Anno = anno;
            Attori = attori;

            PopolaCampi(titolo, regista, anno);
            AggiornaDataGridViewAttori(attori);
        }
        #endregion

        #region VisualizzaFilmForm_Load
        private void VisualizzaFilmForm_Load(object sender, EventArgs e)
        {
            // Caselle di testo non modificabili
            txtTitoloV.ReadOnly = true;
            txtRegistaV.ReadOnly = true;
            txtAnnoV.ReadOnly = true;
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
            txtTitoloV.Text = titolo;
            txtRegistaV.Text = regista;
            txtAnnoV.Text = anno.ToString();

            //Cinema cinema = new Cinema(titolo, regista, new List<string>(), anno);
            //lbToString.Text = cinema.GetDettagli();

            lbToString.Text = $"{titolo}, diretto da {regista}, uscito nel {anno}";
        }
        #endregion
    }
}
