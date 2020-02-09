<Query Kind="Program" />

static class StringExtensions
{
public static string Shorten(this string text, int length)
{
return text.Substring(0, length);
}
}

class Program
{
static void Main()
{
// This calls method String.ToUpper()
var myString = "Hello World!".ToUpper();
Console.WriteLine(myString);
// This calls the extension method StringExtensions.Shorten()
var newString = myString.Shorten(5);
Console.WriteLine(newString);
// It is worth noting that the above call is purely syntactic sugar
// and the assignment below is functionally equivalent
var newString2 = StringExtensions.Shorten(myString, 5);
Console.WriteLine(newString2);
}
}