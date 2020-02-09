<Query Kind="Program" />

public class IndexableClass
{
public int this[int index]
{
set
{
Console.WriteLine("{0} was assigned to index {1}", value, index);
}
}
}

void Main()

{
var foo = new IndexableClass
{
[0] = 10,
[1] = 20
};


}

