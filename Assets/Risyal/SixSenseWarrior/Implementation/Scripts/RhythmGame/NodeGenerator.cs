using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.RhythmGame
{
    /// <summary>
    /// Implementasi INodeGenerator.
    /// </summary>
    public class NodeGenerator : MonoBehaviour, INodeGenerator
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari node.
        /// </summary>
        private IFactory<INode> _nodeFactory = null;

        /// <summary>
        /// Menangani pembuatan dari node.
        /// </summary>
        private INodeAmount _nodeAmount = null;

        #endregion

        #region INodeGenerator

        public void GenerateNode()
        {
            for (int i = 0; i < _nodeAmount.Amount; i++)
            {
                var newNode = _nodeFactory.Create();

                newNode.Index = i;
            }

            OnNodeGenerated?.Invoke();
        }

        public Action OnNodeGenerated { get; set; } = null;

        #endregion
    }
}