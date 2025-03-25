namespace DiamanteDeXAP
{
    internal class Program
    {
       
        
        
        
        
        
        
        
        
        
        
        
        
        
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
            Console.WriteLine("Hello, World!");
        }
    }
}
