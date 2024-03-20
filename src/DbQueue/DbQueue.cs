namespace DbQueue;

public class DbQueue
{
    public List<string> Queue = new();
    public void Enqueue(string test)
    {
        Queue.Add(test);
    }
}