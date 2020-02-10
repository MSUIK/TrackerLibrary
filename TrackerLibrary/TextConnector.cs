using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        //TODO - Wire up the CreatePrize for text files.
        /// <summary>
        /// tove a Pre into text file
        /// </summary>
        /// <param name="model">The prifxe information</param>
        /// <returns>The prize information, including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
