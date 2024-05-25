using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace PortailEmploye
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static String GetMD5(String Texte)
        {
            String md5Hash = "";
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(Texte);
            data = x.ComputeHash(data);
            md5Hash = Encoding.ASCII.GetString(data);
            return md5Hash;
        }

        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

       

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                String req = String.Format("select * from authentification where login = '{0}' and mdp = '{1}'", inputEmailAddress.Text, GetMD5(inputPassword.Text));
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                     Session["autorisation"] = true;
                     Session["login"] = inputEmailAddress.Text;
                     Response.Redirect("Acceuil.aspx");
                    
                }
                else
                {
                    Session["autorisation"] = false;
                    Label1.Text = "login ou mot de passe incorrect";
                }
                rd.Close();
                String req1 = String.Format("select idLogin from authentification where login = '{0}'", Session["login"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Session["idlog"] = (int)rd1["idLogin"];
                    rd1.Close();
                }
                rd1.Close();
                String req2 = String.Format("select nomEmploye,prenomEmploye from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    
                    Session["nomEmploye"] = rd2["nomEmploye"].ToString();
                    Session["prenomEmploye"] = rd2["prenomEmploye"].ToString();
                }
                rd2.Close();

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("password.aspx");
        }
    }
}