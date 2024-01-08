using System;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.TimerSystem
{
    /// <summary>
    /// Menangani atimer pada game.
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// Waktu pada timer yang dijalankan.
        /// </summary>
        float Time { get; set; }

        /// <summary>
        /// Untuk memulai timer.
        /// </summary>
        void StartTime();

        /// <summary>
        /// Untuk memberhentikan timer.
        /// </summary>
        void StopTime();

        /// <summary>
        /// Event yang dipanggil ketika timer dimulai.
        /// </summary>
        Action OnStartTimer { get; set; }

        /// <summary>
        /// Event yang dipanggil ketika timer berhenti.
        /// </summary>
        Action OnStopTimer { get; set; }
    }
}