namespace PhoneBook
{
    using System;
    

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Książka telefoniczna");
            Console.WriteLine("---------------------");
            Console.WriteLine("Wpisz 'loc <lokalizacja>' aby wyszukać ludzi po lokalizacji");
            Console.WriteLine("Wpisz 'quit' aby zakończyć działanie programu");
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command.Contains("quit"))
                {
                    break;
                }
                else if (command.Contains("loc"))
                {
                    PhoneBook phoneBook = new PhoneBook();
                    var localisation = command.Substring(3);
                    Location temp;
                    Enum.TryParse(localisation, out temp);

                    var result = phoneBook.EmployessFromLocation(temp);

                    foreach (var count in result)
                    {
                        Console.WriteLine("---------------------");
                        Console.WriteLine(count.PrintFullInfo());

                    }

                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
