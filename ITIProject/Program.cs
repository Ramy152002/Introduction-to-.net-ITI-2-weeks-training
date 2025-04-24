using ITIProject;

Employee employee1 = new Employee();
employee1.FullName = "Ramy Hany";
employee1.Country = "Egypt";
employee1.Position = "CEO";
employee1.Salary = 25000.00f;

Employee employee2 = new Employee("Hassan Abass","Top manager","Oman",20000.50f);

Employee employee3 = new Employee("Mariam Ahmed","Team Leader","Kuwait",15000.25f);

Console.WriteLine($"\t\t\t  Hello to ITI company");
Console.WriteLine("\n********************************************************************************\n");

Console.WriteLine($"\t\t\tWe have an awesome stuff\n");

employee1.ShowSpecification();
employee2.ShowSpecification();
employee3.ShowSpecification();

Console.Write( "Please enter number of employee: ");
byte numberOfEmployees = byte.Parse(Console.ReadLine());

Employee[] employees = new Employee[numberOfEmployees] ; 

for (int i = 0; i < numberOfEmployees; i++)
{
    employees[i] = new Employee();
    Console.WriteLine($"\n\t\t\tPlease enter employee #{i+1} details\n");
    Console.Write("Please enter employee's name\t:");
    employees[i].FullName = Console.ReadLine();
    Console.Write("Please enter employee's Position:");
    employees[i].Position = Console.ReadLine();
    Console.Write("Please enter employee's Country\t:");
    employees[i].Country = Console.ReadLine();
    Console.Write("Please enter employee's Salary\t:");
    employees[i].Salary = Convert.ToSingle( Console.ReadLine());

}


Console.WriteLine("\n********************************************************************************\n");

Console.WriteLine($"\t\t\tour full awesome stuff is \n");

employee1.ShowSpecification();
employee2.ShowSpecification();
employee3.ShowSpecification();

for (int i = 0;i < numberOfEmployees;i++)
{
    employees[i].ShowSpecification();
}
