namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.FactorySystem
{
    /// <summary>
    /// Menangani pembuatan dari suatu object.
    /// </summary>
    public interface IFactory
    {
        
    }

    /// <summary>
    /// Menangani pembuatan dari suatu object.
    /// </summary>
    /// <typeparam name="T">
    /// Semua jenis tipe yang ada pada program.
    /// </typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// Untuk membuat suatu object.
        /// </summary>
        /// <param name="parameters">
        /// Parameter yang digunakan untuk membuat suatu object.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa T.
        /// </returns>
        T Create(params object[] parameters);
    }
}