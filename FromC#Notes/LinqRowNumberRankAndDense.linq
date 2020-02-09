<Query Kind="Program" />

void Main()
{
	List<SomeObject> collection = new List<SomeObject>
{
new SomeObject { Property1 = 1, Property2 = 1, Property3 = 1},
new SomeObject { Property1 = 1, Property2 = 2, Property3 = 1},
new SomeObject { Property1 = 1, Property2 = 2, Property3 = 2},
new SomeObject { Property1 = 2, Property2 = 1, Property3 = 1},
new SomeObject { Property1 = 2, Property2 = 2, Property3 = 1},
new SomeObject { Property1 = 2, Property2 = 2, Property3 = 1},
new SomeObject { Property1 = 2, Property2 = 3, Property3 = 1}
};
var rowNumbers = collection.OrderBy(item => item.Property1)
.ThenBy(item => item.Property2)
.ThenByDescending(item => item.Property3)
.Select((item, index) => new { Item = item, RowNumber = index })
.ToList();
//rowNumbers.Dump();

var rankInGroup = collection.GroupBy(item => item.Property1)
.OrderBy(group => group.Key)
.SelectMany(group => group.OrderBy(item => item.Property2)
.ThenByDescending(item => item.Property3)
.Select((item, index) => new
{
Item = item,
RankInGroup = index
})).ToList();

//rankInGroup.Dump();

var rankOfBelongingGroup = collection.GroupBy(item => item.Property1)
.OrderBy(group => group.Key)
.Select((group, index) => new
{
Items = group,
Rank = index
})
.SelectMany(v => v.Items, (s, i) => new
{
Item = i,
DenseRank = s.Rank
}).ToList();

rankOfBelongingGroup.Dump();
}


public class SomeObject
{
public int Property1 { get; set; }
public int Property2 { get; set; }
public int Property3 { get; set; }
public override string ToString()
{
return string.Join(", ", Property1, Property2, Property3);
}
}

