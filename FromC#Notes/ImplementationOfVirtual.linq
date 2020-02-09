<Query Kind="Program" />

/*base class constructor already sees derived class virtual
method table!
Be careful: derived class may not been fully initialized yet (its constructor will be executed after base class
constructor) and this technique is dangerous (there is also a StyleCop warning for this). Usually this is regarded as
bad practice.*/


void Main()
{
	var newDerived = new Derived();
}

class Base
{
protected Base()
{
_obj = CreateAnother();
}
protected virtual AnotherBase CreateAnother()
{
Console.WriteLine("I'm in base");
return new AnotherBase();
}
private readonly AnotherBase _obj;
}

class AnotherBase
{
}

class AnotherDerived : AnotherBase
{
}

sealed class Derived : Base
{
public Derived() { }
protected override AnotherBase CreateAnother()
{
Console.WriteLine("I'm in Derived");
return new AnotherDerived();
}
}

