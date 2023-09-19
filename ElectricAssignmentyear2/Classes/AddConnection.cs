using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricAssignmentyear2.Classes
{
    internal class AddConnection
    {
       public static string Getconnection()
        {
            return ConfigurationManager.ConnectionStrings["Electric"].ConnectionString;
        }
       
    }
}
