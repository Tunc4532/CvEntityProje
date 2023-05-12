using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTİTYEntities db = new DBCVENTİTYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.tbl_Hakkımda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.tbl_Hakkımda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.tbl_Hakkımda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.tbl_Yetenekler.ToList();
            Repeater4.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbl_İletişim t = new tbl_İletişim();
            t.ADSOYAD = TextBox1.Text;
            t.MAİL = TextBox2.Text;
            t.KONU = TextBox3.Text;
            t.MESAJ = TextBox4.Text;
            db.tbl_İletişim.Add(t);
            db.SaveChanges();
        }
    }
}