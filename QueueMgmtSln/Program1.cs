namespace QueueMgmtSln
{
    class Program1
    {
        static void Main1(string[] args)
        {
            TicketBooking ticketBooking = new TicketBooking();
            ticketBooking.AddToQueue(new Customer { Name = "Mojidul", Age = 45 });
            ticketBooking.AddToQueue(new Customer { Name = "Nayeem", Age = 13 });
            ticketBooking.AddToQueue(new Customer { Name = "Sharmin", Age = 37 });
            ticketBooking.AddToQueue(new Customer { Name = "Fatima", Age = 5 });
            //Console.ReadKey(); 
            ticketBooking.ShowQueue();

            //Console.ReadKey();
            Console.WriteLine("Adding more customers to the queue");
            ticketBooking.AddToQueue(new Customer { Name="Jahurul", Age=65});
            ticketBooking.AddToQueue(new Customer { Name="Moriom", Age=58});

            Console.ReadKey();
            ticketBooking.ShowQueue();

            Console.ReadKey();
            Console.WriteLine("Booking process started");
            ticketBooking.ProcessBooking();

            Console.ReadKey();
            //https://www.youtube.com/watch?v=syqetzAkz-g

            //Event Handler
            //https://www.akadia.com/services/dotnet_delegates_and_events.html
            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // Create a Log object and tell it
            // to subscribe to the clock
            LogClock lc = new LogClock();
            lc.Subscribe(theClock);

            // Get the clock started
            theClock.Run();            

        }
    }
}
