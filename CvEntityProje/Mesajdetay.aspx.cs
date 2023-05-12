using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Mesajdetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTİTYEntities db = new DBCVENTİTYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.tbl_İletişim.Find(x);
            txtadsoyad.Text = mesaj.ADSOYAD;
            txtkonu.Text = mesaj.KONU;
            txtmail.Text = mesaj.MAİL;
            txtmesaj.Text = mesaj.MESAJ;
        }
    }
}