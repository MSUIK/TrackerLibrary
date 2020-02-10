using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public static class GlobleConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitilizeConections(bool database , bool textFiles)
        {
            if(database)
            {
                //TODO - Setup THE SQL Conections properly
                SqlConector sql = new SqlConector();
                Connections.Add(sql);
            }

            if(textFiles)
            {
                //TODO - Create the textFile Conection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
