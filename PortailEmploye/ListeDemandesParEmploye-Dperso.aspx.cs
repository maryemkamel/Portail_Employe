using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm25 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

            Session["idEmp"] = null;
            int[] idDemande = new int[100];
            //int a = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req6 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {

                    Session["idlog"] = (int)rd6["idLogin"];
                }
                rd6.Close();
                //////
                String req1 = String.Format("select idEmploye from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {

                    Session["idEmp"] = (int)rd1["idEmploye"];
                }
                rd1.Close();


                string[] status = new string[100];
                string[] dates = new string[100];
                string[] Demandes = new string[100];


                String req2 = String.Format("select * from changDPerso where idEmploye='{0}'", Session["idEmp"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                int compt = 0;
                while (rd2.Read())
                {

                    Demandes[compt] = rd2["typeChangement"].ToString();
                    status[compt] = rd2["statutChangement"].ToString();
                    dates[compt] = rd2["dateChangement"].ToString();
                    compt++;

                }
                rd2.Close();


                int nombre = compt;
                int taille = nombre * 60;
                string taille2 = taille.ToString() + "px";
                //table1.Width = "1000px";
                //table1.Height = "taille2";


                for (int j = 0; j < compt; j++)
                {
                    var Maligne = new HtmlTableRow();
                    var MaCase1 = new HtmlTableCell();
                    var MaCase2 = new HtmlTableCell();
                    var MaCase3 = new HtmlTableCell();
                    Maligne.Height = "20px";
                    MaCase1.Height = "20px";
                    MaCase2.Height = "20px";
                    MaCase3.Height = "20px";
                    MaCase1.InnerHtml = Demandes[j];
                    MaCase2.InnerHtml = dates[j];
                    MaCase3.InnerHtml = status[j];
                    Maligne.Cells.Add(MaCase1);
                    Maligne.Cells.Add(MaCase2);
                    Maligne.Cells.Add(MaCase3);
                    table1.Rows.Add(Maligne);

                }
            }
        }
    }
}