namespace Game
{
    public interface IJumpable
    {
        public bool isJumping { get; set; }
        public int jumpStage { get; set; }
        public void jump();
        public void jump(Dictionary<string, int> point);
    }
}