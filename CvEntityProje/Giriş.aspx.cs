using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Giriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTİTYEntities db = new DBCVENTİTYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tbl_Admin where x.KULLANICIAD == TextBox1.Text && x.SİFRE==TextBox2.Text select x;
            if(sorgu.Any())
            {
                Response.Redirect("İstatistik.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre !!!");
            }
        }
    }
}