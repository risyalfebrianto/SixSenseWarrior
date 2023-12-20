using Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.RhythmGame
{
    /// <summary>
    /// Implementasi INode.
    /// </summary>
    public class Node : MonoBehaviour, INode
    {
        #region INode

        public int Index { get; set; } = 0;

        #endregion
    }
}