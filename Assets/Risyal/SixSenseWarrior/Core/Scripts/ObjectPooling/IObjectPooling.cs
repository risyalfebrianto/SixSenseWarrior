namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.ObjectPooling
{
    /// <summary>
    /// Menangani pooling object.
    /// </summary>
    public interface IObjectPooling
    {
        /// <summary>
        /// Untuk mendapatkan object yang free.
        /// </summary>
        /// <returns>
        /// Mengembalikan nilai berupa IPooledObject.
        /// </returns>
        IPooledObject GetFreeObject();

        /// <summary>
        /// Untuk menghilangkan semua object pooling yang disimpan.
        /// </summary>
        void Clear();
    }
}