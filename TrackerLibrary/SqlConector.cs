using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConector : IDataConnection
    {
        //TODO - Make the create method actually save to the database
        /// <summary>
        /// Sves a new prize to database
        /// </summary>
        /// <param name="model">The prifxe information.</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }

       
    }
}
