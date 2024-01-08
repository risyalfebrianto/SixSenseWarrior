using System.Collections.Generic;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.PoolSystem
{
    /// <summary>
    /// Menangani penyimpanan kumpulan dari entitas yang sejenis.
    /// </summary>
    public interface IPool
    {
        /// <summary>
        /// Id dari pool.
        /// </summary>
        string Id { get; }
    }

    /// <summary>
    /// Menangani penyimpanan kumpulan dari entitas yang sejenis.
    /// </summary>
    /// <typeparam name="T">
    /// Semua jenis yang ada pada program.
    /// </typeparam>
    public interface IPool<T>
    {
        /// <summary>
        /// Semua entitas yang disimpan di pool.
        /// </summary>
        List<T> Entities { get; }

        /// <summary>
        /// Untuk mendapatkan entitas yang disimpan didalam pool.
        /// </summary>
        /// <param name="id">
        /// Id dari entitas yang ingin didapatkan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai T.
        /// </returns>
        T Get(string id);
    }
}