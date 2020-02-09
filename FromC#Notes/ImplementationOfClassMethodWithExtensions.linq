<Query Kind="Program" />

void Main()
{
Test t = new Test();
t.Hello(); // Prints "From Test"
}

/* When a class method with the same signature is available, the compiler prioritizes it over the extension method */

class Test
{
public void Hello()
{
Console.WriteLine("From Test");
}
}
static class TestExtensions
{
public static void Hello(this Test test)
{
Console.WriteLine("From extension method");
}
}