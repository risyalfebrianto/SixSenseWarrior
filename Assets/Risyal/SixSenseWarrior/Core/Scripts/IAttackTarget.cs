
using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts
{
    /// <summary>
    /// Menyimpan target serangan yang di lock oleh entitas.
    /// </summary>
    public interface IAttackTarget
    {
        /// <summary>
        /// Target yang dikunci.
        /// </summary>
        ITarget Target { get; }

        /// <summary>
        /// Untuk update target yang dikunci.
        /// </summary>
        void UpdateTarget(ITarget target);
    }
}