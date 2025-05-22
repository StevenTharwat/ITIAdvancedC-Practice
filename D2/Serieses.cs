namespace D2
{
    internal class OddSeries : ISeries
    {
        int n = -1;
        public object GetTheNext()
        {
            n = n + 2;
            return n;
        }
    }

    internal class EventSeries : ISeries
    {
        int n = 0;
        public object GetTheNext()
        {
            n = n + 2;
            return n;
        }
    }

    internal class FibSeries : ISeries
    {
        int p = 0;
        int n = 1;
        public object GetTheNext()
        {
            n = p + n;
            p = n - p;
            return p + n;
        }
    }
}
