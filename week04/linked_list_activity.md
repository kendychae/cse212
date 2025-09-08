# Week 4 Linked List Activity - Step by Step Guide

## Initial Setup: Doubly-Linked List with A B C D

Start by drawing this initial doubly-linked list:

```
HEAD ──> [A] ↔ [B] ↔ [C] ↔ [D] <── TAIL
```

Detailed view:

```
HEAD
  │
  ▼
┌─────┐   ┌─────┐   ┌─────┐   ┌─────┐
│     │   │ ◄── │   │ ◄── │   │ ◄── │
│  A  │ ──┤  B  │ ──┤  C  │ ──┤  D  │
│ ──► │   │ ──► │   │ ──► │   │     │
└─────┘   └─────┘   └─────┘   └─────┘
                                 ▲
                                 │
                               TAIL
```

---

## Operation 1: Insert X at the head

**Steps to follow:**

1. Create a new node with value X
2. Set X.Next = current head (A)
3. Set A.Prev = X
4. Set HEAD = X

**Result after inserting X at head:**

```
HEAD ──> [X] ↔ [A] ↔ [B] ↔ [C] ↔ [D] <── TAIL
```

**What to draw/modify:**

- Draw a new box for X to the left of A
- Draw arrow from X to A (X.Next = A)
- Draw arrow from A back to X (A.Prev = X)
- Move HEAD pointer to point to X
- Erase the old arrow that had A.Prev pointing to null

---

## Operation 2: Insert Y between B and C

**Steps to follow:**

1. Create a new node with value Y
2. Set Y.Prev = B
3. Set Y.Next = C
4. Set C.Prev = Y
5. Set B.Next = Y

**Result after inserting Y between B and C:**

```
HEAD ──> [X] ↔ [A] ↔ [B] ↔ [Y] ↔ [C] ↔ [D] <── TAIL
```

**What to draw/modify:**

- Draw a new box for Y between B and C
- Erase the direct connection between B and C
- Draw arrow from B to Y (B.Next = Y)
- Draw arrow from Y back to B (Y.Prev = B)
- Draw arrow from Y to C (Y.Next = C)
- Draw arrow from C back to Y (C.Prev = Y)

---

## Operation 3: Remove D (the tail)

**Steps to follow:**

1. Set C.Next = null (since C becomes the new tail)
2. Set TAIL = C

**Result after removing D:**

```
HEAD ──> [X] ↔ [A] ↔ [B] ↔ [Y] ↔ [C] <── TAIL
```

**What to draw/modify:**

- Erase the entire D box
- Erase all arrows connecting to/from D
- Move TAIL pointer to point to C
- Make sure C.Next points to null (no arrow going right from C)

---

## Operation 4: Remove B

**Steps to follow:**

1. Set A.Next = Y (skip over B)
2. Set Y.Prev = A (skip over B)

**Final result after removing B:**

```
HEAD ──> [X] ↔ [A] ↔ [Y] ↔ [C] <── TAIL
```

**What to draw/modify:**

- Erase the entire B box
- Erase all arrows connecting to/from B
- Draw new arrow from A directly to Y (A.Next = Y)
- Draw new arrow from Y directly back to A (Y.Prev = A)

---

## Summary

You started with: `A B C D`
After all operations: `X A Y C`

**Operations performed:**

1. ✅ Insert X at head: `X A B C D`
2. ✅ Insert Y between B and C: `X A B Y C D`
3. ✅ Remove D (tail): `X A B Y C`
4. ✅ Remove B: `X A Y C`

## Key Learning Points

- **Insert at head**: O(1) - Only need to adjust pointers near the head
- **Insert in middle**: O(n) - Need to traverse to find the position, but insertion itself is just pointer adjustments
- **Remove from tail**: O(1) - Only need to adjust pointers near the tail
- **Remove from middle**: O(n) - Need to traverse to find the node, but removal itself is just pointer adjustments

## Drawing Tips

When drawing on paper:

- Use boxes for nodes
- Use arrows for pointers (Next and Prev)
- Clearly mark HEAD and TAIL
- Show null pointers as arrows pointing to nothing or ending with ⊥
- Use different colors or thick lines to show the changes you're making in each step
