<Query Kind="Statements" />

// Define other methods and classes here
var first = new List<string>(){ "a","b","c"}; // Left data
var second = new List<string>(){ "a", "c", "d"}; // Right data

/*Inner Join */
var result = from f in first
join s in second on f equals s
select new { f, s };

result.Dump();

result = first.Join(second,
f=>f,
s=>s,
(f,s)=> new {f,s});

result.Dump();

/* Left outer join */
var leftOuterJoin = from f in first
from s in second.Where(x=>x==f).DefaultIfEmpty()
select new {first = f , second = s};

leftOuterJoin.Dump();

var LOJByMethod = first.GroupJoin(second,
									f=>f,
									s=>s,
									(f,s)=>new {First = f, Second = s})
									.SelectMany(temp=>temp.Second.DefaultIfEmpty(),
									(f,s)=> new {First=f.First,Second=s});
	LOJByMethod.Dump();
	
/* Right outer join */
var rightOuterJoin = from s in second
join f in first on s equals f into temp
from t in temp.DefaultIfEmpty()
select new { First = t, Second = s};

rightOuterJoin.Dump();

/* Cross join */
var crossJoin = from s in second
from f in first
select new {f,s};
crossJoin.Dump();

/* Full outer join */
//var fullOuterJoin = leftOuterJoin.Union(rightOuterJoin);
//fullOuterJoin.Dump();