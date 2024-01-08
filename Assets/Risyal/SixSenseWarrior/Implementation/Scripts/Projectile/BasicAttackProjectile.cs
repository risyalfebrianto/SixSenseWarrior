using Assets.Risyal.SixSenseWarrior.Core.Scripts.EffectSystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.Projectile;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.ObjectPooling;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Projectile
{
    /// <summary>
    /// Implementasi IProjectile.
    /// </summary>
    public class BasicAttackProjectile : PooledObject, IProjectile
    {
        #region Variable

        /// <summary>
        /// Besarnya serangan yang dimiliki projectile.
        /// </summary>
        private float _attackPoint = 0;

        /// <summary>
        /// Waktu yang diperlukan agar projectile sampai target.
        /// </summary>
        private float _timeToHit = 0;

        /// <summary>
        /// Target dari projectile.
        /// </summary>
        private Transform _target = null;

        /// <summary>
        /// Menangani pembuatan dari efek.
        /// </summary>
        private IFactory<IEffect> _effectFactory = null;

        #endregion

        #region IProjectile

        public void Setup(params object[] parameters)
        {
            _attackPoint = (float)parameters[0];
            _timeToHit = (float)parameters[1];
            _target = (Transform)parameters[2];
        }

        #endregion

        #region Mono

        private void Awake()
        {
            
        }

        private void OnEnable()
        {
            var effect = _effectFactory.Create();

            effect.ApplyEffect(_target, _attackPoint);

            gameObject.SetActive(false);
        }

        #endregion
    }
}