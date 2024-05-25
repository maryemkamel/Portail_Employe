using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PortailEmploye
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        public static String GetMD5(String Texte)
        {
            String md5Hash = "";
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(Texte);
            data = x.ComputeHash(data);
            md5Hash = Encoding.ASCII.GetString(data);
            return md5Hash;
        }



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public DataProtectionScope Scope { get; private set; }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["id"] = 0;
           SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string mdpc = GetMD5(TextBox2.Text);
                String req1 = String.Format("select idProfil from profil where nomProfil='{0}'",DropDownList1.SelectedValue);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    Session["id"] = (int)rd1["idProfil"];
                }
                rd1.Close();

                String req = String.Format("insert into authentification(login,mdp,idProfil) values('{0}','{1}','{2}')",TextBox1.Text,mdpc,Session["id"]);
                SqlCommand cmd = new SqlCommand(req, con);
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Erreur de la connexion à la base de donnée");
            }
        }
    }
}