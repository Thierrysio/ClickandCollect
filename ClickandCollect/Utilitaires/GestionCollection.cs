using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Utilitaires
{
    class GestionCollection
    {
        public static int GetNouvelIndex<T>(List<T> param)
        {
            return param.Count + 1;
        }
        
    }
}
