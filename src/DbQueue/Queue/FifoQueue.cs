namespace DbQueue.Queue;

public class FifoQueue
{
    public List<string> Queue = new();
    public void Enqueue(string test)
    {
        Queue.Add(test);
    }
}