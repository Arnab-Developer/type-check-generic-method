using static System.Console;
using ConsoleApp1;

Foo1 f1 = new();
Class1<Foo1> c1 = new();
WriteLine(c1.M1(f1));

Foo2 f2 = new();
Class1<Foo2> c2 = new();
WriteLine(c2.M1(f2));

Foo3 f3 = new();
Class1<Foo3> c3 = new();
WriteLine(c3.M1(f3));

namespace ConsoleApp1
{
    class Class1<T> where T : IFoo
    {
        public string M1(T input)
        {
            if (input is Foo3) return "hello";
            return input.H1();
        }
    }

    interface IFoo
    {
        string H1();
    }

    class Foo1 : IFoo
    {
        string IFoo.H1() => "Foo1";
    }

    class Foo2 : IFoo
    {
        string IFoo.H1() => "Foo2";
    }

    class Foo3 : IFoo
    {
        string IFoo.H1() => "Foo3";
    }
}

/*
Output:

Foo1
Foo2
hello
*/