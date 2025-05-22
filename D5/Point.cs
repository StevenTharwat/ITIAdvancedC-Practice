namespace D5
{
    internal class Point
    {
        public required int x { get; set; }
        public required int y { get; set; }

        public int Add(int x1, int y1, int z1)
        {
            Console.WriteLine($"point {x}");
            return x + y + z1;
        }
    }
}
