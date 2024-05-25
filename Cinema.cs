using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Microsoft.Win32;

namespace ProvaGestioneCinemaWF
{
    public abstract class ElementoMultimediale
    {
        #region Attributi
        private string _titolo;
        private int _annoDiUscita;
        #endregion

        #region Titolo
        public string Titolo
        {
            get => _titolo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il titolo è obbligatorio.");
                _titolo = value;
            }
        }
        #endregion

        #region AnnoDiUscita
        public int AnnoDiUscita
        {
            get => _annoDiUscita;
            set
            {
                int annoCorrente = DateTime.Now.Year;
                if (value < 1800 || value > annoCorrente)
                    throw new ArgumentException($"L'anno di uscita deve essere compreso tra 1800 e {annoCorrente}.");
                _annoDiUscita = value;
            }
        }
        #endregion

        #region Costruttore
        protected ElementoMultimediale(string titolo, int annoDiUscita)
        {
            Titolo = titolo;
            AnnoDiUscita = annoDiUscita;
        }
        #endregion

        #region GetDettagli
        public virtual string GetDettagli()
        {
            return $"Titolo: {Titolo}, Anno di uscita: {AnnoDiUscita}";
        }
        #endregion
    }

    public class Cinema : ElementoMultimediale
    {
        #region Attributi
        private string _regista;
        private List<string> _attori;
        #endregion

        #region Regista
        public string Regista
        {
            get => _regista;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Il regista del film è obbligatorio.");
                if (ContieneNumeri(value))
                    throw new ArgumentException("Il nome del regista non può contenere numeri.");
                _regista = value;
            }
        }
        #endregion

        #region Attori
        public List<string> Attori
        {
            get => _attori;
            set
            {
                if (value == null || value.Count == 0 || value.Any(string.IsNullOrWhiteSpace))
                    throw new ArgumentException("La lista degli attori è obbligatoria e non può contenere valori vuoti.");
                if (value.Any(ContieneNumeri))
                    throw new ArgumentException("I nomi degli attori non possono contenere numeri.");
                _attori = value;
            }
        }
        #endregion

        #region Costruttore
        public Cinema(string titolo, string regista, List<string> attori, int annoDiUscita) : base(titolo, annoDiUscita)
        {
            Regista = regista;
            Attori = attori;
        }
        #endregion

        #region GetDettagli
        public override string GetDettagli()
        {
            // Overriding - Sovrascrivere Classe Base ElementoMultimediale.
            string dettagliBase = base.GetDettagli();
            return $"{dettagliBase}, Regista: {Regista}, Attori: {string.Join(", ", Attori)}";
        }
        #endregion

        #region ContieneNumeri
        private bool ContieneNumeri(string valore)
        {
            return valore.Any(char.IsDigit);
        }
        #endregion

        #region ModificaTitolo
        public void ModificaTitolo(string nuovoTitolo)
        {
            // Overloading - Firme diverse
            if (string.IsNullOrWhiteSpace(nuovoTitolo))
                throw new ArgumentException("Il titolo del film è obbligatorio.");
            Titolo = nuovoTitolo;
        }
        public void ModificaTitolo(string nuovoTitolo, int nuovoAnnoDiUscita)
        {
            // Overloading - Firme diverse
            if (string.IsNullOrWhiteSpace(nuovoTitolo))
                throw new ArgumentException("Il titolo del film è obbligatorio.");
            if (nuovoAnnoDiUscita < 1800 || nuovoAnnoDiUscita > 2024)
                throw new ArgumentException("L'anno di uscita deve essere compreso tra 1800 e 2024.");
            Titolo = nuovoTitolo;
            AnnoDiUscita = nuovoAnnoDiUscita;
        }
        #endregion

        #region ModificaRegista
        public void ModificaRegista(string nuovoRegista)
        {
            // Overloading - Firme diverse
            if (string.IsNullOrWhiteSpace(nuovoRegista))
                throw new ArgumentException("Il regista del film è obbligatorio.");
            Regista = nuovoRegista;
        }
        public void ModificaRegista(string nuovoRegista, int nuovoAnnoDiUscita)
        {
            // Overloading - Firme diverse
            if (string.IsNullOrWhiteSpace(nuovoRegista))
                throw new ArgumentException("Il regista del film è obbligatorio.");
            if (nuovoAnnoDiUscita < 1800 || nuovoAnnoDiUscita > 2024)
                throw new ArgumentException("L'anno di uscita deve essere compreso tra 1800 e 2024.");
            Regista = nuovoRegista;
            AnnoDiUscita = nuovoAnnoDiUscita;
        }
        #endregion

        #region ModificaAnnoDiUscita
        public void ModificaAnnoDiUscita(int nuovoAnnoDiUscita)
        {
            // Overloading - Firme diverse
            if (nuovoAnnoDiUscita < 1800 || nuovoAnnoDiUscita > 2024)
                throw new ArgumentException("L'anno di uscita deve essere compreso tra 1800 e 2024.");
            AnnoDiUscita = nuovoAnnoDiUscita;
        }
        #endregion
    }

}