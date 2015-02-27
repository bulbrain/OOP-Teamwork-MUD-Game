namespace ForsakenLands.Interfaces
{
    public interface IExperiancable : ILevelable
    {
        int CurrentExperience { get; }

        int ExperienceToNextLevel { get; }

        void AddExperience(int experienceToAd);

    }
}