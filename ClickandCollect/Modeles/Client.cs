using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Modeles
{
    public abstract class Client
    {
        #region Attributs
        public static List<Client> CollClasseClient = new List<Client>();
        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private Ville _laVille;
        private float _coordonneesX;
        private float _coordonneesY;

        private List<Colis> _lesColis;


        #endregion
        #region Constructeurs
        protected Client(int id, string nom, string prenom, string adresse, Ville laVille, float coordonneesX, float coordonneesY)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            _laVille = laVille;
            _lesColis = new List<Colis>();
            Client.CollClasseClient.Add(this);
            _coordonneesX = coordonneesX;
            _coordonneesY = coordonneesY;
        }
        #endregion
        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public Ville LaVille { get => _laVille; set => _laVille = value; }
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }
        public float CoordonneesX { get => _coordonneesX; set => _coordonneesX = value; }
        public float CoordonneesY { get => _coordonneesY; set => _coordonneesY = value; }


        #endregion
        #region Methodes
        #endregion
    }
}
