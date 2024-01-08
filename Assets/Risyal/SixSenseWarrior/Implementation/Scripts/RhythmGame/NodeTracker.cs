using Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame;
using System;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.RhythmGame
{
    /// <summary>
    /// Implementasi INodeTracker.
    /// </summary>
    public class NodeTracker : MonoBehaviour, INodeTracker
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari node.
        /// </summary>
        private INodeAmount _nodeAmount = null;

        /// <summary>
        /// Menangani pembuatan dari node.
        /// </summary>
        private INodeGenerator _nodeGenerator = null;

        /// <summary>
        /// Index node saat ini. 
        /// </summary>
        private int _currentIndex = 0;

        #endregion

        #region INodeTracker

        public void DetectNode(int index)
        {
            if (index != _currentIndex)
            {
                OnFailure?.Invoke();

                return;
            }

            _currentIndex++;

            if (_nodeAmount.Amount == _currentIndex)
            {
                OnSuccess?.Invoke();
            }
        }

        public void FailDetectNode()
        {
            OnFailure?.Invoke();
        }

        public Action OnSuccess { get; set; } = null;

        public Action OnFailure { get; set; } = null;

        #endregion

        #region Main

        /// <summary>
        /// Untuk reset index saat ini.
        /// </summary>
        private void ResetIndex()
        {
            _currentIndex = 0;
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _nodeGenerator = GetComponent<INodeGenerator>();
            _nodeAmount = GetComponent<INodeAmount>();

            _nodeGenerator.OnNodeGenerated += ResetIndex;
        }

        private void OnDestroy()
        {
            _nodeGenerator.OnNodeGenerated -= ResetIndex;
        }

        #endregion
    }
}