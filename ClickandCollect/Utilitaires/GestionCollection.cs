using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace ClickandCollect.Utilitaires
{
    class GestionCollection
    {
        public static int GetNouvelIndex<T>(List<T> param)
        {
            return param.Count + 1;
        }
        public static T GetObjet<T>(List<T> param, string param2)
       
        {
            T result = default(T) ;
            foreach (T uneBox in param)
            {
                PropertyInfo x = (uneBox.GetType().GetProperty("Id"));
                int nbi = Convert.ToInt32( x.GetValue(uneBox));
                if (nbi == Convert.ToInt32(param2))
                    {
                        result = uneBox;
                    break;
                }
            }
            return result;
        }

    }
}
