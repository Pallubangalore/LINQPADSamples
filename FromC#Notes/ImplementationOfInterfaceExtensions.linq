<Query Kind="Program" />

void Main()
{
	var mymsg = new Greetings();
	mymsg.message = "Good Morning";
	Console.WriteLine(mymsg.PrefixMsg("bye"));
}

// Define other methods and classes here
public interface IGreetings
{
string message { get; set;}
}

public static class Message
{
public static string  PrefixMsg(this IGreetings msg, string text)
{
 return  "Hello ...." + msg.message +"\n"+ text;
}
}

public class Greetings : IGreetings 
{
string msg;
public string message { get =>msg; set => msg = value; }
}