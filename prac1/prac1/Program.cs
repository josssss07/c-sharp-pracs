namespace prac1
{
  class A
    {
        //virtual is a starting poitn
        public virtual void display()
        {
            Console.WriteLine("a");
        }
    }

    class B : A
    {
        //override means next
        //till the subclass have the overeride method the chain keeps on going 
        public new virtual void display()
        {
            Console.WriteLine("b");
        }

    }

    class C : B
    {
        public override void display()
        {
            Console.WriteLine("c");
        }
    }

    class D : C
    {
        public override void display()
        {
            Console.WriteLine("d");
        }
    }

    class E : D
    {
        public new virtual void display()
        {
            Console.WriteLine("E");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B a = new E();
            a.display();    
        }
    }
}
