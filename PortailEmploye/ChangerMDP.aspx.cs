using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm26 : System.Web.UI.Page
    {

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

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            String req1 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
            SqlCommand cmd1 = new SqlCommand(req1, con);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            if (rd1.Read())
            {
                Session["idlog"] = (int)rd1["idLogin"];


            }
            rd1.Close();
            Label1.Visible = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            String req2 = String.Format("select mdp from authentification where idLogin='{0}'", Session["idlog"]);
            SqlCommand cmd2 = new SqlCommand(req2, con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            if (rd2.Read())
            {
                Session["mdpcrpt"] = rd2["mdp"].ToString();
            }
            rd2.Close();
            //string mdp = ;
            //Session["mdp"] = GetMD5(rd2["mdp"].ToString());
            if (GetMD5(TextBox1.Text) == Session["mdpcrpt"].ToString())
            {
                if (TextBox2.Text == TextBox3.Text)
                {
                    String req3 = String.Format("update authentification set mdp='{0}' where idLogin='{1}'", GetMD5(TextBox2.Text), Session["idlog"]);
                    SqlCommand cmd3 = new SqlCommand(req3, con);
                    cmd3.ExecuteNonQuery();

                }
                else
                {
                    Label1.Text = "Veuillez saisir le même mot de passe";
                    Label1.Visible = true;
                }

            }
            else
            {
                Label1.Text = "mot de passe incorrect";
                Label1.Visible = true;
            }
        }
            

        }
    }
