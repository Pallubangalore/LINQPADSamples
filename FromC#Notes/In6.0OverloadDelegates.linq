<Query Kind="Program" />

void Main()
{
	Overloaded(DoSomething);
	Overloaded(Nothing);
	Foo(()=>()=> 7);
}

// Define other methods and classes here
static void Overloaded(Action action)
{
Console.WriteLine("overload with action called");
}
static void Overloaded(Func<int> function)
{
Console.WriteLine("overload with Func<int> called");
}
static void Nothing()
{
Console.WriteLine("Do as nothing done");
}
static int DoSomething()
{
Console.WriteLine(0);
return 0;
}
static void Foo(Func<Func<long>> func) { Console.WriteLine("LONG!!");}
static void Foo(Func<Func<int>> func) { Console.WriteLine("int");}