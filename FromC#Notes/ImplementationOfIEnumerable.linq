<Query Kind="Program" />

void Main()
{
	var col = new MyCollection {
"foo",
{ "bar", 3 },
"baz",
123.45d,
};

foreach(var i in col)
{
 Console.WriteLine(i);
}

}

// Define other methods and classes here
class MyCollection : IEnumerable
{
private IList list = new ArrayList();
public void Add(string item)
{
list.Add(item);
}
public void Add(string item, int count)
{
for(int i=0;i< count;i++) {
list.Add(item);
}
}
public IEnumerator GetEnumerator()
{
return list.GetEnumerator();
}
}
static class MyCollectionExtensions
{
public static void Add(this MyCollection @this, double value) =>
@this.Add(value.ToString());
}