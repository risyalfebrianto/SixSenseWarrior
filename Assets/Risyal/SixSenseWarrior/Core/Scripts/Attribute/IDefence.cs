using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute
{
    /// <summary>
    /// Menangani attribute defence pada suatu entitas.
    /// </summary>
    public interface IDefence
    {
        /// <summary>
        /// Stat defence yang dimiliki oleh suatu entitas.
        /// </summary>
        IStat DefencePoint { get; }
    }
}