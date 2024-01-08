using Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.ObjectPooling
{
    /// <summary>
    /// Implementasi IPooledObject
    /// </summary>
    public class PooledObject : MonoBehaviour, IPooledObject
    {
        #region IPooledObject

        public bool IsActive => gameObject.activeInHierarchy;

        public void ActivateObject()
        {
            gameObject.SetActive(true);
        }

        public void DeactivateObject()
        {
            gameObject.SetActive(false);
        }

        #endregion
    }
}