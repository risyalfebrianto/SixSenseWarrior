namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Level
{
    /// <summary>
    /// Menangani level yang ada didalam game.
    /// </summary>
    public interface ILevel
    {
        /// <summary>
        /// Level game pada saat ini.
        /// </summary>
        int CurrentLevel { get; }

        /// <summary>
        /// Untuk menambah level.
        /// </summary>
        /// <param name="amount">
        /// Jumlah level yang ditambah.
        /// </param>
        void IncreaseLevel(int amount);

        /// <summary>
        /// Untuk mengurangi level.
        /// </summary>
        /// <param name="amount">
        /// Jumlah level yang dikurangi.
        /// </param>
        void DecreaseLevel(int amount);
    }
}