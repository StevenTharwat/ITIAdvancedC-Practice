namespace D6.FootBall
{
    abstract class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; } = "";
        public abstract void OnBallPositionChanged(object obj, EventArgs e);
    }
}
