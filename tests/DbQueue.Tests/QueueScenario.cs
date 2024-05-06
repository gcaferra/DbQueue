using DbQueue.Queue;
using FluentAssertions;
using Xunit;

namespace Queue.Tests;

public class QueueScenario
{
    FifoQueue _queue;

    public QueueScenario()
    {
        _queue = new FifoQueue();
    }

    [Fact]
    void A_Generic_Item_can_be_Queued()
    {

        _queue.Enqueue("Test");

        _queue.Queue.Should().Contain("Test");
    }

    [Fact]
    void Items_in_queue_can_be_dequeue()
    {
        _queue.Enqueue("Test");

        var actual = _queue.Dequeue();

        actual.Should().Be("Test");
    }

    [Fact]
    void Items_in_queue_can_be_dequeue_in_order()
    {
        _queue.Enqueue("Test1");
        _queue.Enqueue("Test2");
        _queue.Enqueue("Test3");

        _queue.Dequeue().Should().Be("Test1");
        _queue.Dequeue().Should().Be("Test2");
        _queue.Dequeue().Should().Be("Test3");

    }

}