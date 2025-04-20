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

        }

        public static void ProcessShape(object shape)
        {
            if (shape is Circle c)
            {
                double radius = Convert.ToDouble(c.Radius);
                Console.WriteLine($"Circle with radius: {radius}");
            }
            else if (shape is Square s)
            {
                double perimeter = Convert.ToDouble(s.Perimeter);
                Console.WriteLine($"Square with side: {perimeter}");
            }
        }
    }
}
