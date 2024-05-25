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
    public partial class WebForm22 : System.Web.UI.Page
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
                string[] commentaires = new string[100];
                string[] dates = new string[100];
                string[] documents = new string[100];
                int[] types = new int[100];
                int[] ids = new int[100];
                
                String req2 = String.Format("select * from demandes where idEmploye='{0}'", Session["idEmp"]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                int compt = 0;
                while (rd2.Read())
                {
                    ids[compt] = (int)rd2["idDemande"];
                    commentaires[compt] = rd2["commentaireDemande"].ToString();
                    dates[compt] = rd2["dateDemande"].ToString();
                    types[compt]=(int)rd2["idTypeDocument"];
                    compt++;
             
                }
                rd2.Close();


                for (int i = 0; i < ids.Length ; i++)
                {
                    String req4 = String.Format("select statutDemande from historiqueValidation where idDemande='{0}'", ids[i]);
                    SqlCommand cmd4 = new SqlCommand(req4, con);
                    SqlDataReader rd4 = cmd4.ExecuteReader();
                    if (rd4.Read())
                    {
                        status[i] = rd4["statutDemande"].ToString();
                    }
                    else
                    {
                        status[i] = "non traité";
                    }
                    rd4.Close();

                }

                for (int i = 0; i < types.Length; i++)
                {
                    String req5 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", types[i]);
                    SqlCommand cmd5 = new SqlCommand(req5, con);
                    SqlDataReader rd5 = cmd5.ExecuteReader();
                    if (rd5.Read())
                    {
                        documents[i] = rd5["typeDocument"].ToString();
                    }
                    rd5.Close();

                }
          
                int nombre = ids.Length;
                int taille = nombre * 60;
                string taille2 = taille.ToString()+"px";
                table1.Width = "1000px";
                table1.Height = "taille2";

                
                for (int j = 0; j <compt ; j++)
                {
                    var Maligne = new HtmlTableRow();
                    var MaCase1 = new HtmlTableCell();
                    var MaCase2 = new HtmlTableCell();
                    var MaCase3 = new HtmlTableCell();
                    var MaCase4 = new HtmlTableCell();
                    Maligne.Height = "20px";
                    MaCase1.Height = "20px";
                    MaCase2.Height = "20px";
                    MaCase3.Height = "20px";
                    MaCase4.Height = "20px";
                    MaCase1.InnerHtml = documents[j];
                    MaCase2.InnerHtml = dates[j];
                    MaCase3.InnerHtml = commentaires[j];
                    MaCase4.InnerHtml = status[j];
                    Maligne.Cells.Add(MaCase1);
                    Maligne.Cells.Add(MaCase2);
                    Maligne.Cells.Add(MaCase3);
                    Maligne.Cells.Add(MaCase4);
                    table1.Rows.Add(Maligne);

                }
            }
        }
    }
}