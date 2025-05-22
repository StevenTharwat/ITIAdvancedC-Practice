namespace D6.FootBall
{
    internal class Stadium
    {
        public Ball CurrentBall { get; }
        public List<Player> PlayerList { get; } = [];
        public Stadium(Ball _currentBall)
        {
            CurrentBall = _currentBall;
        }
        public void AddPlayer(Player player)
        {
            PlayerList.Add(player);
            CurrentBall.BallPositionChanged += player.OnBallPositionChanged;
        }
        public void RemovePlayer(Player player)
        {
            PlayerList.Remove(player);
            CurrentBall.BallPositionChanged -= player.OnBallPositionChanged;
        }

    }
}
