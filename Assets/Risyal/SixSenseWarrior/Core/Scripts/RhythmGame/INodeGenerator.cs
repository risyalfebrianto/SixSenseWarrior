using System;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.RhythmGame
{
    /// <summary>
    /// Untuk generate node.
    /// </summary>
    public interface INodeGenerator
    {
        /// <summary>
        /// Untuk generate node.
        /// </summary>
        void GenerateNode();

        /// <summary>
        /// Event yang dipanggil ketika node di generate.
        /// </summary>
        Action OnNodeGenerated { get; set; }
    }
}