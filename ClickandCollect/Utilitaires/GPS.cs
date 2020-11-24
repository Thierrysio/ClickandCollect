using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickandCollect.Utilitaires
{
    class GPS
    {
        public static double GetDistanceGps(float CLatitude, float CLongitude, float BLatitude, float BLongitude)
        {
            var sCoord = new GeoCoordinate(CLatitude, CLongitude);
            var eCoord = new GeoCoordinate(BLatitude, BLongitude);

            return sCoord.GetDistanceTo(eCoord);
        }
    }
}
