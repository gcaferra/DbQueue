using DbQueue.Queue;
using FluentAssertions;
using Xunit;

namespace Queue.Tests;

public class QueueScenario
{
    [Fact]
    void A_Generic_Item_can_be_Queued()
    {
        var queue = new FifoQueue();

        queue.Enqueue("Test");

        queue.Queue.Should().Contain("Test");
    }
}