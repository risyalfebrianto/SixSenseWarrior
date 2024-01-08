using Assets.Risyal.SixSenseWarrior.Core.Scripts;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts
{
    /// <summary>
    /// Implementasi ITarget.
    /// </summary>
    public class Target : MonoBehaviour, ITarget
    {
        #region ITarget

        public string Id => gameObject.name;

        public Transform GetTransform()
        {
            return gameObject.transform;
        }

        public Action OnTargetDestroyed { get; set; } = null;

        #endregion
    }
}