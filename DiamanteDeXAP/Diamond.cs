using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeXAP
{
    class Diamond
    {

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


        public static void CreateDiamond()
        {
            int baseValue = Program.playerValue;

            
                string firstString = new string('X', baseValue);
                string secondString = new string('X', (baseValue - 2));
                string thirdString = new string('X', (baseValue - 4));
                string fourthString = new string('X', (baseValue - 6));
                string fifhtString = new string('X', (baseValue - 8));
                string sixthString = new string('X', (baseValue - 10));
                string seventhString = new string('X', baseValue - 12);
                string eighthString = new string('X', baseValue - 14);
                string ninthString = new string('X', baseValue - 16);
                string tenthString = new string('X', baseValue - 18);
                string eleventhString = new string('X', baseValue - 20);




                Console.WriteLine("      {0}      ", eleventhString);
                Console.WriteLine("      {0}      ", tenthString);
                Console.WriteLine("      {0}      ", ninthString);
                Console.WriteLine("      {0}      ", eighthString);
                Console.WriteLine("      {0}      ", seventhString);
                Console.WriteLine("      {0}      ", sixthString);
                Console.WriteLine("      {0}      ", fifhtString);
                Console.WriteLine("      {0}      ", fourthString);
                Console.WriteLine("      {0}      ", thirdString);
                Console.WriteLine("      {0}      ", secondString);
                Console.WriteLine("      {0}      ", firstString);
                Console.WriteLine("      {0}      ", secondString);
                Console.WriteLine("      {0}      ", thirdString);
                Console.WriteLine("      {0}      ", fourthString);
                Console.WriteLine("      {0}      ", fifhtString);
                Console.WriteLine("      {0}      ", sixthString);
                Console.WriteLine("      {0}      ", seventhString);
                Console.WriteLine("      {0}      ", eighthString);
                Console.WriteLine("      {0}      ", ninthString);
                Console.WriteLine("      {0}      ", tenthString);
                Console.WriteLine("      {0}      ", eleventhString);
            
            
             Program.Enquire();

        }


    }
}
