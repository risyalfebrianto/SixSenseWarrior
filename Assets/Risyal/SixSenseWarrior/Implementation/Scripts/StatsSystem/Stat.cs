using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.StatsSystem
{
    /// <summary>
    /// Implementasi IStat.
    /// </summary>

    public class Stat : MonoBehaviour, IStat
    {
        #region Variable

        /// <summary>
        /// Semua modifier yang ada pada stat.
        /// </summary>
        private List<IModifier> _modifiers = new();

        #endregion

        #region Constructor

        public Stat(string id, float baseValue, float value)
        {
            Id = id;
            BaseValue = baseValue;
            Value = value;
        }

        #endregion

        #region IStat

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public float BaseValue { get; private set; } = 0;

        public float Value { get; private set; } = 0;

        public void AddModifier(IModifier source)
        {
            var modifier = _modifiers.FirstOrDefault(x => x.Id == source.Id);

            if (modifier != null)
            {
                _modifiers.Remove(modifier);
            }

            _modifiers.Add(modifier);

            UpdateValue();
        }

        public void RemoveModifier(IModifier source)
        {
            var modifier = _modifiers.FirstOrDefault(x => x.Id == source.Id);

            if (modifier != null)
            {
                _modifiers.Remove(modifier);
            }

            UpdateValue();
        }

        public void SetBaseValue(float value)
        {
            BaseValue = value;

            UpdateValue();
        }

        public void UpdateValue()
        {
            Value = BaseValue;

            foreach (var modifier in _modifiers)
            {
                switch (modifier.ModifierType) 
                {
                    case ModifierType.Add:

                        Value += modifier.Value;

                        break;
                    case ModifierType.Multiplier: 

                        Value *= modifier.Value;

                        break;
                    case ModifierType.Percentage:

                        Value += BaseValue * modifier.Value / 100;

                        break;
                }
            }
        }

        #endregion
    }
}