using System;

    class A
    {
        public int a;
         public A() { a = 1; }
    }

    class T : A
    {   
       public int a;
        public T() { a = 2; }
    }

class Program
{
    static void Main()
    {
        T t = new T();
        Console.WriteLine(t.a);
        Console.Read();
    }
       
}
    

