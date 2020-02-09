<Query Kind="Program" />

void Main()
{
	List<Film> films = new List<Film>()
	{
	new Film  {Title = "ABC",Category="A",Year= 2019},
	new Film  {Title = "Sing",Category="B",Year= 2019},
	new Film  {Title = "Bali",Category="A",Year= 2019},
	new Film  {Title = "Bangalore",Category="B",Year= 2019}
	};
	
	var groupCategory = from f in films
	group f by f.Category into filmByCategory
	orderby filmByCategory.Key
	select filmByCategory;
	
	groupCategory.Dump();
	films.Dump();
}

public class Film {
public string Title { get; set; }
public string Category { get; set; }
public int Year { get; set; }
}