# 1. Two Sum

**Difficulty:** Easy  
**Language:** C#

## What I Learned

- How to use nested `for` loops
- How to access array elements using an index
- How to return the indices of two elements
- Starting the second loop at `i + 1` prevents using the same element twice

## My Approach

I used two loops to check every possible pair of numbers.

The first loop selects one number, and the second loop checks the numbers after it. If the sum of the two numbers equals the target, I return their indices.

## Complexity

- Time: O(n²)
- Space: O(1)

## Review

- [ ] Solve again without looking at my previous solution
- [ ] Learn the Dictionary approach
