namespace ForsakenLands.Attributes
{
    public interface IBaseSats
    {
        Attribute AttackPoints { get; set; }

        Attribute DefencePoints { get; set; }

        Attribute HealthPoints { get; set; }

        Attribute ManaPoints { get; set; }
    }
}
