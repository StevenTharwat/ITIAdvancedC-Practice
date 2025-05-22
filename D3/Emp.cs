namespace D3
{
    internal class Emp
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            Emp input = (Emp) obj;
            return input.ID == ID && input.Name == Name && input.Age == Age;
        }
    }
}
