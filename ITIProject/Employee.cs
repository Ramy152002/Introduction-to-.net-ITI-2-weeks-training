namespace ITIProject
{
    internal class Employee
    {   // 4 field writing by code snipt prop
        public string  FullName { get; set; }
        public string  Position { get; set; }
        public string  Country { get; set; }
        public float Salary { get; set; }
        public Employee()
        {
        }

        public Employee(string FullName, string Position, string Country, float Salary)
        {
            this.FullName = FullName;
            this.Position = Position;
            this.Country = Country;
            this.Salary = Salary;
        }

        public string Greeting ()
        {
            return $"Hi, {FullName}\nnice to see you.";
        }
        public void ShowSpecification()
        {
            Console.WriteLine($"Empoyee's name\t:{FullName} " +
                $"\nworks as\t:{Position} in our company" +
                $"\nfrom \t\t:{Country}" +
                $"\n(his/her) Salary:{Salary}\n");
        }
    }
}
