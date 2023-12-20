using Assets.Risyal.SixSenseWarrior.Core.Scripts.InputSystem;
using System;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.InputSystem
{
    /// <summary>
    /// Implementasi IInput.
    /// </summary>
    public class Input : MonoBehaviour, IInput
    {
        #region IInput

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public bool Disabled { get; set; } = false;

        #endregion
    }

    /// <summary>
    /// Implementasi IInput<T>.
    /// </summary>
    /// <typeparam name="T">
    /// Semua jenis tipe yang ada pada program.
    /// </typeparam>
    public abstract class Input<T> : Input, IInput<T>
    {
        #region IInput<T>

        public T Value { get; protected set; } = default(T);

        public Action<T> OnValueChanged { get; set; } = null;

        #endregion
    }
}