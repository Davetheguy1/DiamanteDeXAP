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
            
            
            
            
            
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ", firstString);
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
            Console.WriteLine("     {0}       ");
             

        }


    }
}
