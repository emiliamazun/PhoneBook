namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static PhoneBook myPhoneBook = new PhoneBook();

        public static void Main(string[] args)
        {
            SeedPhoneBookWithData();
            Console.WriteLine("Phone book");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Write Location, Name, Badge, Quit or Add");
            string textFromLine;
            while (true)
            {
                textFromLine = Console.ReadLine();
                var commands = textFromLine.Split(' ');
                switch (commands[0])
                {
                    case "Location":
                        AllEmployeesInLocation(commands[1]);
                        break;
                    case "Badge":
                        DisplayEmployeeByBadgeId(commands[1]);
                        break;
                    case "Name":
                        DisplayEmployeeByName(commands[1]);
                        break;
                    case "Add":
                        Console.WriteLine("Write name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Write surname");
                        var surname = Console.ReadLine();
                        Console.WriteLine("Write badge id");
                        var badgeID = Console.ReadLine();
                        Console.WriteLine("Write department");
                        var department = Console.ReadLine();
                        Console.WriteLine("Write InternalPhone");
                        var internalPhone = Console.ReadLine();
                        AddNewEmployee(name,surname,badgeID,department,internalPhone);
                        break;
                    case "Quit":
                        return;
                    default:
                        Console.WriteLine("Unknown value");
                        break;
                }               
            }
        }

        private static void AddNewEmployee(string name, string surname, string badgeID, string department, string internalPhone)
        {
            Departments parseDepartment;
            Enum.TryParse(department, out parseDepartment);
            int parsedBadgeId = int.Parse(badgeID);
            Employee newEmployee = new Employee(name, surname, parsedBadgeId, parseDepartment, internalPhone);

            myPhoneBook.AddEmployee(newEmployee);
        }

        public static void SeedPhoneBookWithData()
        {
            var employee = new Employee("Sylwek", "En", 123, Departments.Koszalin, "00-4567");
            var employee2 = new Employee("Ania", "Zar", 456, Departments.Wroclaw, "00-1597");
            var employee3 = new Employee("Sylwek", "Mroz", 789, Departments.Szczecin, "00-1999");
            var employee4 = new Employee("Marcin", "Rek", 963, Departments.Szczecin, "00-1588");

            myPhoneBook.AddEmployee(employee);
            myPhoneBook.AddEmployee(employee2);
            myPhoneBook.AddEmployee(employee3);
            myPhoneBook.AddEmployee(employee4);
        }
        
        public static void DisplayEmployeeByBadgeId(string badgeId)
        {
            int parsedBadgeId = int.Parse(badgeId);
            Console.WriteLine(myPhoneBook.GetEmployeeByBadgeId(parsedBadgeId).PrintFullInfo());
        }
        public static void DisplayEmployeeByName(string nameOfEmployee)
        {           
            var employeesFromLocation = myPhoneBook.GetEmployeeByName(nameOfEmployee);
            string result = string.Empty;
            employeesFromLocation.ForEach(e => result += $"{ e.PrintFullInfo()}\n");
            Console.WriteLine(result);
        }

        private static void AllEmployeesInLocation(string location)
        {
            Departments parseDepartment;
            Enum.TryParse(location, out parseDepartment);
            var employeesFromLocation = myPhoneBook.EmployeesFromLocation(parseDepartment);
            string result = string.Empty;
            employeesFromLocation.ForEach(e => result += $"{ e.PrintFullInfo()}");
            Console.WriteLine(result);
        }
    }
}