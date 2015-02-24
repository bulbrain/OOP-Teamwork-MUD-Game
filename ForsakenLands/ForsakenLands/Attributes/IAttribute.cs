namespace ForsakenLands.Attributes
{
    public interface IAttribute
    {
        int CurrentPoints { get; set; }

        int MaxPoints { get; set; }
    }
}
