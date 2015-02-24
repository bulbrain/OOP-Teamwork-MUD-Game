namespace ForsakenLands.Attributes
{
    using System.Collections.Generic;

    public interface Stats : IBaseSats, IDynamicStats
    {
        Attribute AttackPoints { get; set; }

        Attribute DefencePoints { get; set; }

        Attribute HealthPoints { get; set; }

        Attribute ManaPoints { get; set; }

        Attribute Accuracy { get; set; }

        Attribute Evasion { get; set; }

        Attribute Range { get; set; }
    }
}
