namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Employee;

    public class PhoneBook
    {
        List<Employee> allEmployees = new List<Employee>();

        public PhoneBook()
        {
            //todo to jest be
            AddEmployee("Marzena", "Januszewska", 34323, Location.Wroclaw, "451-584-985");
            AddEmployee("Janusz", "Januszewski", 34323, Location.Koszalin, "451-584-985");
            AddEmployee("Sylwester", "Nosowski", 34323, Location.Zielona_Gora, "451-584-985");
            AddEmployee("Halina", "Papuzinska", 34323, Location.Krakow, "451-584-985");
            AddEmployee("Juliusz", "Januszewska", 34323, Location.Wroclaw, "451-584-985");
        }
        public void AddEmployee(string name, string surname, int badgeID, Location department, string internalPhone)
        {
            allEmployees.Add(new Employee(name, surname, badgeID, department, internalPhone));
        }

        public List<Employee> EmployessFromLocation(Location location)
        {
            return allEmployees.Where(x => x.Department == location).ToList();            
        }
    }
}
