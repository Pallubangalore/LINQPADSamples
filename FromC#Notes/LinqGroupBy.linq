<Query Kind="Program" />

void Main()
{
	List < int > iList = new List < int > () {
	 1,
	 2,
	 3,
	 4,
	 5,
	 6,
	 7,
	 8,
	 9
	};
	var grouped = iList.GroupBy(x => x % 2 == 0);
	
	foreach(var group in grouped) {
	 foreach(int item in group) {
	  Console.Write("\n"+item); // 135792468 (first odd then even)
	 }
	 Console.WriteLine("\n");
	}
}

// Define other methods and classes here
