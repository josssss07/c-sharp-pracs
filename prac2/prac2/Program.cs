namespace prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string:");
            string s1 = Console.ReadLine();

            //1
            bool b1 = s1.Contains("Test");
            Console.WriteLine("The string contains 'test' " + b1);

            //2
            bool b2 = s1.StartsWith("t");
            Console.WriteLine("The string starts with 't'");

            //3
            Console.WriteLine("The length of the txt stirng is: " + s1.Length);

            //4
            Console.WriteLine("the given string in upper case is " + s1.ToUpper() );

            //5
            Console.WriteLine("enter another string");
            string s2 = Console.ReadLine();
            Console.WriteLine(string.Concat(s1, s2));

            //6
            bool b3 = s2.EndsWith("t");
            Console.WriteLine("The string ends with 't': " + b3);

            //7
            Console.WriteLine(s1.Equals(s2));

            //8
            string s3 = string.Intern(s1);
            Console.WriteLine("THE ANSWER FOR THIS IS: " + s3);

            //parsing to different data types
            Console.WriteLine("enter a number: ");
            int n = int.Parse(Console.ReadLine());


        }
    }
}
