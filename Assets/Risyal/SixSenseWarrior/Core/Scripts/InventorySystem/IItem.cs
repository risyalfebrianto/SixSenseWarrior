namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.InventorySystem
{
    /// <summary>
    /// Menangani item yang ada pada game.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// Id dari item.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Kategori yang dimiliki oleh item.
        /// </summary>
        ItemCategory Category { get; }

        /// <summary>
        /// Jumlah item yang dimiliki.
        /// </summary>
        int Amount { get; }

        /// <summary>
        /// Jumlah maksimal dari item yang dimiliki.
        /// </summary>
        int MaxAmount { get; }

        /// <summary>
        /// Untuk menambah jumlah item.
        /// </summary>
        /// <param name="amount">
        /// Jumlah item yang ditambah.
        /// </param>
        void AddAmount(int amount);
    }

    /// <summary>
    /// Kategori yang dimiliki oleh item.
    /// </summary>
    public enum ItemCategory
    {
        Equipment
    }
}