# Beautiful Days at the Movies - HackerRank Solution 

## Statement
Given a range `[i, j]`, we count how many numbers are "beautiful days", where the absolute difference between the number and its reverse is divisible by `k`.

## Approach
- Iterate through all numbers in the given range.
- Reverse each number using an efficient integer reversal method.
- Check if `(original - reversed) % k == 0` and count such cases.

## Time Complexity
- `O((j - i) log10 n)`, where `log10 n` is the number of digits in `n`.

## Example
````csharp
Console.WriteLine(BeautifulDays(20, 23, 6));	// Output: 2