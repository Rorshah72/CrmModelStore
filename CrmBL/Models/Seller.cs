using System;
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Seller
    {
        #region Властивості
        /// <summary>
        /// ID продавця.
        /// </summary>
        public int SellerId { get; set; }

        /// <summary>
        /// Імя продавеця.
        /// </summary>
        public string Name { get; set; }    
        
        public virtual ICollection<Check> Checks { get; set; }
        #endregion

        /// <summary>
        /// Пустий конструктор для класу продавець.
        /// </summary>
        public Seller() { }

        /// <summary>
        /// Конструктор для класу продавець.
        /// </summary>
        /// <param name="name">Імя продавця.</param>
        public Seller(string name)
        {
            Name = name;
           
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
