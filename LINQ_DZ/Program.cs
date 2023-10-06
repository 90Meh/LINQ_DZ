internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        List<int> list = new List<int>();
        var a = list.Top<int>;
        Console.ReadKey();
    }
}

public static class IEnumerableExtension
{
    public static IEnumerable<T> Top<T> (this IEnumerable<T> values)
    {
        foreach (var item in values)
        {    
            
        }
        return values;
    }
}
