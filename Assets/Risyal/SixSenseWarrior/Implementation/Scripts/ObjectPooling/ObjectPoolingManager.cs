using Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.ObjectPooling
{
    /// <summary>
    /// Implementasi IObjectPooling.
    /// </summary>
    [CreateAssetMenu(fileName = "ObjectPoolingManager", menuName = "Risyal/Assets/ObjectPooling")]
    public class ObjectPoolingManager : ScriptableObject, IObjectPooling
    {
        #region Variable

        /// <summary>
        /// Source dari object pooling.
        /// </summary>
        [SerializeField]
        private PooledObject prefab = null;

        /// <summary>
        /// Semua object yang dipooling.
        /// </summary>
        private List<IPooledObject> _pooledObjects = new List<IPooledObject>();

        #endregion

        #region IObjectPooling

        public IPooledObject GetFreeObject()
        {
            foreach (var objectPooling in _pooledObjects)
            {
                if (objectPooling.IsActive) 
                {
                    return objectPooling;
                }
            }

            var newObject = Instantiate(prefab);

            _pooledObjects.Add(newObject);

            return newObject;
        }

        public void Clear()
        {
            _pooledObjects.Clear();
        }

        #endregion
    }
}