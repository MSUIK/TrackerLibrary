using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PersonModel
    {
        /// <summary>
        /// First Name of the person
        /// </summary>
        public string  FirstName { get; set; }
        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of the person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The primary phone number of the person
        /// </summary>
        public string  CellPhoneNumber { get; set; }

    }

}
