using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.Top(30).ToList().ForEach(x => Console.WriteLine(x));

        }
        catch (Exception)
        {
            Console.WriteLine("Поймал ошибку");
            throw;
        }
    }
}

public static class IEnumerableExtension
{
    public static IEnumerable<T> Top<T> (this IEnumerable<T> values, double percent)
    {
        
        if (!(percent < 1 && percent <= 100))
        {
            
            var length = Math.Ceiling(values.Count() / 100 * percent);
            return values.OrderByDescending(x => x).Take((int)length);

        }
        else
        {
            throw new ArgumentException();
        }          
    }
}
