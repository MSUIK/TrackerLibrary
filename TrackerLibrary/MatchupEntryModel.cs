using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents the one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting{ get; set; }
        /// <summary>
        /// Represents the Score of one Team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the ParentMatchup
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
               
    }
}
