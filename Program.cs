using System.Collections;

namespace Fundmentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("2");
            arr.Add(1==1);
            arr.Add(100.90M);
            arr.Add(100.90F);

            foreach (var item in arr)
            {
                if (item is int)
                {
                    Console.WriteLine($"{item} is integer");
                }
                if (item is string)
                {
                    Console.WriteLine($"{item} is string");
                }
                if (item is bool)
                {
                    Console.WriteLine($"{item} is bool");
                }

                //Console.WriteLine(item);
            }
        }
    }
}
