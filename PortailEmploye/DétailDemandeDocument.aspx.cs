using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["statut"]=null;
            Session["commentaire"] = null;
            Session["date"] = null;
            Session["emp"] = null;
            Session["doc"] = null;
            Session["idType"]=0;
            Session["idEmp"]=0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("select statutDemande,commentaireDemande, dateDemande, idTypeDocument, idEmploye from demandes where idDemande='{0}'", Session["idDemande"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                   /* Session["statut"] = rd1["statutDemande"].ToString();*/
                    Session["commentaire"] = rd1["commentaireDemande"].ToString();
                    Session["date"] = rd1["dateDemande"].ToString();
                    Session["idType"] = (int)rd1["idTypeDocument"];
                    Session["idEmp"] = (int) rd1["idEmploye"];

                }
                rd1.Close();

                String req4 = String.Format("select statutDemande from historiqueValidation where idDemande='{0}'", Session["idDemande"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                if(rd4.Read())
                {
                    Session["statut"] = rd4["statutDemande"].ToString();
                }
                else
                {
                    Session["statut"] = "non traité";
                }
                rd4.Close();


                String req2 = String.Format("select nomEmploye, prenomEmploye from employe where idEmploye='{0}'", Session["idEmp"] );
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    Session["emp"] = (rd2["nomEmploye"].ToString()) + " " + (rd2["prenomEmploye"].ToString());
                }
                rd2.Close();

                String req3 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", Session["idType"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    Session["doc"] = rd3["typeDocument"].ToString();
                }
                rd3.Close();

                Label4.Text = Session["emp"].ToString();
                Label5.Text = Session["doc"].ToString();
                Label6.Text = Session["date"].ToString();
                Label9.Text = Session["commentaire"].ToString();
                if(Session["statut"].ToString() =="traité")
                {
                    Button1.Visible = false;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
              /*  String req1 = String.Format("insert into historiqueValidation(idDemande, statutDemande, dateStatut) values('{0}','{1}','{2}')", Session["idDemande"], Session["statut"], Session["date"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                cmd1.ExecuteNonQuery();*/

                String req2 = String.Format("insert into historiqueValidation(idDemande, statutDemande, dateStatut, login) values('{0}','{1}',SYSDATETIME (),'{2}')", Session["idDemande"], "traité", Session["login"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                cmd2.ExecuteNonQuery();

            }
            con.Close();
        }
    }
}