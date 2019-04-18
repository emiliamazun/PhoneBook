namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        public Employee(string name, string surName, int badgeId, Departments department, string internalPhone)
        {
            this.Name = name;
            this.SurName = surName;
            this.BadgeID = badgeId;
            this.Department = department;
            this.InternalPhone = internalPhone;
            this.PrintBasicInfo(); // TODO not needed
            this.PrintFullInfo(); // TODO not needed
        }

        public string Name { get; }

        public string SurName { get; }

        public int BadgeID { get; }

        public Departments Department { get; }

        public string InternalPhone { get; }

        public string PrintFullInfo()
        {
            ////string fullInfoAboutEmployee = this.Name + " " + this.SurName + " " + this.BadgeID.ToString() + " " + this.Department + " " + this.InternalPhone;
            ////return fullInfoAboutEmployee;
            return $"{Name} {SurName} {BadgeID} {Department} {InternalPhone}";
        }

        public string PrintBasicInfo()
        {
            ////string fullInfoAboutEmployee = this.Name + " " + this.Department;
            ////return fullInfoAboutEmployee;
            return $"{Name} {Department}";
        }
    }
}
