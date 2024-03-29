﻿using System;
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
                //TODO Implementera en check som kollar om en key med samma namn redan finns och sedan därefter anting ändrar value eller lägger till
                //{"Rubber", 0 },
                //{"Wood", 0 }
            };
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                foreach (var (key, value) in materials)
                {
                    Console.WriteLine(key + " : " + value + "\n");  //Visar högst upp vad som redan finns
                }

                Console.WriteLine("Choose material to add (Metal, Rubber or Wood): ");
                Console.WriteLine("\nType p to Exit");
                string materialOption = Console.ReadLine();
                

                if (materialOption == "Metal"|| materialOption == "metal")
                {
                    if (materials.ContainsKey("Metal"))  //Kollar om Key "Metal" redan finns
                    {
                        Console.Clear();
                        Console.WriteLine("How many units of metal do you wanna add?");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        materials["Metal"] = materials["Metal"]+ newNumber;
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("How many units of metal do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Metal", numberOf);

                    Console.WriteLine("\nDo you wish to add anything else? Y/N");
                    ConsoleKeyInfo input = Console.ReadKey(false);
                    
                    if(input.Key == ConsoleKey.Y) 
                    {
                        continue;

                    }
                    else
                    { 
                    Console.ReadLine();
                    loop = false;
                    }
                }
                else if (materialOption == "Rubber" || materialOption == "rubber")
                {
                    if (materials.ContainsKey("Rubber"))  //Kollar om Key "Rubber" redan finns
                    {
                        Console.Clear();
                        Console.WriteLine("How many units of rubber do you wanna add?");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        materials["Rubber"] = materials["Rubber"] + newNumber;
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("How many units of rubber do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Rubber", numberOf);

                    Console.WriteLine("\nDo you wish to add anything else? Y/N");
                    ConsoleKeyInfo input = Console.ReadKey(false);

                    if (input.Key == ConsoleKey.Y)
                    {
                        continue;

                    }
                    else
                    {
                        Console.ReadLine();
                        loop = false;
                    }
                }
                else if (materialOption == "Wood" || materialOption == "wood")
                {
                    if (materials.ContainsKey("Wood"))  //Kollar om Key "Wood" redan finns
                    {
                        Console.Clear();
                        Console.WriteLine("How many units of wood do you wanna add?");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        materials["Wood"] = materials["Wood"] + newNumber;
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("How many units of wood do you wanna add?");
                    int numberOf = Convert.ToInt32(Console.ReadLine());

                    materials.Add("Wood", numberOf);

                    Console.WriteLine("\nDo you wish to add anything else? Y/N");
                    ConsoleKeyInfo input = Console.ReadKey();

                    if (input.Key == ConsoleKey.Y)
                    {
                        continue;

                    }
                    else
                    {
                        Console.ReadLine();
                        loop = false;
                    }
                } 
                else if (materialOption == "p")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nDidn't recognize command, be sure to write one of following options");
                    Console.WriteLine("Metal\nRubber\nWood\nPress any key to continue");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
