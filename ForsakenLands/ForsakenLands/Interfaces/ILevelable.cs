namespace ForsakenLands.Interfaces
{
    public interface ILevelable
    {
        int Level { get; }

        int CalculateStatAccordingToLevel(int stat);
    }
}