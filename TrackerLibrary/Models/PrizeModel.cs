using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PrizeModel
    {
        public int  id { get; set; }
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
        public PrizeModel()
        {

        }
        public PrizeModel(string placeName, string placeNumber, string prizeAmount,string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
           

        }

    }
}
