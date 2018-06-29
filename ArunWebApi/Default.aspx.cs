using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArunWebApi
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            webApiControllerTest webapi1 = new webApiControllerTest();          

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

    }
}