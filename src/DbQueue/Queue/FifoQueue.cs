namespace DbQueue.Queue;

public class FifoQueue
{
    public readonly Queue<string> Queue = new();
    public void Enqueue(string test) => Queue.Enqueue(test);

    public string Dequeue() => Queue.Dequeue();
}