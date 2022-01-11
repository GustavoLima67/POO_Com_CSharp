namespace RumEmployee
{
    class Program
    {
        static void main(string [] args)
        {
            List<Employee> employee = new ArrayList<>();

            Console.Write("Enter with name: ");
            String name = Console.ReadLine();
            Console.Write("Enter with age: ");
            int age  = Console.ReadLine();
            Console.Write("Enter with salary: ");
            double salary = Console.ReadLine();
            
            employee.Add(new Employee(name, age, salary));

            Console.WriteLine(employee);

        }
    }

}