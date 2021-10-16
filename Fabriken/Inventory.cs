using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken
{
    public static class Inventory
    {
        public static void CurrentInventory<T>(this Dictionary<T, T> materials, T key, T newValue)
        {
            if (materials.ContainsKey(key)) 
            { 
                materials[key] = newValue; 
            }
            else
            {
                materials.Add(key, newValue);
            }
        }  
    }
}
