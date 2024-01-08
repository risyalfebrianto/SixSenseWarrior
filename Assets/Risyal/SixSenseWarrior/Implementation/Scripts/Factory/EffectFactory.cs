using Assets.Risyal.SixSenseWarrior.Core.Scripts.EffectSystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.General;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.ObjectPooling;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Factory
{
    /// <summary>
    /// Implementasi IFactory<IEffect>.
    /// </summary>
    [CreateAssetMenu(fileName = "EffectFactory", menuName = "Risyal/Assets/Factory")]
    public class EffectFactory : ScriptableObject, IFactory<IEffect>
    {
        #region Variable

        /// <summary>
        /// Semua pooling manager milik efek.
        /// </summary>
        [SerializeField]
        private List<ObjectPoolingManager> poolingManagers = new List<ObjectPoolingManager>();

        #endregion

        #region IFactory<IEffect>

        public IEffect Create(params object[] parameters)
        {
            var id = (string)parameters[0];

            IObjectPooling objectPooling = null;

            foreach (var manager in poolingManagers)
            {
                if (manager.name == id) 
                {
                    objectPooling = manager;

                    break;
                }
            }

            var effect = objectPooling.GetFreeObject();

            effect.ActivateObject();

            return effect.To<IEffect>();
        }

        #endregion
    }
}