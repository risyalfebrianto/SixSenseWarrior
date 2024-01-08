namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Projectile
{
    /// <summary>
    /// Menangani projectile.
    /// </summary>
    public interface IProjectile
    {
        /// <summary>
        /// Untuk setup projectile.
        /// </summary>
        /// <param name="parameters">
        /// Parameter yang digunakan untuk setup projectile.
        /// </param>
        void Setup(params object[] parameters);
    }
}