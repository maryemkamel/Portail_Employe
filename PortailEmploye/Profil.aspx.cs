using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                Session["sex"] = 0;
                Session["situation"] = 0;
                Session["position"] = 0;
                Session["departement"] = 0;
                String req1 = String.Format("select idLogin from authentification where login = '{0}'", Session["login"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Session["idlog"] = (int)rd1["idLogin"];
                    
                }
                rd1.Close();
                String req2 = String.Format("select nomEmploye,prenomEmploye,ville,quartier,adresse,tel,email,idSex,idSituation,idPosition,idDepartement from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                   
                    Label3.Text = rd2["nomEmploye"].ToString();
                    Label4.Text = rd2["prenomEmploye"].ToString();
                    Label7.Text = rd2["adresse"].ToString();
                    Label12.Text = rd2["quartier"].ToString();
                    Label13.Text = rd2["ville"].ToString();
                    Label10.Text = rd2["tel"].ToString();
                    Label11.Text = rd2["email"].ToString();
                    Label1.Text = Label3.Text + " " + Label4.Text;
                    Session["sex"] = (int)rd2["idSex"];
                    Session["situation"] = (int)rd2["idSituation"];
                    Session["position"] = (int)rd2["idPosition"];
                    Session["departement"] = (int)rd2["idDepartement"];
                    
                }
                rd2.Close();
                String req3 = String.Format("select nomSex from sex where idSex='{0}'", Session["sex"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    Label5.Text = rd3["nomSex"].ToString();
                   
                }
                rd3.Close();
                String req4 = String.Format("select nomSituation from situationfamiliale where idSituation='{0}'", Session["situation"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                if (rd4.Read())
                {
                    Label6.Text = rd4["nomSituation"].ToString();
                    
                }
                rd4.Close();
                String req5 = String.Format("select nomPosition from position where idPosition='{0}'", Session["position"]);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                if (rd5.Read())
                {
                    Label8.Text = rd5["nomPosition"].ToString();
                    Label2.Text = Label8.Text;
                    
                }
                rd5.Close();
                String req6 = String.Format("select nomDepartement from departement where idDepartement='{0}'", Session["departement"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    Label9.Text = rd6["nomDepartement"].ToString();
                    
                }
                rd6.Close();

            }



        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListeDemandesParEmploye-Dperso.aspx");
        }
    }
}