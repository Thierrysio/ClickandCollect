using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Modeles
{
    public class Colis
    {
        #region Attributs
        private static List<Colis> collClasseColis = new List<Colis>();
        private int _id;
        private string _etat;
        private string _volume;
        #endregion

        #region Constructeur
        public Colis(int id, string volume, string etat)
        {
            _id = id;
            Etat = etat;
            _volume = volume;
            collClasseColis.Add(this);
        }
        #endregion

        #region Getters-Setters
        internal static List<Colis> CollClasseColis { get => collClasseColis; set => collClasseColis = value; }
        public int Id { get => _id; set => _id = value; }
        public string Volume { get => _volume; set => _volume = value; }
        public string Etat { get => _etat; set => _etat = value; }
        #endregion

        #region Méthodes

        public string GetEtat()
        {
            string result = "";
            return result;
        }
        #endregion

    }
}
