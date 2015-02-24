namespace ForsakenLands.Attributes
{
    public interface IDynamicStats
    {
        Attribute Accuracy { get; set; }

        Attribute Evasion { get; set; }

        Attribute Range { get; set; }
    }
}
