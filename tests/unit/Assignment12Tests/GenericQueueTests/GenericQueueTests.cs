using CollectionAndGenerics;

namespace CollectionAndGenericsTests
{
    public class GenericQueueTests
    {
        private static GenericQueue<string> QueueOfNames { get; set; } = new();

        [Fact]
        public void ValidNamesGiven_EnqueueNames_UpdatedQueue()
        {
            Console.SetIn(new StringReader("Ancy"));
            Queue.EnqueueNames();
            Assert.True(QueueOfNames.QueueCount == 1);
        }

        [Fact]
        public void NonEmptyQueue_DequeueNames_UpdatedQueue()
        {
            QueueOfNames.AddName("a");
            Queue.DequeueNames();
            Assert.True(QueueOfNames.QueueCount == 0);
        }
    }
}
