﻿using Assets.Risyal.SixSenseWarrior.Core.Scripts.StatsSystem;
using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Attribute
{
    /// <summary>
    /// Menangani kecepatan dari suatu entitas.
    /// </summary>
    public interface ISpeed
    {
        /// <summary>
        /// Stat kecepatan pada suatu entitas.
        /// </summary>
        IStat SpeedStat { get; }
    }
}