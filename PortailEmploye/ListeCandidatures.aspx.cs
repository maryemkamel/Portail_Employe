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
    public partial class WebForm27 : System.Web.UI.Page
    {

        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["idEmp"] = null;
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

                int nbreCandidature = 0;
                String req = String.Format("select idCandidature from candidature");
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nbreCandidature++;

                }
                rd.Close();


                int[] ids = new int[nbreCandidature];
                string[] status = new string[nbreCandidature];
                string[] commentaires = new string[nbreCandidature];
                string[] dates = new string[nbreCandidature];
                int[] idoffres = new int[nbreCandidature];
                string[] offres = new string[nbreCandidature];
                int[] idEmps = new int[nbreCandidature];
                string[] employes = new string[nbreCandidature];


                String req2 = String.Format("select * from candidature");
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                int compt = 0;
                while (rd2.Read())
                {
                    ids[compt] = (int)rd2["idCandidature"];
                    commentaires[compt] = rd2["commentaireCandidature"].ToString();
                    dates[compt] = rd2["dateCandidature"].ToString();
                    idEmps[compt] = (int)rd2["idEmploye"];
                    idoffres[compt] = (int)rd2["idOffre"];
                    compt++;

                }
                rd2.Close();


                for (int i = 0; i < nbreCandidature; i++)
                {
                    String req4 = String.Format("select statutCandidature from historiqueCandidature where idCandidature='{0}'", ids[i]);
                    SqlCommand cmd4 = new SqlCommand(req4, con);
                    SqlDataReader rd4 = cmd4.ExecuteReader();
                    if (rd4.Read())
                    {
                        status[i] = rd4["statutCandidature"].ToString();
                    }
                    else
                    {
                        status[i] = "non traité";
                    }
                    rd4.Close();

                }

                for (int i = 0; i < idoffres.Length; i++)
                {
                    String req5 = String.Format("select titreOffre from offre where idOffre='{0}'", idoffres[i]);
                    SqlCommand cmd5 = new SqlCommand(req5, con);
                    SqlDataReader rd5 = cmd5.ExecuteReader();
                    if (rd5.Read())
                    {
                        offres[i] = rd5["titreOffre"].ToString();
                    }
                    rd5.Close();
                }

                for (int i = 0; i < idEmps.Length; i++)
                {
                    String req7 = String.Format("select nomEmploye,prenomEmploye from employe  where idEmploye='{0}'", idEmps[i]);
                    SqlCommand cmd7 = new SqlCommand(req7, con);
                    SqlDataReader rd7 = cmd7.ExecuteReader();
                    if (rd7.Read())
                    {
                        employes[i] = (rd7["nomEmploye"].ToString()) + " " + (rd7["prenomEmploye"].ToString());
                    }
                    rd7.Close();
                }

                Session["id"] = 0;
                string[] tabButtons = new string[nbreCandidature];
                for (int j = 0; j < nbreCandidature; j++)
                {

                    var Maligne = new HtmlTableRow();
                    var MaCase1 = new HtmlTableCell();
                    var MaCase2 = new HtmlTableCell();
                    var MaCase3 = new HtmlTableCell();
                    var MaCase4 = new HtmlTableCell();
                    var MaCase5 = new HtmlTableCell();
                    var MaCase6 = new HtmlTableCell();
                    Maligne.Height = "20px";
                    MaCase1.Height = "20px";
                    MaCase2.Height = "20px";
                    MaCase3.Height = "20px";
                    MaCase4.Height = "20px";
                    MaCase5.Height = "20px";
                    MaCase6.Height = "20pc";
                    MaCase1.InnerHtml = ids[j].ToString();
                    MaCase2.InnerHtml = employes[j];
                    MaCase3.InnerHtml = offres[j];
                    MaCase4.InnerHtml = dates[j];
                    MaCase5.InnerHtml = commentaires[j];
                    MaCase6.InnerHtml = status[j];


                    
                    Maligne.Cells.Add(MaCase1);
                    Maligne.Cells.Add(MaCase2);
                    Maligne.Cells.Add(MaCase3);
                    Maligne.Cells.Add(MaCase4);
                    Maligne.Cells.Add(MaCase5);
                    Maligne.Cells.Add(MaCase6);

                    table.Rows.Add(Maligne);

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                int nbre = Int32.Parse(TextBox1.Text);
                String req4 = String.Format("insert into historiqueCandidature values('{0}',sysdateTime(),'{1}','{2}')", "traité", nbre, Session["login"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                cmd4.ExecuteNonQuery();

            }
        }
    }
}