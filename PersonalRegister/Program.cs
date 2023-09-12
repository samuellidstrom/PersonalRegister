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
             *   
             * Jag skriver svaren på frågorna här:  
             *   
                    Fråga 1 - Vilka klasser

                        Class1: employeeID, employeeName
                        Class2: salaryID, employeeSalary

                    Fråga 2 - Vilka attribut och metoder 

                        Class1:
                            här behövs:
		                    1st string-attribut: den anställdes namn
		                    1st INT: den anställdes ID (på så sätt kan man kolla det mot lönens ID så att rätt lön kan kopplas till rätt person)

                        Class2:
                        	Här behövs:
                    		1 decimal-attribut för själva lönen
		                    1st INT: lönensID

                    Varje gång en ny post läggs till får personen och lönen samma ID (ex. 42).
                    När man sen listar de anställda kan man lista namnen med visst ID tillsammans med lön med samma ID.

             *   
             *   Jag har för mig det går att skapa EN lista med flera olika data-typer dock... Så det är nog en såndan man ska använda här. Men just nu står det stilla i mitt huvud..
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