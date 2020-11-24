using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Modeles
{
    public class Compartiment
    {

            #region Attributs
            private static List<Compartiment> collClassCompartiment = new List<Compartiment>();

            private int _idCompartiment;
            private int _positionX;
            private int _positionY;
            private Box _leBox;
            private List<Colis> _lesColis;
            #endregion

            #region Constructeur
            public Compartiment(int idCompartiment, int positionX, int positionY, Box leBox)
            {
                this._idCompartiment = idCompartiment;
                this._positionY = positionY;
                this._positionX = positionX;
                _leBox = leBox;
                _lesColis = new List<Colis>();
                CollClassCompartiment.Add(this);
            }
            #endregion

            #region Get-Set
            public static List<Compartiment> CollClassCompartiment { get => collClassCompartiment; set => collClassCompartiment = value; }
            public int PositionX { get => _positionX; set => _positionX = value; }
            public int PositionY { get => _positionY; set => _positionY = value; }
            public int IdCompartiment { get => _idCompartiment; set => _idCompartiment = value; }
            public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }
            #endregion

            #region Methode
            #endregion

        }

    }

