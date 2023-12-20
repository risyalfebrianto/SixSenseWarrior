using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame
{
    /// <summary>
    /// Node pada game yang digunakan untuk mendeteksi input player.
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// Index node.
        /// </summary>
        int Index { get; set; }
    }
}