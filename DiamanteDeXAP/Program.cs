namespace DiamanteDeXAP
{
    internal class Program
    {

        public static int playerValue;
        static void MenuInput()
        {
            Text.ShowMenu();
            string input = Console.ReadLine();
            if (input == "1")
            {
                ValueInput();
            }
            else if (input == "2")
            {
                Environment.Exit(0);
            }
        }

        public static void ValueInput()
        {
            Text.ValueInputText();
            playerValue = int.Parse(Console.ReadLine());
            bool isValid = Diamond.InputValidation(playerValue);
            if (isValid == true)
            {
                Diamond.CreateDiamond();
            }
            else
            {
                ValueInput();
            }
        }


        public static void Enquire()
        {
            Console.WriteLine("Programa Finalizado, deseja reiniciar? (y/n)");
            string enquire = Console.ReadLine();

            if (enquire == "y")
            {
                //Calls Previous Function Back

            } else if (enquire == "n")
            {
                Console.WriteLine("Fechando Programa....");
                Environment.Exit(0);
            } else
            {
                Console.WriteLine("Erro, Favor Digitar uma Opção Válida");
                Enquire();
            }
            


        } 
        
  
        
        static void Main(string[] args)
        {
            MenuInput();
        }
    }
}
