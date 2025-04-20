namespace QueueMgmtSln
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class TicketBooking
    {
        Queue<Customer> queue;
        public TicketBooking()
        {
            queue = new Queue<Customer>();
        }

        public void AddToQueue(Customer customer)
        {
            queue.Enqueue(customer);
            Thread.Sleep(1000);
            Console.WriteLine($"Added to queue: {customer.Name}");
        }

        public void ProcessBooking()
        {
            if (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count; i++)
                {
                    var customer = queue.Dequeue();
                    Thread.Sleep(1000);
                    Console.WriteLine($"Process booking for : {customer.Name}");
                }
            }
        }

        public void ShowQueue()
        {
            Console.WriteLine("\t\n Current Queue");
            Console.WriteLine("\t..............");

            foreach (var customer in queue)
            {
                Thread.Sleep(500);
                Console.WriteLine($"\t{customer.Name}");

            }
        }

    }
}
