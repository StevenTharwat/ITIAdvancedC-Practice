namespace D6.FootBall
{
    internal class Ball
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public event EventHandler? BallPositionChanged;

        public void ChangePosition(int x, int y)
        {
            X = x;
            Y = y;
            BallPositionChanged?.Invoke(this, new EventArgs());
            //ball will send notification to all players 
        }
    }
}
