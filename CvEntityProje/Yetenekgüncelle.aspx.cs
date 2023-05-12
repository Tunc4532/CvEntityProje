using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Yetenekgüncelle : System.Web.UI.Page
    {
        DBCVENTİTYEntities db = new DBCVENTİTYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if(Page.IsPostBack == false )
            {
                var dege = db.tbl_Yetenekler.Find(x);
                TextBox1.Text = dege.YETENEK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var dege = db.tbl_Yetenekler.Find(x);
            dege.YETENEK = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");

        }
    }
}