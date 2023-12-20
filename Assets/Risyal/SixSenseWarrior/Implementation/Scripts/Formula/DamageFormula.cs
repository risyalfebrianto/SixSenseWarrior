using Assets.Risyal.SixSenseWarrior.Core.Scripts.Formula;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Formula
{
    /// <summary>
    /// Menangani formula perhitungan dari attack.
    /// </summary>
    public class DamageFormula : IFormula
    {
        #region IFormula

        public float Calculate(params object[] parameters)
        {
            var attackPoint = (float)parameters[0];
            var defencePoint = (float)parameters[1];

            var damage = Mathf.Clamp(attackPoint - defencePoint, 0, 1000);

            return damage;
        }

        #endregion
    }
}