using Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem;
using Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Factory
{
    /// <summary>
    /// Implementasi IFactory<INode>.
    /// </summary>
    public class NodeFactory : MonoBehaviour, IFactory<INode>
    {
        #region IFactory<INode>

        public INode Create(params object[] parameters)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}