<Query Kind="Program" />

void Main() {
	IEnumerable < int > numbers = new List < int > {
		1,
		2,
		3,
		4,
		5,
		6,
		7,
		8
	};
	var hasmoreElements = numbers.HasMoreThanThreeElementes();
	Console.WriteLine("Has more than 3 elements " + hasmoreElements);
}

// Define other methods and classes here
public static class EnumerableExtension {

	public static bool HasMoreThanThreeElementes < T > (this IEnumerable < T > enumerable) {
		return enumerable.Take(4).Count() > 3;
	}

}