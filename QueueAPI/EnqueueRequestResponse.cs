namespace QueueAPI;

public class EnqueueRequestResponse
{
    public string TaskID;
    public HttpResponseMessage WorkerQueueResponse { get; set; }
}