namespace prac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int num = n, reverse = 0, sum = 0, rem = 0;

            while (num> 0)
            {
                rem = num % 10;
                sum = sum + rem;
                reverse = reverse * 10 + (rem);
                num = num / 10;
            }

            Console.WriteLine("original number = " + n);
            Console.WriteLine("reverse of the number = " +  reverse);
        }
    }
}
