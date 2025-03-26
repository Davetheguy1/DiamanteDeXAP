using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeXAP
{
    class Diamond
    {
        public static List<int> numsPerString = new List<int> { };

        public static bool InputValidation(int playerValue)
        {
            if (playerValue % 2 == 0)
            {
                Text.ErrorMessage1();
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }


        public static void CreateDiamondList()
        {
            
            
            int baseValue = Program.playerValue;


            Console.WriteLine("\n\n");
            while (baseValue != 0 && baseValue > 0)
            {

                for (int i = 1; i <= baseValue; i++)
                {

                    Console.Write("X");
                    numsPerString.Add(i);
                }
                
                
                baseValue = baseValue - 2;
                Console.WriteLine("\n");
                Console.WriteLine();
            }

            Console.WriteLine(string.Join(", ", numsPerString)); // pra testes
        }

        public static void CreateDiamondGraph()
        {
            // ainda não programado.
        }


    }
}
