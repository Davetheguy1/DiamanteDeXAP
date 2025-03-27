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

            int lnValue = (baseValue - 1) / 2;
            int spaceValue = (baseValue - 1) / 2;

            int xString = 1;

            //upper
            for (int ln = 0; ln < lnValue; ln++)
            {
                for (int spaces = 0; spaces < spaceValue; spaces++)
                    Console.Write(" ");
                
              
                for (int x = 0; x < xString; x++)
                    Console.Write("X");

                xString += 2;
                spaceValue--;
                Console.WriteLine();
            }


            //middle
            for (int i = 0; i < baseValue; i++)
            {
                Console.Write("X");
            }

            Console.WriteLine();


            //lower

            xString -= 2;
            spaceValue = 1;

            for (int ln = 0; ln < lnValue; ln++)
            {
                for (int spaces = 0; spaces < spaceValue; spaces++)
                    Console.Write(" ");


                for (int x = 0; x < xString; x++)
                    Console.Write("X");

                xString -= 2;
                spaceValue++;
                Console.WriteLine();
            }


            

        }


    }
}
