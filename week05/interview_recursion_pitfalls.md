# Week 5 Interview Video Script - Recursion Pitfalls

**Duration: ~1 minute**

---

## Introduction (10 seconds)

"Hi! Today I'll discuss two major pitfalls of recursion and how to overcome them."

---

## Pitfall 1: Stack Overflow (25 seconds)

"The **first pitfall is stack overflow**. Every recursive call uses memory on the call stack. If you have too many recursive calls - like calculating fibonacci of a large number - you can run out of stack space and crash your program.

**How to fix this**: Use **memoization** - store results you've already calculated so you don't have to recalculate them. For example, in our climbing stairs problem, we used a dictionary to remember previous results. This turns an exponential problem into a linear one.

Another solution is to **use iteration instead** - replace the recursion with a loop when possible."

---

## Pitfall 2: Performance Issues (20 seconds)

"The **second pitfall is poor performance**. Some recursive solutions recalculate the same values over and over. Like fibonacci - to calculate F(5), you calculate F(3) multiple times wastefully.

**How to fix this**: Again, **memoization** is your friend - cache those repeated calculations. Or you can **redesign the algorithm** to be more efficient. Sometimes a simple loop is much faster than recursion."

---

## Conclusion (5 seconds)

"So remember: watch out for stack overflow and repeated calculations, and use memoization or iteration to solve these issues. Thanks!"

---

## Speaking Tips:

- **Keep it conversational** and relaxed
- **Use hand gestures** when mentioning "stack" and "memory"
- **Smile** and maintain good eye contact with camera
- **Speak clearly** but naturally
- **Give concrete examples** from your recent assignment

## Key Points Covered:

✅ **Pitfall 1**: Stack overflow from too many recursive calls
✅ **Solution 1A**: Memoization (dictionary caching)
✅ **Solution 1B**: Use iteration instead
✅ **Pitfall 2**: Performance issues from repeated calculations  
✅ **Solution 2A**: Memoization for caching
✅ **Solution 2B**: Algorithm redesign
✅ **Real examples** from climbing stairs problem
