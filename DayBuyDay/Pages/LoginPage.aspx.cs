using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DayBuyDay.Pages
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgree_Click(object sender, EventArgs e)
        {
            DayBuyDay.DbModel.ProductDbEntities e1=new DbModel.ProductDbEntities();

            foreach (var user in e1.Admins)
            {
                if (user.Username==txtUsername.Text && user.Password==txtPassword.Text)
                {
                    Response.Redirect("http://localhost:63142/Sayfalar/Anasayfa.aspx");
                    return;
                }
                
            }

            foreach (var user in e1.Admins)
            {
                if (user.Username != txtUsername.Text && user.Password != txtPassword.Text)
                {
                    lblError.Text = "Kullanici Adi veya Parola Hatali";
                    return;
                }
                
            }
        }
    }
}