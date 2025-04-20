namespace QueueMgmtSln
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://medium.com/@kmorpex/10-advanced-c-tricks-for-experienced-developers-26a48c6a8c9c
            //Leveraging Tuples for Multiple Return Values
            TupleTest tupleTest = new TupleTest();
            var tuple = tupleTest.Calculate(12, 13);
            Console.WriteLine("Sum = "+tuple.sum+ "\nMultiple = " + tuple.prod);

            //Pattern Matching Enhancements(বর্ধিতকরণ)
            Circle circle = new Circle();
            ProcessShape(circle);
            Square square = new Square();
            ProcessShape(square);

            Console.ReadKey();

        }

        public static void ProcessShape(object shape)
        {
            if (shape is Circle c)
            {
                var d1 = c.Radius;
                double radius = d1.Invoke();
                Console.WriteLine($"Radius of Circle: {radius}");
            }
            else if (shape is Square s)
            {
                var d2 = s.Perimeter;
                double perimeter = d2.Invoke();
                Console.WriteLine($"Perimeter of Square: {perimeter}");
            }
        }
    }
}
