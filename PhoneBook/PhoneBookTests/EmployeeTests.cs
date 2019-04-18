namespace PhoneBookTests
{
    using NUnit.Framework;
    using PhoneBook;

    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CheckInitialDataOfEmployee()
        {
            var employee1 = new Employee("Ewa", "Nowakowska", "52325", "Koszalin", "875-748-854");
            Assert.That(employee1.PrintBasicInfo(), Is.EqualTo("Ewa Nowakowska"));
        }

        [Test]
        public void CheckExtendedDataOfEmployee()
        {
            var employee2 = new Employee("Andrzej", "Ferdek", "54343", "Wroclaw", "565-958-999");
            Assert.That(employee2.PrintFullInfo(), Is.EqualTo("Andrzej Ferdek 54343 Wroclaw 565-958-999"));
        }
    }
}
