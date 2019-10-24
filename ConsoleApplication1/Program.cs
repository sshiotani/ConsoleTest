using System;
using System.Collections.Generic;
class A
{
    public virtual void Act()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Act()
    {
        Console.WriteLine("B");
    }
}

class C : A
{
    public override void Act()
    {
        Console.WriteLine("C");
    }
}

class D : A
{
    public new void Act()
    {
        Console.WriteLine("D");
    }
}

class Program
{
    static void Main()
    {
        var objects = new List<A>
        {
            new B(),
            new C(),
            new D()
        };

        foreach (var item in objects)
        {
            item.Act();
            Console.ReadLine();
        }
    }
}

