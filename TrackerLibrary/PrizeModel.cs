using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PrizeModel
    {
        /// <summary>
        /// Prize place number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// prize place name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// or prize percentage
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
