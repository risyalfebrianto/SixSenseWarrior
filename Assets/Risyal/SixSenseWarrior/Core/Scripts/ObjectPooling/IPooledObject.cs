namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling
{
    /// <summary>
    /// Object yang di pooling.
    /// </summary>
    public interface IPooledObject
    {
        /// <summary>
        /// Untuk mengetahui apakah object aktif atau tidak.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Untuk mengaktifkan object.
        /// </summary>
        void ActivateObject();

        /// <summary>
        /// Untuk menon-aktifkan object.
        /// </summary>
        void DeactivateObject();
    }
}