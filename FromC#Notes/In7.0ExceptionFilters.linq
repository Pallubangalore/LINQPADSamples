<Query Kind="Statements" />

var spoons = "dinner,desert,soup".Split(',');
//spoons = new string[0];
var spoonsArray = spoons.Length > 0
? spoons
: new Func<string[]>(() =>
{
throw new Exception("There are no spoons");
})();

Console.WriteLine(spoonsArray);

//In 7.0
var spoonsArray2 = spoons.Length > 0 ? spoons : throw new Exception("There are no spoons");