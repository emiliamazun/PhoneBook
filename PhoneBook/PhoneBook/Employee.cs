namespace Employee
{
    using PhoneBook;
    using System;
    using System.Collections.Generic;

    public class Employee
    {
        public Employee(string name, string surname, int badgeID, Location department, string internalPhone)
        {
            this.Name = name;
            this.Surname = surname;
            this.BadgeID = badgeID;
            this.Department = department;
            this.InternalPhone = internalPhone;
        }

        public string Name { get; }

        public string Surname { get; }

        public int BadgeID { get; }

        public Location Department { get; }

        public string InternalPhone { get; }

        public string PrintBasicInfo()
        {
            return $"{Name} {Surname}";
        }

        public string PrintFullInfo()
        {
            return $"{Name} {Surname} {BadgeID} {Department} {InternalPhone}";
        }

    }
}
