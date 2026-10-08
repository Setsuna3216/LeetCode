# 9. Palindrome Number

- Use `% 10` to get the last digit.
- Use `/ 10` to remove the last digit.
- Reverse: `reversedNum = reversedNum * 10 + x % 10`
- Use `long` to avoid integer overflow.
- Time: O(n), Space: O(1)