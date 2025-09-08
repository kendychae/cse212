# Set Intersection and Union Audio Script

**Duration: 3.5 minutes maximum - Audio Only**

---

## Opening (20 seconds)

"Hi everyone! Today I'll explain two essential set operations: intersection and union. No built-in methods allowed - we're building these from scratch!"

---

## Part 1: Set Intersection (1 minute 20 seconds)

### What and How (40 seconds)

"Intersection finds items that exist in BOTH sets. Here's my approach:

First, create an empty result set. Second, loop through every item in the first set. Third, for each item, check if it exists in the second set. If yes, add it to the result.

Let's try it: Set A is 1, 2, 3, 4. Set B is 3, 4, 5, 6.
Check 1 - not in Set B, skip.
Check 2 - not in Set B, skip.
Check 3 - yes, it's in Set B, add to result.
Check 4 - yes, it's in Set B, add to result.
Final result: 3, 4."

### Performance (20 seconds)

"Performance is O of n times m - that's the size of the first set times the size of the second set, because we might check every item in set A against every item in set B."

### Test Cases (20 seconds)

"Three key tests: First, no overlap - sets 1,2 and 3,4 give empty result. Second, complete overlap - sets 1,2,3 and 1,2,3 give 1,2,3. Third, empty set - any set with empty gives empty."

---

## Part 2: Set Union (1 minute 20 seconds)

### What and How (40 seconds)

"Union combines ALL items from both sets with no duplicates. My approach:

First, create a result set and add all items from the first set. Second, loop through the second set. Third, only add items that aren't already in our result.

Same example: Set A is 1, 2, 3, 4. Set B is 3, 4, 5, 6.
Start with 1, 2, 3, 4 from Set A.
Check 3 from Set B - already have it, skip.
Check 4 from Set B - already have it, skip.
Check 5 from Set B - new, add it.
Check 6 from Set B - new, add it.
Final result: 1, 2, 3, 4, 5, 6."

### Performance (20 seconds)

"Also O of n times m in worst case, since we check if each item from set B already exists in our growing result."

### Test Cases (20 seconds)

"Same three tests: No overlap gives 1,2,3,4. Complete overlap gives 1,2,3. Empty set with 1,2,3 gives 1,2,3."

---

## Summary (30 seconds)

"To recap: Intersection finds shared items by checking each element of the first set against the second. Union combines everything by adding the first set, then only new items from the second. Both are O of n times m. Test with no overlap, complete overlap, and empty sets to verify your functions work correctly. That's intersection and union without built-in methods!"

---

**Total Runtime: 3 minutes 30 seconds**
