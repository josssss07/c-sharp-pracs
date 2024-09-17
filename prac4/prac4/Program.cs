namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 34, 123,5,12,4,5, 34, 98};

            IEnumerable<int> n = arr.Where(p => p % 2 == 0).Select(p => p);
            
            foreach (var m in n )
            {
                Console.WriteLine(m);
            }

            int count = arr.Count(x=> x>5);
            int avg = (int)arr.Average(x => x);
            int max = arr.Max(x => x);
            Console.WriteLine("max and avg are: ");
            Console.WriteLine(avg);
            Console.WriteLine(max);

            IEnumerable<int> maxim = (from a in arr select max).Take(1);
            foreach(var m1 in maxim)
            {
                Console.WriteLine(m1);
            }

            Console.WriteLine(count);
            Console.ReadKey(); 
        }
    }
}
