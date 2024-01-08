using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.Holder;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Generator
{
    /// <summary>
    /// Untuk generate enemy.
    /// </summary>
    public class HeroGenerator : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari hero.
        /// </summary>
        private IFactory<GameObject> _heroFactory = null;

        /// <summary>
        /// Untuk menyimpan hero dan musuh yang ada didalam game.
        /// </summary>
        private IHolder _characterHolder = null;

        /// <summary>
        /// Parent dari hero yang di generate.
        /// </summary>
        private Transform _parent = null;

        #endregion

        #region Mono

        private void Awake()
        {
            _characterHolder.AddEnemy(_heroFactory.Create(_parent));
        }

        #endregion
    }
}