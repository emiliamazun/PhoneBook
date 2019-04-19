namespace PhoneBookTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using PhoneBook;

    [TestFixture]
    public class PhoneBookTests
    {
        private Employee myEmployee;

       [SetUp]
        public void SetUp()
        {
            this.myEmployee = new Employee("Emma", "Mazuni", 123, Departments.Koszalin, "00-4567");    
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Finished");
        }

        [Test]
        public void Employee_Check_All_Info()
        {
            Assert.Multiple(() =>
            {
                Assert.That(myEmployee.Name, Is.EqualTo("Emma"));
                Assert.That(myEmployee.SurName, Is.EqualTo("Mazuni"));
                Assert.That(myEmployee.BadgeID, Is.EqualTo(123));
                Assert.That(myEmployee.Department, Is.EqualTo(Departments.Koszalin));
                Assert.That(myEmployee.InternalPhone, Is.EqualTo("00-4567"));
            });           
        }

        [Test]
        public void Employee_Check_Basic_Print()
        {
            var employeeNameAndDepartment = this.myEmployee.Name + " " + this.myEmployee.Department;
            Assert.That(this.myEmployee.PrintBasicInfo(), Is.EqualTo(employeeNameAndDepartment));
        }

        [Test]
        public void Employee_Check_Full_Print()
        {
            var employeeFullData = this.myEmployee.Name + " " + this.myEmployee.SurName + " " + this.myEmployee.BadgeID.ToString() + " " + this.myEmployee.Department + " " + this.myEmployee.InternalPhone;
            Assert.That(this.myEmployee.PrintFullInfo(), Is.EqualTo(employeeFullData));
        }

        [Test]
        public void PhoneBook_Add_Employees()
        {
            var employee = new Employee("Bartek", "En", 123, Departments.Koszalin, "00-4567");
            var employee2 = new Employee("Ania", "Zar", 456, Departments.Wroclaw, "00-1597");
            var employee3 = new Employee("Sylwek", "Mroz", 789, Departments.Szczecin, "00-1999");
            var employee4 = new Employee("Marcin", "Rek", 963, Departments.Szczecin, "00-1588");

            var phoneBook = new PhoneBook();

            phoneBook.AddEmployee(employee);
            phoneBook.AddEmployee(employee2);
            phoneBook.AddEmployee(employee3);
            phoneBook.AddEmployee(employee4);

            foreach (var element in phoneBook.EmployeesFromLocation(Departments.Szczecin))
                {
                Console.WriteLine(element.Name);
                }
            }
        }
    }
