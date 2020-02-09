<Query Kind="Statements" />

int[] intList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = intList.Aggregate((prevSum, current) => prevSum + current
);
sum.Dump();

var sequenceOfSequences = new [] { new [] { 1, 2, 3 }, new [] { 4, 5 }, new [] { 6 } };
var sequence = sequenceOfSequences.SelectMany(x => x);

sequence.Dump();

var sequenceQuery = from subSequence in sequenceOfSequences
from item in subSequence
select item;

sequenceQuery.Dump();