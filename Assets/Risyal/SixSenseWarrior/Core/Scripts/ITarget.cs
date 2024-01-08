using System;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts
{
    /// <summary>
    /// Menagnani target pada suatu entitas.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Id dari target.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Untuk mendapatkan posisi dari target.
        /// </summary>
        /// <returns>
        /// Mengembalikan nilai berupa Transform.
        /// </returns>
        Transform GetTransform();

        /// <summary>
        /// Event yang dipanggil ketika target hancur.
        /// </summary>
        Action OnTargetDestroyed { get; set; }
    }
}