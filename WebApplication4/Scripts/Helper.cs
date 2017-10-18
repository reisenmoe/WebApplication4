using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

public static class Helper
{


    public static string MyConnectionString
    {
        get { return WebConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; }
    }


}