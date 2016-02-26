using System;
using System.Configuration;

namespace ApiWrapper
{
    public class API
    {
        public static bool WriteMessage(String Message)
        {
            if (System.Configuration.ConfigurationManager.AppSettings["WriteDestination"] == "Console")
            {
                WriteToConsole Writer = new WriteToConsole();
                return Writer.Write(Message);
                //Return status is here for 
                
            }
            else if (System.Configuration.ConfigurationManager.AppSettings["WriteDestination"] == "Database")
            {
                WriteToDb Writer = new WriteToDb();
                return Writer.Write(Message);
            }
            return false;
        }

    }

}