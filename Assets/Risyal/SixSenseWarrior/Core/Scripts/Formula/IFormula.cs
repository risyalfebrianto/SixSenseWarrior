namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.Formula
{
    /// <summary>
    /// Menghitung suatu rumus yang berhubungan dengan stat.
    /// </summary>
    public interface IFormula
    {
        /// <summary>
        /// Untuk kalkulasi formula.
        /// </summary>
        /// <param name="parameters">
        /// Parameter yang digunakan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa float.
        /// </returns>
        float Calculate(params object[] parameters);
    }
}