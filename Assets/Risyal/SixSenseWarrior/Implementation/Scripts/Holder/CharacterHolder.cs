using Assets.Risyal.SixSenseWarrior.Core.Scripts.Holder;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Holder
{
    /// <summary>
    /// Implementasi IHolder.
    /// </summary>
    public class CharacterHolder : MonoBehaviour, IHolder
    {
        #region IHolder

        public void AddHero(GameObject hero)
        {
            foreach (var hr in Heroes)
            {
                if (hr != hero)
                {
                    Heroes.Add(hr);
                }
            }
        }

        public void AddEnemy(GameObject enemy)
        {
            foreach (var enmy in Enemies)
            {
                if (enmy != enemy)
                {
                    Heroes.Add(enmy);
                }
            }
        }

        public List<GameObject> Heroes { get; private set; } = new List<GameObject>();

        public List<GameObject> Enemies { get; private set; } = new List<GameObject>();

        public GameObject GetHero(string id)
        {
            foreach (var hero in Heroes)
            {
                if (hero.name == id)
                {
                    return hero;
                }
            }

            return null;
        }

        public GameObject GetEnemy(string id)
        {
            foreach (var enemy in Enemies)
            {
                if (enemy.name == id)
                {
                    return enemy;
                }
            }

            return null;
        }

        #endregion
    }
}