using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4.Pages
{
    public partial class OtherPageManual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadButton_Click(object sender, EventArgs e)
        {
            //Create a new connection
            SqlConnection con = new SqlConnection(Helper.MyConnectionString);

            //Build command
            string cmdStr = "SELECT * FROM MyTable";
            SqlCommand cmd = new SqlCommand(cmdStr, con);

            //Open database
            con.Open();
            //Reading session
            SqlDataReader reader = cmd.ExecuteReader();

            //If there are any data
            if(reader.HasRows)
            {

            }
            else
            {

            }

            //Load data to table
            DataTable dt = new DataTable();
            dt.Load(reader);

            MyLabel.Text = (String)dt.Rows[0][1];
        }
    }
}