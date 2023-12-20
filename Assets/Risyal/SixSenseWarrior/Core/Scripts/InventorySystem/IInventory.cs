using System;
using System.Collections.Generic;

namespace Assets.Risyal.SixSenseWarrior.Core.Scripts.InventorySystem
{
    /// <summary>
    /// Menangani inventory didalam game.
    /// </summary>
    public interface IInventory
    {
        /// <summary>
        /// Untuk mendapatkan satu item.
        /// </summary>
        /// <param name="id">
        /// Id dari item yang ingin didapatkan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa IItem.
        /// </returns>
        IItem GetItem(string id);

        /// <summary>
        /// Untuk mendapatkan group dari item.
        /// </summary>
        /// <param name="category">
        /// Kategori item yang ingin didapatkan.
        /// </param>
        /// <returns>
        /// Mengembalikan nilai berupa IEnumerable<IItem>.
        /// </returns>
        IEnumerable<IItem> GetItems(ItemCategory category);

        /// <summary>
        /// Untuk menambahkan item.
        /// </summary>
        /// <param name="item">
        /// Item yang ingin didapatkan.
        /// </param>
        /// <param name="amount">
        /// Jumlah item yang dimiliki.
        /// </param>
        void AddItem(IItem item, int amount);

        /// <summary>
        /// Untuk mengurangi item.
        /// </summary>
        /// <param name="item">
        /// Item yang dikurangi.
        /// </param>
        /// <param name="amount">
        /// Jumlah item dikurangi.
        /// </param>
        void ReduceItem(IItem item, int amount);

        /// <summary>
        /// Untuk mengosongkan inventory.
        /// </summary>
        void ClearInventory();

        /// <summary>
        /// Event yang dipanggil ketika inventory berganti isinya.
        /// </summary>
        Action OnInventoryChange { get; set; }
    }
}