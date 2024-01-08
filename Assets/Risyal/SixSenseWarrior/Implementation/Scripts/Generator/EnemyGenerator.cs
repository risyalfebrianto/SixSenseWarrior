using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.Holder;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Generator
{
    /// <summary>
    /// Untuk generate enemy.
    /// </summary>
    public class EnemyGenerator : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari musuh.
        /// </summary>
        private IFactory<GameObject> _enemyFactory = null;

        /// <summary>
        /// Untuk menyimpan karakter dan musuh yang ada didalam game.
        /// </summary>
        private IHolder _characterHolder = null;

        /// <summary>
        /// Parent dari enemy yang di generate.
        /// </summary>
        private Transform _parent = null;

        #endregion

        #region Mono

        private void Awake()
        {
            _characterHolder.AddEnemy(_enemyFactory.Create(_parent));
        }

        #endregion
    }
}