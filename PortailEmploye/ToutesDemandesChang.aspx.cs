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
    public partial class WebForm13 : System.Web.UI.Page
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

                int nbrChangement = 0;
                String req = String.Format("select idChangDPerso from changDPerso");
                SqlCommand cmd = new SqlCommand(req, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    nbrChangement++;

                }
                rd.Close();


                int[] ids = new int[nbrChangement];
                string[] status = new string[nbrChangement];
                string[] dates = new string[nbrChangement];
                string[] types = new string[nbrChangement];
                int[] idEmps = new int[nbrChangement];
                string[] employes = new string[nbrChangement];


                String req2 = String.Format("select idChangDPerso,typeChangement,statutChangement,statutChangement,dateChangement,idEmploye from changDPerso");
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                int compt = 0;
                while (rd2.Read())
                {
                    ids[compt] = (int)rd2["idChangDPerso"];
                    dates[compt] = rd2["dateChangement"].ToString();
                    types[compt] = rd2["typeChangement"].ToString();
                    idEmps[compt] = (int)rd2["idEmploye"];
                    status[compt] = rd2["statutChangement"].ToString();
                    compt++;

                }
                rd2.Close();


                //for (int i = 0; i < nbrChangement; i++)
                //{
                //    String req4 = String.Format("select statutChangement from historiqueValidationChang where idChangDPerso='{0}'", ids[i]);
                //    SqlCommand cmd4 = new SqlCommand(req4, con);
                //    SqlDataReader rd4 = cmd4.ExecuteReader();
                //    if (rd4.Read())
                //    {
                //        status[i] = rd4["statutChangement"].ToString();
                //    }
                //    else
                //    {
                //        status[i] = "non traité";
                //    }
                //    rd4.Close();

                //}

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

                for (int j = 0; j < nbrChangement; j++)
                {

                    var Maligne = new HtmlTableRow();
                    var MaCase1 = new HtmlTableCell();
                    var MaCase2 = new HtmlTableCell();
                    var MaCase3 = new HtmlTableCell();
                    var MaCase4 = new HtmlTableCell();
                    var MaCase5 = new HtmlTableCell();
                    Maligne.Height = "20px";
                    MaCase1.Height = "20px";
                    MaCase2.Height = "20px";
                    MaCase3.Height = "20px";
                    MaCase4.Height = "20px";
                    MaCase5.Height = "20px";
                    MaCase1.InnerHtml = ids[j].ToString();
                    MaCase2.InnerHtml = employes[j];
                    MaCase3.InnerHtml = types[j];
                    MaCase4.InnerHtml = dates[j];
                    MaCase5.InnerHtml = status[j];
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
            //afficher les detail de la demande de l'id TextBox1.text
            int a =Int32.Parse(TextBox1.Text);
            Session["idChoisi"] = a;
            Response.Redirect("TraiterDemandeChang2.aspx");
        }
    }
}