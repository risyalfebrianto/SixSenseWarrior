namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Fsm
{
    /// <summary>
    /// Menangani finite state machine.
    /// </summary>
    public interface IFsm
    {
        /// <summary>
        /// State fsm saat ini.
        /// </summary>
        /// <returns>
        /// Mengembalikan nilai berupa IState.
        /// </returns>
        IState CurrentState { get; }

        /// <summary>
        /// Untuk mengganti state pada suatu object.
        /// </summary>
        /// <param name="id">
        /// Id state target yang ingin diganti.
        /// </param>
        void ChangeState(string id);
    }
}