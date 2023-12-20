using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using System;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute
{
    /// <summary>
    /// Menangani health pada suatu object.
    /// </summary>
    public interface IHealth
    {
        /// <summary>
        /// Health object yang dimiliki.
        /// </summary>
        IStat Hp { get; }

        /// <summary>
        /// Max health object yang dimiliki.
        /// </summary>
        IStat MaxHp { get; }

        /// <summary>
        /// Untuk menambah nilai health pada suatu object.
        /// </summary>
        /// <param name="value">
        /// Nilai dari health.
        /// </param>
        void AddHealth(float value)
        {
            var newValue = Mathf.Clamp(Hp.BaseValue + value, 0, MaxHp.Value);

            Hp.SetBaseValue(newValue);

            OnHealthChanged?.Invoke(newValue);
        }

        /// <summary>
        /// Untuk mengurangi nilai health pada suatu object.
        /// </summary>
        /// <param name="value">
        /// Nilai dari health.
        /// </param>
        void ReduceHealth(float value)
        {
            var newValue = Mathf.Clamp(Hp.BaseValue - value, 0, MaxHp.Value);

            Hp.SetBaseValue(newValue);

            OnHealthChanged?.Invoke(newValue);
        }

        /// <summary>
        /// Event yang dipanggil ketika health diganti.
        /// </summary>
        Action<float> OnHealthChanged { get; set; }
    }
}