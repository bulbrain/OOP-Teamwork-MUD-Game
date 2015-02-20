namespace ForsakenLands.Interfaces
{
    public interface IRegenerable
    {
        int Lives { get; set; }

        void AddLive();

        void RemoveLive();

        void Regenerate();
    }
}
