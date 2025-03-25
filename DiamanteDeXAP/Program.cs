namespace DiamanteDeXAP
{
    internal class Program
    {
       
        
        static void MenuInput()
        {
            Text.ShowMenu();
            string input = Console.ReadLine();
            if (input == "1")
            {
                // ValueInput(); ainda não programado
            }
            else if (input == "2")
            {
                Environment.Exit(0);
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
