<Query Kind="Program" />

void Main()
{
	Console.WriteLine(Fibonacci(10));
}

IEnumerable<int> Fibonacci(int n)
{
	int prev = 1;
	int curr = 1;
	
	for(int i=0;i<n;i++)
	{
	yield return prev;
	int temp = curr + prev;
	prev = curr;
	curr = temp;
	}
}
// Define other methods and classes here
