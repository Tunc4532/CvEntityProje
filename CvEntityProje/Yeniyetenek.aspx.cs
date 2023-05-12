using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Yeniyetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTİTYEntities db = new DBCVENTİTYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_Yetenekler t = new tbl_Yetenekler();
            t.YETENEK = TextBox1.Text;
            db.tbl_Yetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}