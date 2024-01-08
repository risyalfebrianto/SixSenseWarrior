namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.AbilitySystem
{
    /// <summary>
    /// Menangani ability pada suatu object.
    /// </summary>
    public interface IAbility
    {
        /// <summary>
        /// Untuk eksekusi ability yang dimiliki oleh suatu entitas.
        /// </summary>
        void Execute();
    }
}