using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubCite
{
    public class ErrorMessage
    {
        public static readonly int COULD_NOT_CONNECT = 1;
        public static readonly int COULD_NOT_SAVE = 2;
        public static readonly int COULD_NOT_READ = 3;
        public static readonly int ADMINISTRATIVE_LIMIT_EXCEEDED = 4;
        public static readonly int NO_MATCH_FOUND = 5;
        private int error;
        public ErrorMessage(int ErrorType)
        {
            error = ErrorType;
        }
        public string getError()
        {
            switch (error)
            {
                case 1: return "Could not connect to the server, please check your internet connection";
                case 2: return "Error while saving data to file";
                case 3: return "Favorites could not be loaded";
                case 4: return "The administrative limit for this request was exceeded";
                case 5: return "No match for this request has been found";
                default: return "";
            }
        }

    }
}
