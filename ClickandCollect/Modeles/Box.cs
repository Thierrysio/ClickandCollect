using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Modeles
{
    public class Box
    {

        #region Attributs
        public static List<Box> collClasseBox = new List<Box>();
        private int _id;
        private string _adresse;
        private Ville _laVille;
        private string _codePostal;
        private float _gpsX;
        private float _gpsY;
        private List<Compartiment> _lesCompartiments;
        private List<Livreur> _lesLivreurs;
        #endregion

        #region Constructeurs
        public Box(int id, string adresse, float gpsX, float gpsY, Ville laVille)
        {
            _id = id;
            _adresse = adresse;
            _gpsX = gpsX;
            _gpsY = gpsY;
            _lesLivreurs = new List<Livreur>();
            _lesCompartiments = new List<Compartiment>();
            collClasseBox.Add(this);
            _laVille = laVille;
        }
        #endregion

        #region Getters Setters
        public int Id { get => _id; set => _id = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public float GpsX { get => _gpsX; set => _gpsX = value; }
        public float GpsY { get => _gpsY; set => _gpsY = value; }
        public List<Compartiment> LesCompartiments { get => _lesCompartiments; set => _lesCompartiments = value; }
        public List<Livreur> LesLivreurs { get => _lesLivreurs; set => _lesLivreurs = value; }
        public Ville LaVille { get => _laVille; set => _laVille = value; }
        public string CodePostal { get => _codePostal; set => _codePostal = value; }
        #endregion

        #region Methodes


        #endregion
    }
}

