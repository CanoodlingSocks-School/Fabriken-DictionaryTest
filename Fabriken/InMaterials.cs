using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken
{
    class InMaterials
    {
        public void MaterialInput()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                {"Metal", 0 },
                {"Rubber", 0 },
                {"Wood", 0 }
            };

            Console.WriteLine("Choose material to add: ");
            string materialOption = Console.ReadLine();
            if (materialOption == "Metal")
            {
                Console.WriteLine("How many metal/s do you wanna add?");
                int numberOf = Convert.ToInt32(Console.ReadLine());

                materials.CurrentInventory("Metal", numberOf);

                foreach (var (key, value) in materials)
                {
                    Console.WriteLine(key + " : " + value);
                }
            }



        }
    }
}
