# 13. Roman to Integer

Difficulty: Easy

## Approach
- Loop through each character.
- Subtract if the next Roman numeral is larger.
- Otherwise, add the current value.
- Check the index before accessing the next character.

## Complexity
- Time: O(n)
- Space: O(1)

## Mistakes
- IndexOutOfRangeException when using i + 1.
- Forgot to handle the last character.