namespace D6.FootBall
{
    internal class FootBallPlayer : Player
    {
        public override void OnBallPositionChanged(object obj, EventArgs e)
        {
            Ball b = (Ball) obj;
            Console.WriteLine($"the poistion of the FootBall player {Name} has changed from {X}-{Y} to {b.X}-{b.Y}");
        }
    }
}
