namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             * Som ni helt tydligt kommer att se här så var den här första uppgiften lite över mitt huvud.
             * 
             * Det var tydligt lite för länge sedan jag höll på med programmering för att lösa det.
             * Jag får se till att sitta ordentligt med videomaterialet så minnet kommer tillbaka.. :P
             *     
             */


            Console.WriteLine(".: Personalregister :.");
            Console.WriteLine("");
            Console.WriteLine("1. Lista all personel + deras lön");
            Console.WriteLine("2. Lägg till en ny anställd + deras lön");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Gör ditt val: ");

                string choice = Console.ReadLine();


                var choiceNum = int.Parse(choice);


                if (choiceNum == 1)
                {
                    Console.WriteLine("Du valde 1");
                    Console.WriteLine();
                }

                else if (choiceNum == 2)
                {
                    Console.WriteLine("Skriv in namnet på den anställde:");
                    string name = Console.ReadLine();

                    CreateEmployee(name);
                }

            }


            Console.ReadLine();

        }

        private static void CreateEmployee(string newName)
        {
            //List<string> employeeName = new List<string>();

            var addName = new List<string>();
            addName.Add(newName);
            Console.WriteLine("Hej, " + newName);

        }
    }
}