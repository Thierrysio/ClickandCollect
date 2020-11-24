using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Modeles
{
    public class Individuel : Client
    {
        #region Attributs
        private int _coupon;
        #endregion

        #region Constructeurs
        public Individuel(int coupon, string leNom, int id, string lePrenom, string Ladresse, Ville laVille, float coordonneX, float coordonneY)
            : base(id, leNom, lePrenom, Ladresse, laVille, coordonneX, coordonneY)
        {
            _coupon = coupon;
        }
        #endregion

        #region Getters Setters
        public int Coupon { get => _coupon; set => _coupon = value; }
        #endregion

        #region Methodes
        #endregion
    }

}
