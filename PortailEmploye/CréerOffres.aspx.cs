using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string login = Session["login"].ToString();
                String req = String.Format("insert into offre(titreOffre,detailOffre,conditionsOffre,dateOffre,statutOffre,login) values ('{0}','{1}','{2}',SYSDATETIME (),'{3}','{4}')", TextBox1.Text, TextBox3.Text, TextBox2.Text,"valable",login);

                SqlCommand cmd = new SqlCommand(req, con);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListeCandidatures.aspx");
        }
    }
}