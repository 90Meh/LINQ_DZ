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
            var person = new Person("aaa", 32);
            var listPers = new List<Person>
            {
                person
            };
            listPers.Top(30, person => person.Age);
        }
        catch (Exception)
        {
            Console.WriteLine("Значение за пределами допустимого.");
        }
    }
}

public static class IEnumerableExtension
{
    public static IEnumerable<T> Top<T>(this IEnumerable<T> values, double percent)
    {

        if (percent < 1 || percent <= 100)
        {
            return values.OrderByDescending(x => x).Take((int)Math.Ceiling(values.Count() * percent / 100));
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public static IEnumerable<T> Top<T>(this IEnumerable<T> values, double percent, Func<T, bool> predicate)
    {
        if (percent < 1 || percent <= 100)
        {
            return values.OrderByDescending(x => x).Take((int)Math.Ceiling(values.Count() * percent / 100));
        }
        else
        {
            throw new ArgumentException();
        }
    }
    public class Person
    {
        string Name { get; set; }
        int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}

