using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: get the highest priority item from the queue
    // Expected Result: Will my priority queue return the item with the highest priority first? and then on?
    // Defect(s) Found: it was not removing the high priority item; it was not going until the end of the list.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Test 1 should be last", 1);
        priorityQueue.Enqueue("Test 2 should be first", 5);
        priorityQueue.Enqueue("Test 3 should be second", 3);

        var highPriority = priorityQueue.Dequeue(); // Should return "Test 2 should be first"
        var mediumPriority = priorityQueue.Dequeue(); // Should return "Test 3 should be second"

        // Assert.Fail("Implement the test case and then remove this.");
        if (highPriority != "Test 2 should be first")
            Assert.Fail("Failed: " + highPriority);
        else
            Assert.IsTrue(true);
        if (mediumPriority != "Test 3 should be second")
            Assert.Fail("Failed: " + mediumPriority);
        else
            Assert.IsTrue(true);

    }

    [TestMethod]
    // Scenario: try to dequeue from an empty queue
    // Expected Result: if the list is empty and I try to dequeue, does it throw an exception with the appropriate error message?
    // Defect(s) Found: none :)
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            var emptyList = priorityQueue.Dequeue(); // empty list
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}