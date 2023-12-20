using Assets.Risyal.SixSenseWarrior.Core.Scripts.Fsm;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Fsm
{
    /// <summary>
    /// Implementasi IState.
    /// </summary>
    public abstract class State : MonoBehaviour, IState
    {
        #region IState

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public abstract void InitializeState();

        public abstract void EnterState(params object[] parameters);

        public abstract void ExitState(params object[] parameters);

        #endregion
    }
}