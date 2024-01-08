using Assets.Risyal.SixSenseWarrior.Core.Scripts.Fsm;
using Assets.Risyal.SixSenseWarrior.Implementation.Scripts.General;
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

        #region Main

        /// <summary>
        /// Untuk inisialisasi fsm.
        /// </summary>
        private void Initialize()
        {
            foreach (var state in _states)
            {
                state.InitializeState();

                state.To<MonoBehaviour>().enabled = false;
            }

            CurrentState = _states[0];

            CurrentState.EnterState();

            CurrentState.To<MonoBehaviour>().enabled = true;
        }

        #endregion

        #region IFsm

        public IState CurrentState { get; private set; } = null;

        public void ChangeState(string id)
        {
            var state = _states.First(x => x.Id == id);

            if (CurrentState != null)
            {
                CurrentState.ExitState();

                CurrentState.To<MonoBehaviour>().enabled = false;

                CurrentState = null;
            }

            CurrentState = state;

            CurrentState.EnterState();

            CurrentState.To<MonoBehaviour>().enabled = true;
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