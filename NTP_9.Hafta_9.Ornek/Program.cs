using System;
class A
{
    public int a;
    public A() { a = 1; }
    public void yaz() { Console.WriteLine("a yaz"); }
}
class T : A
{
    public new int a;
    public int b;
    public T() { a = 2; b = base.a; }
    public void yaz() { base.yaz(); }
}
class Program
{
    static void Main()
    {
        T t = new T();
        Console.WriteLine(t.a);
        Console.WriteLine(t.b);
        Console.ReadLine();
    }
}
