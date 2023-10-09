using LINQ_DZ;
using System.Collections.Generic;
using System.Linq;
using static IEnumerableExtension;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.Top(30).ToList().ForEach(x => Console.WriteLine(x));            
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXX");            
            var persons = new List<Person>() { new Person("Михаил7", 7), new Person("Иван57", 57), new Person("Андрей67", 67), new Person("Пётр23", 23) };
            persons.Top(60, x => x.Age).ToList().ForEach(x => Console.WriteLine(x.Name));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}

public static class IEnumerableExtension
{
    public class Person
    {        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}

