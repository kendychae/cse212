using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them
    // Expected Result: Items should be dequeued in order of highest priority first
    // Defect(s) Found: 1) Loop didn't check last element 2) Item wasn't removed after finding
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with same priority, should follow FIFO for same priority
    // Expected Result: First item with highest priority should be dequeued first
    // Defect(s) Found: Used >= instead of > in comparison, breaking FIFO for equal priorities
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Try to dequeue from empty queue
    // Expected Result: Should throw InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None - this test passed correctly
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    [TestMethod]
    // Scenario: Mixed priorities with multiple same-priority items
    // Expected Result: Higher priority first, then FIFO within same priority
    // Defect(s) Found: Same bugs as above - confirmed fixes work for complex cases
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 3);
        priorityQueue.Enqueue("E", 1);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // First with priority 3
        Assert.AreEqual("D", priorityQueue.Dequeue()); // Second with priority 3
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Only with priority 2
        Assert.AreEqual("A", priorityQueue.Dequeue()); // First with priority 1
        Assert.AreEqual("E", priorityQueue.Dequeue()); // Second with priority 1
    }
}