using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Holder
{
    /// <summary>
    /// Untuk menyimpan sementara entitas hero dan musuh pada game.
    /// </summary>
    public interface IHolder
    {
        /// <summary>
        /// Semua karakter hero yang ada dalam game.
        /// </summary>
        List<GameObject> Heroes { get; }

        /// <summary>
        /// Semua karakter musuh yang ada dalam game.
        /// </summary>
        List<GameObject> Enemies { get; }

        /// <summary>
        /// Untuk menambahkan hero.
        /// </summary>
        /// <param name="hero">
        /// Hero yang ditambahkan.
        /// </param>
        void AddHero(GameObject hero);

        /// <summary>
        /// Untuk menambahkan enemy.
        /// </summary>
        /// <param name="enemy">
        /// Enemy yang ditambahkan.
        /// </param>
        void AddEnemy(GameObject enemy);

        /// <summary>
        /// Untuk mendapatkan karakter hero.
        /// </summary>
        /// <param name="id">
        /// Id dari karakter hero yang ingin didapatkan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa GameObject.
        /// </returns>
        GameObject GetHero(string id);

        /// <summary>
        /// Untuk mendapatkan karakter musuh.
        /// </summary>
        /// <param name="id">
        /// Id dari karakter musuh yang ingin didapatkan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa GameObject.
        /// </returns>
        GameObject GetEnemy(string id);
    }
}