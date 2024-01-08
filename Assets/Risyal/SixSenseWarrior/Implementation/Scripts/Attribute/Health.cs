using Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using System;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Attribute
{
    /// <summary>
    /// Implementasi IHealth.
    /// </summary>
    public class Health : MonoBehaviour, IHealth
    {
        #region IHealth

        public IStat Hp { get; private set; } = null;

        public IStat MaxHp { get; private set; } = null;

        public Action<float> OnHealthChanged { get; set; } = null;

        #endregion
    }
}