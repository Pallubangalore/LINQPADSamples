<Query Kind="Statements" />

int[] list = { 42, 42, 6, 6, 6, 42 };
var result = list.SkipWhile(i => i == 42);

result.Dump();