namespace _03._04
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class PrintQueue
    {
        private Queue<(string Document, Priority Priority)> queue = new Queue<(string, Priority)>();
        public void EnqueueDocument(string document, Priority priority)
        {
            queue.Enqueue((document, priority));
        }
        public string DequeueDocument()
        {
            if (queue.Count == 0)
            {
                return "Queue is empty";
            }
            else
            {
                var nextDocument = queue.Dequeue();
                return $"Printing document: {nextDocument.Document}, Priority: {nextDocument.Priority}";
            }
        }
        public bool HasDocuments()
        {
            return queue.Count > 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrintQueue printQueue = new PrintQueue();
            printQueue.EnqueueDocument("Document 1", Priority.Medium);
            printQueue.EnqueueDocument("Document 2", Priority.Low);
            printQueue.EnqueueDocument("Document 3", Priority.High);
            while (printQueue.HasDocuments())
            {
                Console.WriteLine(printQueue.DequeueDocument());
            }
        }
    }
}
