namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Fsm
{
    /// <summary>
    /// Kondisi pada suatu object.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Id dari state.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Untuk inisialisasi state.
        /// </summary>
        void InitializeState();

        /// <summary>
        /// Dipanggil ketika memasuki state.
        /// </summary>
        /// <param name="parameters">
        /// Paramter yang di kirim ketika memasuki state.
        /// </param>
        void EnterState(params object[] parameters);

        /// <summary>
        /// Dipanggil ketika keluar dari state.
        /// </summary>
        /// <param name="parameters">
        /// Paramter yang di kirim ketika keluar state.
        /// </param>
        void ExitState(params object[] parameters);
    }
}