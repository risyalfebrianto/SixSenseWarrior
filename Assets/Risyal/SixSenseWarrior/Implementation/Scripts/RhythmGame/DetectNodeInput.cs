using Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.RhythmGame
{
    /// <summary>
    /// Untuk deteksi input player.
    /// </summary>
    public class DetectNodeInput : MonoBehaviour, IPointerDownHandler
    {
        #region Variable

        /// <summary>
        /// Untuk tracking node.
        /// </summary>
        private INodeTracker _nodeTracker = null;

        /// <summary>
        /// Menangani node pada gameObject.
        /// </summary>
        private INode _node = null;

        #endregion

        #region IPointerDownHandler

        public void OnPointerDown(PointerEventData eventData)
        {
            _nodeTracker.DetectNode(_node.Index);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _nodeTracker = FindObjectsOfType<MonoBehaviour>().OfType<INodeTracker>().First();
            _node = GetComponent<INode>();
        }

        #endregion
    }
}