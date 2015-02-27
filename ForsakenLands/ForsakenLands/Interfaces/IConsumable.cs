namespace ForsakenLands.Interfaces
{
    public interface IConsumable
    {
        int HealthToRestore { get; set; }

        int ManaToRestore { get; set; }
    }
}