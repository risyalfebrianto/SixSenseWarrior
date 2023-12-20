using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.General;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.ObjectPooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Factory
{
    /// <summary>
    /// Implementasi IFactory untuk membuat projectile.
    /// </summary>
    [CreateAssetMenu(fileName = "ProjectileFactory", menuName = "Risyal/Assets/Factory")]
    public class ProjectileFactory : ScriptableObject, IFactory<GameObject>
    {
        #region Variable

        /// <summary>
        /// Menangani object pooling.
        /// </summary>
        [SerializeField]
        private ObjectPoolingManager objectPoolingManager = null;

        #endregion

        #region IFactory<GameObject>

        public GameObject Create(params object[] parameters)
        {
            var newProjectile = objectPoolingManager.GetFreeObject();

            newProjectile.ActivateObject();

            return newProjectile.To<GameObject>();
        }

        #endregion
    }
}