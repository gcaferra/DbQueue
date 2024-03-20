using DbQueue;
using FluentAssertions;
using Xunit;

namespace Queue.Tests;

public class QueueScenario
{
    [Fact]
    void A_Generic_Item_can_be_Queued()
    {
        var queue = new DbQueue.DbQueue();

        queue.Enqueue("Test");

        queue.Queue.Should().Contain("Test");
    }
}