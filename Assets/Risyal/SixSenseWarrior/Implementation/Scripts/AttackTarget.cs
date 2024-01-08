using Assets.Risyal.SixSenseWarrior.Core.Scripts;
using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts
{
    /// <summary>
    /// Implementasi IAttackTarget.
    /// </summary>
    public class AttackTarget : MonoBehaviour, IAttackTarget
    {
        #region IAttackTarget

        public ITarget Target { get; private set; } = null;

        public void UpdateTarget(ITarget target)
        {
            Target = target;
        }

        #endregion
    }
}