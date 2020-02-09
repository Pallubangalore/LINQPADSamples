<Query Kind="Statements" />

var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var groupedByMod2 = a.Select(x => new
{
Source = x,
Mod2 = x % 2
})
.GroupBy(x => x.Mod2)
.ToDictionary(g => g.Key, g => g.ToArray());
if (groupedByMod2.TryGetValue(1, out var oddElements))
{
Console.WriteLine(oddElements.Length);
}
Console.WriteLine(oddElements.Select(x=>x));