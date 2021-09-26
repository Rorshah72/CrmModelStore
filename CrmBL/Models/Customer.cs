using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Customer
    {
        #region Властивості
        /// <summary>
        /// ID покупця.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Імя покупця.
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
        #endregion

        /// <summary>
        /// Пустий конструктор для класу покупець.
        /// </summary>
        public Customer() { }

        /// <summary>
        /// Конструктор для класу покупець.
        /// </summary>
        /// <param name="name">Імя покупця.</param>
        public Customer(string name)
        {
            Name = name;
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
