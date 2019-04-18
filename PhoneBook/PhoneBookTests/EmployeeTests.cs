namespace PhoneBookTests
{
    using NUnit.Framework;
    using PhoneBook;
    using Employee;

    [TestFixture]
    public class EmployeeTests
    {
        Employee employee1 = new Employee("Ewa", "Nowakowska", 52325, Location.Koszalin, "875-748-854");

        [Test]
        public void CheckInitialDataOfEmployee()
        {
            Assert.That(employee1.PrintBasicInfo(), Is.EqualTo("Ewa Nowakowska"));
        }

        [Test]
        public void CheckExtendedDataOfEmployee()
        {
            Assert.That(employee1.PrintFullInfo(), Is.EqualTo("Ewa Nowakowska 52325 Koszalin 875-748-854"));

        }

        [Test]
        public void Employee_Creation_FilledProperlyField()
        {
            var employee = new Employee("Marcin", "Kowalski", 34543, Location.Szczecin, "565-541-999");
            var employee1 = new Employee("Ewa", "Gargulec", 43432, Location.Wroclaw, "524-659-874");

        }

        [Test]
        public void EmployeesFromLocation()
        {
            var employee = new PhoneBook();
            employee.AddEmployee("Marzena", "Januszewska", 34323, Location.Wroclaw, "451-584-985");
            employee.AddEmployee("Janusz", "Januszewski", 34323, Location.Koszalin, "451-584-985");
            employee.AddEmployee("Sylwester", "Nosowski", 34323, Location.Zielona_Gora, "451-584-985");
            employee.AddEmployee("Halina", "Papuzinska", 34323, Location.Krakow, "451-584-985");
            employee.AddEmployee("Juliusz", "Januszewska", 34323, Location.Wroclaw, "451-584-985");
      
            var employeesFromWroclaw = employee.EmployessFromLocation(Location.Wroclaw);

            Assert.That(employeesFromWroclaw.Count, Is.EqualTo(2));

        }
        
    }
}
