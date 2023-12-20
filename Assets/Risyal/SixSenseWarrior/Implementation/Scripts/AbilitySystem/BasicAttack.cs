using Assets.Risyal.SixSenseWarrior.Core.Scripts.AbilitySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.StatsSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.AbilitySystem
{
    /// <summary>
    /// Implementasi IBasicAttack.
    /// </summary>
    public class BasicAttack : MonoBehaviour, IBasicAttack
    {
        #region IAbility

        public IStat AttackStat { get; private set; } = null;

        public IStat TimeToHitStat { get; private set; } = null;


        public void Execute()
        {

        }

        #endregion
    }
}