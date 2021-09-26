using System;
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Product
    {
        #region Властивості
        /// <summary>
        /// ID продуку.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Назва продуку.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ціна продукту.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Кількість продукту.
        /// </summary>
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }
        #endregion

        /// <summary>
        /// Пустий конструктор для класу продукт.
        /// </summary>
        public Product() { }

        /// <summary>
        /// Конструктор для класу продукт.
        /// </summary>
        /// <param name="name">Назва продукту.</param>
        /// <param name="price">Ціна на продукт.</param>
        /// <param name="count">Кількість продукту.</param>
        public Product(string name, double price = 0, int count = 0)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
