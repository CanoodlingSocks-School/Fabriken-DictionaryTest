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
                //{"Metal", 0 },
                //{"Rubber", 0 },
                //{"Wood", 0 }
            };
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Choose material to add: ");
                string materialOption = Console.ReadLine();
                if (materialOption == "Metal" || materialOption == "metal")
                {
                    Console.WriteLine("How many units of metal do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Metal", numberOf);

                    foreach (var (key, value) in materials)
                    {
                        Console.WriteLine(key + " : " + value);
                    }
                    Console.ReadLine();
                    loop = false;
                }
                else if (materialOption == "Rubber" || materialOption == "rubber")
                {
                    Console.WriteLine("How many units of rubber do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Rubber", numberOf);

                    foreach (var (key, value) in materials)
                    {
                        Console.WriteLine(key + " : " + value);
                    }
                    Console.ReadLine();
                    loop = false;
                }
                else if (materialOption == "Wood" || materialOption == "wood")
                {
                    Console.WriteLine("How many units of wood do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Wood", numberOf);

                    foreach (var (key, value) in materials)
                    {
                        Console.WriteLine(key + " : " + value);
                    }
                    Console.ReadLine();
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Didn't recognize command, be sure to write one of following options");
                    Console.WriteLine("Metal\nRubber\nWood\nPress any key to continue");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
