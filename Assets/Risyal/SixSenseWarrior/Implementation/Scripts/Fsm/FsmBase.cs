using Assets.Risyal.SixSenseWarrior.Core.Scripts.Fsm;
using System.Linq;
using UnityEngine;

namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.Fsm
{
    /// <summary>
    /// Implementasi IFsm.
    /// </summary>
    public class FsmBase : MonoBehaviour, IFsm
    {
        #region Variable

        /// <summary>
        /// State yang ada pada gameObject.
        /// </summary>
        private IState[] _states = null;

        #endregion

        #region IFsm

        public IState CurrentState { get; private set; } = null;

        public void ChangeState(string id)
        {
            var state = _states.First(x => x.Id == id);

            if (CurrentState != null)
            {
                CurrentState.ExitState();

                CurrentState = null;
            }

            CurrentState = state;

            CurrentState.EnterState();
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _states = GetComponents<IState>();
        }

        #endregion
    }
}