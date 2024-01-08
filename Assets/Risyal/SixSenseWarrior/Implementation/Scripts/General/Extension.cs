namespace Assets.Risyal.SixSenseWarrior.Implementation.Scripts.General
{
    /// <summary>
    /// Menangani semua ekstensi pada game.
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Untuk konversi suatu object ke bentuk lain.
        /// </summary>
        /// <typeparam name="T">
        /// Semua jenis tipe yang ada pada program.
        /// </typeparam>
        /// <param name="target">
        /// Target konversi.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa T.
        /// </returns>
        public static T To<T>(this object target)
        {
            return (T)target;
        }
    }
}