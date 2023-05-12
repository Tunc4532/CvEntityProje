using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İstatistik : System.Web.UI.Page
    {
        DBCVENTİTYEntities db = new DBCVENTİTYEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.tbl_Yetenekler.Count().ToString();
            Label2.Text = db.tbl_İletişim.Count().ToString();
            Label3.Text = db.tbl_Yetenekler.Average(x => x.DERECE).ToString();
            Label4.Text = db.tbl_Yetenekler.Max(x => x.DERECE).ToString();
        }
    }
}