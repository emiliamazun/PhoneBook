namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static PhoneBook myPhoneBook = new PhoneBook();
        public static void Main(string[] args)
        {
            SeedPhoneBookWithData();
            Console.WriteLine("Phone book");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Write Location or Quit");
            string textFromLine;
            while ((textFromLine = Console.ReadLine()) != null)
            {
                if(textFromLine=="Location")
                {
                    Console.WriteLine(ShowAllEmployees());
                }
                else if (textFromLine=="Quit")
                {
                    return;
                }
            }
            Console.ReadLine();
            return;
        }
        public static void SeedPhoneBookWithData()
        {
            var employee = new Employee("Bartek", "En", 123, Departments.Koszalin, "00-4567");
            var employee2 = new Employee("Ania", "Zar", 456, Departments.Wroclaw, "00-1597");
            var employee3 = new Employee("Sylwek", "Mroz", 789, Departments.Szczecin, "00-1999");
            var employee4 = new Employee("Marcin", "Rek", 963, Departments.Szczecin, "00-1588");

            myPhoneBook.AddEmployee(employee);
            myPhoneBook.AddEmployee(employee2);
            myPhoneBook.AddEmployee(employee3);
            myPhoneBook.AddEmployee(employee4);
        }

        public static string ShowAllEmployees()
        {            
            
        }        
    }
}