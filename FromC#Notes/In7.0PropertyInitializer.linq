<Query Kind="Program" />

void Main()
{
Ing test = new Ing();
test.Ingredients.Dump();
}

public class Ing
{
public List<string> Ingredients { get; } =
new List<string> { "dough", "sauce", "cheese" };
}
