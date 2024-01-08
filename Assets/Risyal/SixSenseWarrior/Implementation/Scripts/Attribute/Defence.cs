using Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Attribute
{
    /// <summary>
    /// Implementasi IDefence.
    /// </summary>
    public class Defence : MonoBehaviour, IDefence
    {
        #region IDefence

        public IStat DefencePoint { get; private set; } = null;

        #endregion
    }
}