namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem
{
    /// <summary>
    /// Untuk modify 
    /// </summary>
    public interface IModifier
    {
        /// <summary>
        /// Id dari modifier.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Nilai dari modifier
        /// </summary>
        float Value { get; }

        /// <summary>
        /// Tipe dari modifier.
        /// </summary>
        ModifierType ModifierType { get; }
    }

    /// <summary>
    /// Tipe modifier yang tersedia.
    /// </summary>
    public enum ModifierType
    {
        Add,
        Multiplier,
        Percentage
    }
}