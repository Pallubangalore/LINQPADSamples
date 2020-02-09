<Query Kind="Program" />

void Main()
{
	var item0 = new Foo();
var item1 = new Foo();
var item2 = new Bar();
var item3 = new Bar();
var collection = new IFoo[] { item0, item1, item2, item3 };
collection.Dump();
//Using OfType
var foos = collection.OfType<Foo>().ToList(); // result: IEnumerable<Foo> with item0 and item1
var bars = collection.OfType<Bar>(); // result: IEnumerable<Bar> item item2 and item3
var foosAndBars = collection.OfType<IFoo>(); // result: IEnumerable<IFoo> with all four items
foos.Dump();
//Using Where
var foosWhere = collection.Where(item => item is Foo).ToList(); // result: IEnumerable<IFoo> with item0 and item1
var barsWhere = collection.Where(item => item is Bar).ToList(); // result: IEnumerable<IFoo> with item2 and item3
foosWhere.Dump();
barsWhere.Dump();
//Using Cast
var barsThrow= collection.Cast<Bar>(); // throws InvalidCastException on the 1st item
var foosThrow = collection.Cast<Foo>(); // throws InvalidCastException on the 3rd item
var foosAndBarsFine = collection.Cast<IFoo>(); // OK
foosAndBarsFine.Dump();
}

// Define other methods and classes here
interface IFoo { }
class Foo : IFoo { }
class Bar : IFoo { }
