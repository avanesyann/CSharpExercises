# Breaking The Records 

## Description

This function determines how many times a player breaks their highest and lowest score records during a game season.

## Example Usage
````csharp
List<int> scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
List<int> result = BreakingRecords(scores);

Console.WriteLine(string.Join(", ", result));