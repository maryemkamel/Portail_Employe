using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["idDoc"]= 0;
            Session["idEmploye"] = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) 
            {
                String req1 = String.Format("select idTypeDocument from typeDocument where typeDocument='{0}'", DropDownList1.SelectedValue);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if(rd1.Read())
                {
                    Session["idDoc"] = (int)rd1["idTypeDocument"];
                }
                rd1.Close();
                ////
                String req3 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    Session["idlog"] = (int)rd3["idLogin"];
                }
                rd3.Close();
                //////
                String req4 = String.Format("select idEmploye from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                if(rd4.Read())
                {
                    Session["idEmploye"] = (int)rd4["idEmploye"];
                }
                rd4.Close();
                ///

                String req2 = String.Format("insert into demandes(statutDemande,commentaireDemande,dateDemande,idTypeDocument,idEmploye) values('{0}','{1}',SYSDATETIME (),'{2}','{3}')", "non traité", TextBox1.Text, Session["idDoc"],Session["idEmploye"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                cmd2.ExecuteNonQuery();
                
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //LISTE DES DEMANDES
            Response.Redirect("ListeDemandesParEmploye-DOC.aspx");
        }
    }
}