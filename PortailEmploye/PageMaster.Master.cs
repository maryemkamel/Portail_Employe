using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class PageMaster : System.Web.UI.MasterPage
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


                //String req3 = String.Format("select nomProfil from profil where idProfil='{0}'", Session["idprofil"]);
                //SqlCommand cmd3 = new SqlCommand(req3, con);
                //SqlDataReader rd3 = cmd3.ExecuteReader();
                //if (rd3.Read())
                //{
                //    Session["profil"] = rd3["nomProfil"].ToString();

                //}
            }
            if ((int)Session["idprofil"] == 2)
            {
                Panel3.Visible = false;
                Panel1.Visible = false;
            }
            if ((int)Session["idprofil"] == 1)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
            if((int)Session["idprofil"] == 1 || (int)Session["idprofil"] == 3)
            {
                Panel2.Visible = false;
            }



        }
       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session["autorisation"] = false;
              FormsAuthentication.SignOut();
            Response.Redirect("authentification.aspx");
        }

       

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Acceuil.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
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

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profil.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrateur.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
           /* Response.Redirect("DemandeDocument.aspx");*/
            Response.Redirect("DemandeDocument.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("DemandesRH.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
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