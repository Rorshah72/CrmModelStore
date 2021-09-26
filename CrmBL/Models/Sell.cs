using System;

namespace CrmBL.Models
{
    public class Sell
    {
        #region Властивості
        /// <summary>
        /// ID чеку.
        /// </summary>
        public int SellId { get; set; }

        public int CheckId { get; set; }

        public virtual Check Check { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        #endregion


    }
}
