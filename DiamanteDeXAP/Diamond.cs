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
                return false;
            }
            else
            {
                return true;
            }
        }


        




    }
}
