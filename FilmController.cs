using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProvaGestioneCinemaWF
{
    [Serializable]
    public class FilmController
    {
        #region ElencoFilm
        public List<Cinema> ElencoFilm { get; set; }
        #endregion

        #region Costruttore
        public FilmController()
        {
            ElencoFilm = new List<Cinema>();
        }
        #endregion

        #region AggiungiFilm
        public void AggiungiFilm(Cinema film)
        {
            foreach (var f in ElencoFilm)
            {
                if (string.Equals(f.Titolo, film.Titolo, StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException("Il film esiste già nell'elenco.");
                }
            }
            ElencoFilm.Add(film);
        }
        #endregion

        #region GetFilmByIndex
        public Cinema GetFilmByIndex(int index)
        {
            if (index >= 0 && index < ElencoFilm.Count)
            {
                return ElencoFilm[index];
            }
            return null;
        }
        #endregion

        #region EliminaFilm
        public void EliminaFilm(int index)
        {
            if (index >= 0 && index < ElencoFilm.Count)
            {
                ElencoFilm.RemoveAt(index);
            }
        }
        #endregion

        #region GetNumeroFilm
        public int GetNumeroFilm()
        {
            return ElencoFilm.Count;
        }
        #endregion

        #region SalvaSuFile
        public void SalvaSuFile(string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string datiJson = JsonSerializer.Serialize(ElencoFilm, options);
                File.WriteAllText(filePath, datiJson);

                Console.WriteLine("Dati salvati con successo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante il salvataggio dei dati: {ex.Message}");
            }
        }
        #endregion

        #region CaricaDaFile
        public bool CaricaDaFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string datiJson = File.ReadAllText(filePath);
                    ElencoFilm = JsonSerializer.Deserialize<List<Cinema>>(datiJson);
                    Console.WriteLine("Dati caricati con successo!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Il file non esiste. Creazione di un nuovo elenco...");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante il caricamento dei dati: {ex.Message}");
                return false;
            }
        }
        #endregion
    }
}