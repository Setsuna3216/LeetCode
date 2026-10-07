## 1768. Merge Strings Alternately

**Idea:** Loop through the longer string and add characters alternately.

**Remember:**
- `word[i]` gets a character.
- ⚠️ Use `i < word.Length`, NOT `i <= word.Length`.
- Check length before accessing each string.

**Complexity:** O(n)