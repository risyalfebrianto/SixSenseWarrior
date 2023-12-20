using System;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.InputSystem
{
    /// <summary>
    /// Menangani input yang ada pada game.
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// Id dari input.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Indikasi apakah input di disable atau tidak.
        /// </summary>
        bool Disabled { get; set; }
    }

    /// <summary>
    /// Input yang ada pada game.
    /// </summary>
    /// <typeparam name="T">
    /// Semua nilai tipe yang ada pada game.
    /// </typeparam>
    public interface IInput<T> : IInput
    {
        /// <summary>
        /// Nilai dari input.
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Event yang dipanggil ketika nilai diganti.
        /// </summary>
        Action<T> OnValueChanged { get; set; }
    }
}