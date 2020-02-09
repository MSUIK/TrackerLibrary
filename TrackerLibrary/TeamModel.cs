using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class TeamModel
    {
        public List<PersonModel> TeamMebmers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
