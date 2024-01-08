using System;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame
{
    /// <summary>
    /// Untuk tracking node.
    /// </summary>
    public interface INodeTracker
    {
        /// <summary>
        /// Update node yang berhasil di deteksi.
        /// </summary>
        /// <param name="index">
        /// Index node yang dideteksi.
        /// </param>
        void DetectNode(int index);

        /// <summary>
        /// Dipanggil ketika gagal memanggi node.
        /// </summary>
        void FailDetectNode();

        /// <summary>
        /// Event yang dipanggil ketika sukses tracking semua node.
        /// </summary>
        Action OnSuccess { get; set; }

        /// <summary>
        /// Event yang dipanggil ketika gagal tracking node.
        /// </summary>
        Action OnFailure { get; set; }
    }
}