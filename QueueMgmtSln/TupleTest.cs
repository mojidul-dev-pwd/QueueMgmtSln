namespace QueueMgmtSln
{
    public class TupleTest
    {
        public (int sum, int prod) Calculate(int a, int b)
        {
            return (a + b, a * b);
        }
    }
}
