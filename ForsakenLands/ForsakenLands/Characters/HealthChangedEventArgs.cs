namespace ForsakenLands.Characters
{
    using System;

    internal class HealthChangedEventArgs : EventArgs
    {
        public HealthChangedEventArgs(int healthPoints)
        {
            this.NewHealthPoints = healthPoints;
        }

        public int NewHealthPoints { get; set; }
    }
}
