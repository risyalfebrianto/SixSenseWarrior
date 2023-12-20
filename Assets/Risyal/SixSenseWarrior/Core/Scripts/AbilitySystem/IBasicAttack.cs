using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.AbilitySystem
{
    /// <summary>
    /// Menangani basic attack suatu entitas.
    /// </summary>
    public interface IBasicAttack : IAbility
    {
        /// <summary>
        /// Stat yang dimiliki untuk menyerang.
        /// </summary>
        IStat AttackStat { get; }

        /// <summary>
        /// Stat yang digunakan untuk menghitung kecepatan kena serangan.
        /// </summary>
        IStat TimeToHitStat { get; }
    }
}