using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeXAP
{
    class Text
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Diamante em Formato de X");
            Console.WriteLine("--------------\n\n");
            Console.WriteLine("1. Iniciar\n2. Sair\n");
        }

        public static void ValueInputText()
        {
            Console.Clear();
            Console.WriteLine("--------------");
            Console.WriteLine("Insira um Número Inteiro Ímpar:\n");
        }

        public static void ErrorMessage1()
        {
            Console.WriteLine("************");
            Console.WriteLine("Erro, Favor Informar um Valor Ímpar.");
            Console.WriteLine("***********");

        }

    }
}
