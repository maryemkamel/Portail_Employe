using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("SELECT titreOffre, detailOffre, conditionsOffre, dateOffre, statutOffre FROM offre where idOffre='{0}'", Session["idOffre"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Label6.Text = rd1["titreOffre"].ToString();
                    Label4.Text = rd1["dateOffre"].ToString();
                    Label5.Text = rd1["statutOffre"].ToString();
                    Label1.Text = rd1["detailOffre"].ToString();
                    Label2.Text = rd1["conditionsOffre"].ToString();

                }
            }
            if ((int)Session["idprofil"] == 2)
            {
                Panel1.Visible = false;
            }
            if ((int)Session["idprofil"] == 1 || (int)Session["idprofil"] == 3)
            {
                Button2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                String req1 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Session["idlog"] = (int)rd1["idLogin"];

                }
                rd1.Close();

                String req2 = String.Format("select idEmploye from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    Session["idEmp"] = (int)rd2["idEmploye"];
                }
                rd2.Close();
                String req3 = String.Format("insert into candidature(dateCandidature,commentaireCandidature,statutCandidature,idEmploye,idOffre) values(SYSDATETIME(),'{0}','{1}','{2}','{3}')", TextBox1.Text, "non traité", Session["idEmp"], Session["idOffre"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                cmd3.ExecuteNonQuery();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("update offre set statutOffre='{0}' where idOffre='{1}'", "épuisé", Session["idOffre"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                cmd1.ExecuteNonQuery();
            }
        }
    }
}