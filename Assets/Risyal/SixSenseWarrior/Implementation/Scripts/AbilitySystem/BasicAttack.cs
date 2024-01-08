using Assets.Risyal.SixSenseWarrior.Core.Scripts;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.AbilitySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.Projectile;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.AbilitySystem
{
    /// <summary>
    /// Implementasi IBasicAttack.
    /// </summary>
    public class BasicAttack : MonoBehaviour, IBasicAttack
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari projectile.
        /// </summary>
        private IFactory<IProjectile> _projectileFactory = null;

        /// <summary>
        /// Target serangan yang di kunci.
        /// </summary>
        private IAttackTarget _attackTarget = null;

        #endregion

        #region IAbility

        public IStat AttackStat { get; private set; } = null;

        public IStat TimeToHitStat { get; private set; } = null;


        public void Execute()
        {
            var projectile = _projectileFactory.Create();

            projectile.Setup(AttackStat.Value, TimeToHitStat.Value, _attackTarget.Target.GetTransform());
        }

        #endregion
    }
}