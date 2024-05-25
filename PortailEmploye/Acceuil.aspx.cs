using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["autorisation"] == null || (bool)Session["autorisation"] == false)
                Response.Redirect("authentification.aspx");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Session["idlogin"] = (int)rd1["idLogin"];

                }
                rd1.Close();
                String req2 = String.Format("select idProfil from authentification where idLogin='{0}'", Session["idlogin"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {

                    Session["idprofil"] = (int)rd2["idProfil"];
                }
                rd2.Close();

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if ((int)Session["idprofil"] == 1 || (int)Session["idprofil"] == 3)
            {
                Response.Redirect("ConsulterNews.aspx");
            }
            if ((int)Session["idprofil"] == 2)
            {
                Response.Redirect("NEWS1.aspx");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if ((int)Session["idprofil"] == 1 || (int)Session["idprofil"] == 3)
            {
                Response.Redirect("DemandeDocument.aspx");
            }
            if ((int)Session["idprofil"] == 2)
            {
                Response.Redirect("DemandesRH.aspx");
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profil.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if ((int)Session["idprofil"] == 2)
            {
                Response.Redirect("OffresRH.aspx");
            }
            if ((int)Session["idprofil"] == 1 || (int)Session["idprofil"] == 3)
            {
                Response.Redirect("ConsulterOffres.aspx");
            }
        }
    }
}