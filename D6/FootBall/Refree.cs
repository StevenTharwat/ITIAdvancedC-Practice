namespace D6.FootBall
{
    internal class Refree : Player
    {
        public override void OnBallPositionChanged(object obj, EventArgs e)
        {
            Ball b = (Ball) obj;
            Console.WriteLine($"the poistion Refree {Name} has changed from {X}-{Y} to {b.X}-{b.Y}");
        }
    }
}
