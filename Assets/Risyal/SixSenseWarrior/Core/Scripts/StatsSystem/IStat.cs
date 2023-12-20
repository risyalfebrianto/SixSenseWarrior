namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem
{
    /// <summary>
    /// Menangani stat yang dimiliki oleh suatu object pada game.
    /// </summary>
    public interface IStat
    {
        /// <summary>
        /// Id dari stat.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Nilai awal dari stat.
        /// </summary>
        float BaseValue { get; }

        /// <summary>
        /// Nilai saat ini dari stat.
        /// </summary>
        float Value { get; }

        /// <summary>
        /// Untuk mengubah nilai base pada stat.
        /// </summary>
        /// <param name="value">
        /// Nilai base yang dirubah.
        /// </param>
        void SetBaseValue(float value);

        /// <summary>
        /// Untuk update nilai stat.
        /// </summary>
        void UpdateValue();

        /// <summary>
        /// Untuk menambah modifier.
        /// </summary>
        /// <param name="source">
        /// Sumber dari modifier yang ditambah,
        /// </param>
        void AddModifier(IModifier source);

        /// <summary>
        /// Untuk mengurangi modifier.
        /// </summary>
        /// <param name="source">
        /// Sumber dari modifier yang dikurangi.
        /// </param>
        void RemoveModifier(IModifier source);
    }
}