<Query Kind="Program" />

void Main()
{
	List<Person> objects = new List<Person>
{
new Person { Name = "Nikki"},
new Person { Name = "Gilad"},
new Person { Name = "Phil"},
new Person { Name = "John"}
};
//Using the Person's Equals method - override Equals() and GetHashCode() - otherwise it
//will compare by reference and result will be false
var result4 = objects.Contains(new Person { Name = "Phil" });
result4.Dump();
Console.WriteLine("After implementing IEqualityComparer");
var result5 = objects.Contains(new Person { Name = "Phil" }, new Compare()); // true
result5.Dump();
}

// Define other methods and classes here
public class Person
{
public string Name { get; set; }
}

public class Compare : IEqualityComparer<Person>
{
public bool Equals(Person x, Person y)
{
return x.Name == y.Name;
}
public int GetHashCode(Person codeh)
{
return codeh.Name.GetHashCode();
}
}