using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PortailEmploye
{
    public partial class WebForm23 : System.Web.UI.Page
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

                int nbrDemande = 0;
                String req = String.Format("select idDemande from demandes");
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nbrDemande++;

                }
                rd.Close();


                int[] ids = new int[nbrDemande];
                string[] status = new string[nbrDemande];
                string[] commentaires = new string[nbrDemande];
                string[] dates = new string[nbrDemande];
                string[] documents = new string[nbrDemande];
                int[] types = new int[nbrDemande];
                int[] idEmps = new int[nbrDemande];
                string[] employes = new string[nbrDemande];


                String req2 = String.Format("select * from demandes");
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                int compt = 0;
                while (rd2.Read())
                {
                    ids[compt] = (int)rd2["idDemande"];
                    commentaires[compt] = rd2["commentaireDemande"].ToString();
                    dates[compt] = rd2["dateDemande"].ToString();
                    types[compt] = (int)rd2["idTypeDocument"];
                    idEmps[compt] = (int)rd2["idEmploye"];
                    compt++;

                }
                rd2.Close();


                for (int i = 0; i < nbrDemande; i++)
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
                string[] tabButtons = new string[nbrDemande];
                for (int j = 0; j < nbrDemande; j++)
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
                    MaCase1.InnerHtml = employes[j];
                    MaCase2.InnerHtml = documents[j];
                    MaCase3.InnerHtml = dates[j];
                    MaCase4.InnerHtml = commentaires[j];
                    MaCase6.InnerHtml = ids[j].ToString();
                    if (status[j] == "non traité")
                    {
                        MaCase5.InnerHtml = "non traité";

                    }
                    else
                    {
                        MaCase5.InnerHtml = "traité";

                    }
                    Maligne.Cells.Add(MaCase6);
                    Maligne.Cells.Add(MaCase1);
                    Maligne.Cells.Add(MaCase2);
                    Maligne.Cells.Add(MaCase3);
                    Maligne.Cells.Add(MaCase4);
                    Maligne.Cells.Add(MaCase5);
                    
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
                String req4 = String.Format("insert into historiqueValidation values('{0}','{1}',sysdateTime(),'{2}')", nbre, "traité", Session["login"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                cmd4.ExecuteNonQuery();

            }
        }
    }
}