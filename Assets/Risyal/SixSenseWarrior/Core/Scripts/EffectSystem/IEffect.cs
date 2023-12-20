namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.EffectSystem
{
    /// <summary>
    /// Menangani efek yang ada pada game.
    /// </summary>
    public interface IEffect
    {
        /// <summary>
        /// Untuk mengaktifkan efek.
        /// </summary>
        /// <param name="target">
        /// Target dari efek yang aktif.
        /// </param>
        /// <param name="parameters">
        /// Parameter yang digunakan untuk memberikan efek.
        /// </param>
        void ApplyEffect(object target, params object[] parameters);
    }
}