# Electronics Shop Solution 

## Description
Given price lists for keyboards and drives, find the cost to buy them. If it's not possible to buy both, return -1.

## Algorithm
We use **sorting** + **two-pointer** technique to optimize the solution.

## Time Complexity

- Sorting both arrays takes O(N log N + M log M).
- Two-pointer traversal takes O(N + M).
- **Total Complexity:** O(N log N + M log M).