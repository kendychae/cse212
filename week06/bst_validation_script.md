# BST Validation Video Script

**Duration: ~1 minute**

---

## Introduction (10 seconds)

"Hi! Today I'll explain how to write a recursive function that checks if a binary tree is actually a binary search tree."

---

## The Problem (15 seconds)

"A binary search tree has a special rule: for every node, all values in the left subtree must be smaller, and all values in the right subtree must be larger. Just checking each node against its immediate children isn't enough - we need to make sure the entire subtree follows the rule."

---

## The Solution (25 seconds)

"Here's my approach: I'll create a recursive function that takes three parameters - the current node, a minimum allowed value, and a maximum allowed value.

For each node, I check:

1. Is the current value between min and max? If not, return false.
2. Recursively check the left subtree with the same minimum but the current value as the new maximum.
3. Recursively check the right subtree with the current value as the new minimum and the same maximum.

If all checks pass, it's a valid BST!"

---

## Example (8 seconds)

"So if I'm at node 10, the left subtree can only have values less than 10, and the right subtree can only have values greater than 10."

---

## Conclusion (2 seconds)

"This ensures every value is in the correct position throughout the entire tree. Thanks!"

---

## Speaking Tips:

- **Keep it conversational** - explain like you're helping a friend
- **Use hand gestures** when mentioning left/right subtrees
- **Speak clearly** but at normal pace
- **Smile** and maintain eye contact with camera

## Key Points Covered:

✅ **Problem**: BST validation requires checking entire subtrees
✅ **Solution**: Recursive function with min/max bounds
✅ **Parameters**: Node, minimum value, maximum value
✅ **Logic**: Check bounds, then recurse with updated bounds
✅ **Example**: Concrete illustration with node 10
