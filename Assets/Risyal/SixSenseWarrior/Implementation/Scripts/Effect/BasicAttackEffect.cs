using Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.EffectSystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.Formula;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Formula;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Effect
{
    /// <summary>
    /// Implementasi IEffect untuk basic attack.
    /// </summary>
    public class BasicAttackEffect : MonoBehaviour, IEffect
    {
        #region Variable

        /// <summary>
        /// Menangani perhitungan damage pada basic attack.
        /// </summary>
        private IFormula _basicDamageFormula = null;

        #endregion

        #region IEffect

        public void ApplyEffect(object target, params object[] parameters)
        {
            var targetGameObject = (GameObject)target;
            var targetHealth = targetGameObject.GetComponent<IHealth>();
            var targetDefence = targetGameObject.GetComponent<IDefence>();

            var attackPoint = (float)parameters[0];

            targetHealth.ReduceHealth(_basicDamageFormula.Calculate(attackPoint, targetDefence));

            gameObject.SetActive(false);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _basicDamageFormula = new DamageFormula();
        }

        #endregion
    }
}