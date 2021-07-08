using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count - y.Allergens.Count > 0)
            {
                return 1;
            }
            else if (x.Allergens.Count - y.Allergens.Count < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
