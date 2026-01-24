using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
public void TestPriorityQueue_1()
{
    // Scenario: Enqueue items with different priorities.
    // Expected Result: Dequeue returns highest priority first.
    // Defect(s) Found: (fill after running) 

    var queue = new PriorityQueue();
    queue.Enqueue("low", 1);
    queue.Enqueue("high", 5);
    queue.Enqueue("mid", 3);

    Assert.AreEqual("high", queue.Dequeue());
    Assert.AreEqual("mid", queue.Dequeue());
    Assert.AreEqual("low", queue.Dequeue());
}

[TestMethod]
public void TestPriorityQueue_2()
{
    // Scenario: If two items share highest priority, FIFO order among them.
    // Expected Result: Dequeue returns the earliest enqueued among tied highest priority.
    // Defect(s) Found: (fill after running)

    var queue = new PriorityQueue();
    queue.Enqueue("A", 5);
    queue.Enqueue("B", 5);
    queue.Enqueue("C", 3);

    Assert.AreEqual("A", queue.Dequeue()); // same priority as B, but A came first
    Assert.AreEqual("B", queue.Dequeue());
    Assert.AreEqual("C", queue.Dequeue());

    // Empty queue should throw InvalidOperationException with exact message
    try
    {
        queue.Dequeue();
        Assert.Fail("Expected an InvalidOperationException to be thrown.");
    }
    catch (InvalidOperationException ex)
    {
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}

}