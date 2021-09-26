using System;
using System.Collections.Generic;

namespace CrmBL.Models
{
    public class Check
    {
        #region Властивості
        /// <summary>
        /// ID чеку.
        /// </summary>
        public int CheckId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        
        /// <summary>
        /// Дата здійснення покупки.
        /// </summary>
        public DateTime CreateCheck { get; set; }
        
        #endregion

        /// <summary>
        /// Пустий конструктор для класу чек.
        /// </summary>
        public Check() { }

        /// <summary>
        /// Конструктор для класу чек.
        /// </summary>        
        /// <param CreateCheck="createCheck">Дата покупки.</param>        
        public Check(DateTime createCheck )
        {
            CreateCheck = createCheck;
        }

        public override string ToString()
        {
            return $"#{CheckId} від {CreateCheck.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
