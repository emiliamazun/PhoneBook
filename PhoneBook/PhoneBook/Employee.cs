namespace PhoneBook
{
    public class Employee
    {
        public Employee(string name, string surname, string badgeID, string department, string internalPhone)
        {
            this.Name = name;
            this.Surname = surname;
            this.BadgeID = badgeID;
            this.Department = department;
            this.InternalPhone = internalPhone;
        }

        public string Name { get; }

        public string Surname { get; }

        public string BadgeID { get; }

        public string Department { get; }

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
