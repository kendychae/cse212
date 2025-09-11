# W07 Interview Cheat Sheet - Data Structures Summary

## Dynamic Array

### Graphic:

```
[0] [1] [2] [3] [4] [5] [6] [7]  ← Capacity: 8
 A   B   C   D   E  [ ] [ ] [ ]  ← Size: 5
 ↑
Index 0 (start)
```

### Purpose and Example (3-5 sentences):

A dynamic array stores elements in contiguous memory locations with automatic resizing when capacity is exceeded. It provides fast random access to elements using indices and maintains insertion order. In a music streaming app, you could use a dynamic array to store a user's playlist where songs are added sequentially and users can quickly jump to any song by position. The array would automatically grow as users add more songs to their collection.

### Time Complexity of Common Operations:

- **Insert**: O(1) amortized (at end), O(n) worst case (at beginning/middle due to shifting)
- **Find/Retrieve**: O(1) by index, O(n) by value

---

## Stack

### Graphic:

```
    ┌───┐
    │ D │ ← Top (Push/Pop here)
    ├───┤
    │ C │
    ├───┤
    │ B │
    ├───┤
    │ A │ ← Bottom
    └───┘
    LIFO: Last In, First Out
```

### Purpose and Example (3-5 sentences):

A stack follows the Last-In-First-Out (LIFO) principle where elements are added and removed from the same end (top). It's perfect for managing function calls, undo operations, and parsing expressions with nested structures. In a code editor's undo feature, each user action (typing, deleting, formatting) gets pushed onto a stack, and when the user hits Ctrl+Z, the most recent action is popped and reversed. This allows users to undo actions in the exact reverse order they were performed.

### Time Complexity of Common Operations:

- **Insert (Push)**: O(1)
- **Find/Retrieve (Top)**: O(1), O(n) for arbitrary element

---

## Queue

### Graphic:

```
Enqueue →  [A] [B] [C] [D]  → Dequeue
          ↑               ↑
        Rear             Front
        FIFO: First In, First Out
```

### Purpose and Example (3-5 sentences):

A queue follows the First-In-First-Out (FIFO) principle where elements are added at the rear and removed from the front. It's ideal for handling requests in order and managing resources fairly. In an online gaming server, player connection requests could be managed using a queue where the first player to request a game gets matched first, ensuring fair waiting times. When a game slot opens up, the player who has been waiting longest gets connected first.

### Time Complexity of Common Operations:

- **Insert (Enqueue)**: O(1)
- **Find/Retrieve (Dequeue)**: O(1) for front element, O(n) for arbitrary element

---

## Set

### Graphic:

```
    Set = {A, B, C, D, E}
           ↑
    No duplicates allowed

    Union: {A,B} ∪ {B,C} = {A,B,C}
    Intersection: {A,B} ∩ {B,C} = {B}
```

### Purpose and Example (3-5 sentences):

A set stores unique elements with no duplicates allowed and provides fast membership testing. It's perfect for tracking unique items and performing mathematical set operations like union and intersection. In a social media app, you could use a set to track unique users who have liked a post, automatically preventing duplicate likes from the same user. When displaying mutual friends between two users, you could find the intersection of their friend sets to show common connections.

### Time Complexity of Common Operations:

- **Insert**: O(1) average (hash set), O(log n) (tree set)
- **Find/Retrieve**: O(1) average (hash set), O(log n) (tree set)

---

## Map (Dictionary)

### Graphic:

```
    Key → Value pairs

    "apple"  → 🍎
    "banana" → 🍌
    "cherry" → 🍒

    Hash("apple") → Index → Value
```

### Purpose and Example (3-5 sentences):

A map stores key-value pairs allowing fast lookup of values using unique keys. It's essential for caching, counting occurrences, and creating lookup tables. In an e-commerce website, you could use a map to store product information where the product ID is the key and the product details (name, price, description) are the value. This allows instant retrieval of any product's information when a user searches by product ID or adds items to their cart.

### Time Complexity of Common Operations:

- **Insert**: O(1) average (hash map), O(log n) (tree map)
- **Find/Retrieve**: O(1) average (hash map), O(log n) (tree map)

---

## Linked List

### Graphic:

```
HEAD → [A|●] → [B|●] → [C|●] → [D|NULL] ← TAIL
       ↑ next  ↑ next  ↑ next  ↑ next
       Data    Data    Data    Data

    Doubly Linked:
    [●|A|●] ↔ [●|B|●] ↔ [●|C|●]
     prev     prev     prev
```

### Purpose and Example (3-5 sentences):

A linked list stores elements in nodes scattered throughout memory, connected by pointers, allowing efficient insertion and deletion at any position. Unlike arrays, it doesn't require contiguous memory and can grow dynamically without declaring a fixed size. In a music player's shuffle feature, you could use a linked list to create a dynamic playlist where songs can be easily inserted or removed at any position without shifting other elements. Users could seamlessly add new songs to the middle of their queue without performance penalties.

### Time Complexity of Common Operations:

- **Insert**: O(1) at head/tail with pointer, O(n) at arbitrary position
- **Find/Retrieve**: O(n) - must traverse from head

---

## Binary Search Tree

### Graphic:

```
       10
      /  \
     5    15
    / \   / \
   3   7 12  20

   Left < Parent < Right
   In-order: 3,5,7,10,12,15,20
```

### Purpose and Example (3-5 sentences):

A binary search tree maintains elements in sorted order where each node's left children are smaller and right children are larger than the parent. It provides efficient searching, insertion, and sorted traversal operations. In a file system's directory structure, you could use a BST to store file names alphabetically, allowing users to quickly search for files and automatically display them in sorted order. When users browse a folder, files would appear alphabetically sorted, and finding a specific file would be much faster than linear search.

### Time Complexity of Common Operations:

- **Insert**: O(log n) average, O(n) worst case (unbalanced)
- **Find/Retrieve**: O(log n) average, O(n) worst case (unbalanced)

---

## Summary Table

| Data Structure     | Best Use Case      | Insert     | Search          | Space |
| ------------------ | ------------------ | ---------- | --------------- | ----- |
| Dynamic Array      | Index-based access | O(1)\*     | O(1) by index   | O(n)  |
| Stack              | LIFO operations    | O(1)       | O(1) top only   | O(n)  |
| Queue              | FIFO operations    | O(1)       | O(1) front only | O(n)  |
| Set                | Unique items       | O(1)\*     | O(1)\*          | O(n)  |
| Map                | Key-value lookup   | O(1)\*     | O(1)\*          | O(n)  |
| Linked List        | Dynamic insertion  | O(1)\*     | O(n)            | O(n)  |
| Binary Search Tree | Sorted data        | O(log n)\* | O(log n)\*      | O(n)  |

\*Average case performance

---

## Key Insights from CSE 212:

1. **Choose the right tool**: Each data structure excels at specific operations
2. **Trade-offs matter**: Fast insertion might mean slower search (and vice versa)
3. **Memory layout affects performance**: Contiguous (arrays) vs scattered (linked lists)
4. **Balance is crucial**: BSTs perform best when balanced
5. **Hash tables provide O(1) magic**: But require good hash functions
6. **Recursion simplifies tree operations**: Most tree algorithms are naturally recursive
