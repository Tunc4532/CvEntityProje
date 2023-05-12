using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Yeteneksil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTİTYEntities db = new DBCVENTİTYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = db.tbl_Yetenekler.Find(x);
            db.tbl_Yetenekler.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}