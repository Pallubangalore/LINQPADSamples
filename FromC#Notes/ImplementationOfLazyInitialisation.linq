<Query Kind="Program" />

void Main()
{
	var instance =  LazySingleton.Instance;
	instance.TestSingletonInstance();
	var ainstance =  LazySingleton.Instance;
	ainstance.TestSingletonInstance();
}

public class LazySingleton
{
int count = 0;
private static readonly Lazy<LazySingleton> _instance =
new Lazy<LazySingleton>(() => new LazySingleton());
public static LazySingleton Instance
{
get { return _instance.Value; }
}
private LazySingleton() { }

public void TestSingletonInstance()
{
count++;
Console.WriteLine("How many instances"+ count);
}

}