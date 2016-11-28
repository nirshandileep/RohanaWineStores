using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RWS.DAL
{
    public class Connection
    {
        public static string DBConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}