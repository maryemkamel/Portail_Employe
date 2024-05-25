using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
        int [] idDemandes = new int[4];
        String[] statuts = new string[4];
        String[] commentaires = new string[4];
        string[] dates = new string[4];
        int[] idTypes = new int[4];
        int[] idEmployes = new int[4];
        string[] employes = new string[4];
        string[] documents = new string[4];
        int compt = 0;
        int compt2 = 0;
        int compt3 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("select TOP 4 idDemande, statutDemande, commentaireDemande, dateDemande, idTypeDocument, idEmploye FROM demandes ORDER BY idDemande DESC");
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    idDemandes[compt] = (int)rd1["idDemande"];
                    statuts[compt] = rd1["statutDemande"].ToString();
                    commentaires[compt] = rd1["commentaireDemande"].ToString();
                    dates[compt] = rd1["dateDemande"].ToString();
                    idTypes[compt] = (int)rd1["idTypeDocument"];
                    idEmployes[compt] = (int)rd1["idEmploye"];
                    compt++;
                }
                rd1.Close();
                ///Les employes
                String req2 = String.Format("select nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[0]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                if (rd2.Read())
                {
                    employes[compt2] = (rd2["nomEmploye"].ToString()) + " " + (rd2["prenomEmploye"].ToString());
                    compt2++;
                }
                rd2.Close();
                ///2
                String req3 = String.Format("select nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[1]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    employes[compt2] = (rd3["nomEmploye"].ToString()) + " " + (rd3["prenomEmploye"].ToString());
                    compt2++;
                }
                rd3.Close();
                ///3
                String req4 = String.Format("select nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[2]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                if (rd4.Read())
                {
                    employes[compt2] = (rd4["nomEmploye"].ToString()) + " " + (rd4["prenomEmploye"].ToString());
                    compt2++;
                }
                rd4.Close();
                ///4
                String req5 = String.Format("select nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[3]);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                if (rd5.Read())
                {
                    employes[compt2] = (rd5["nomEmploye"].ToString()) + " " + (rd5["prenomEmploye"].ToString());
                    compt2++;
                }
                rd5.Close();
                /////Les documents
                String req6 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", idTypes[0]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    documents[compt3] = rd6["typeDocument"].ToString();
                    compt3++;
                }
                rd6.Close();
                ///
                String req7 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", idTypes[1]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                SqlDataReader rd7 = cmd7.ExecuteReader();
                if (rd7.Read())
                {
                    documents[compt3] = rd7["typeDocument"].ToString();
                    compt3++;
                }
                rd7.Close();
                ///

                String req8 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", idTypes[2]);
                SqlCommand cmd8 = new SqlCommand(req8, con);
                SqlDataReader rd8 = cmd8.ExecuteReader();
                if (rd8.Read())
                {
                    documents[compt3] = rd8["typeDocument"].ToString();
                    compt3++;
                }
                rd8.Close();
                ///

                String req9 = String.Format("select typeDocument from typeDocument where idTypeDocument='{0}'", idTypes[3]);
                SqlCommand cmd9 = new SqlCommand(req9, con);
                SqlDataReader rd9 = cmd9.ExecuteReader();
                if (rd9.Read())
                {
                    documents[compt3] = rd9["typeDocument"].ToString();
                    compt3++;
                }
                rd9.Close();
                ///



                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

                int i = 0;
                while (i < compt)
                {
                    if (i < compt)
                    {
                        Image1.ImageUrl = ("nonTraité.jpg");
                        Label3.Text = employes[0];
                        Label1.Text = documents[0];
                        Label4.Text = dates[0].ToString();
                        Panel1.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        Image2.ImageUrl = ("nonTraité.jpg");
                        Label5.Text = employes[1];
                        Label2.Text = documents[1];
                        Label6.Text = dates[1].ToString();
                        Panel2.Visible = true;

                        i++;
                    }
                    if (i < compt)
                    {
                        Image3.ImageUrl = ("nonTraité.jpg");
                        Label7.Text = employes[2];
                        Label8.Text = documents[2];
                        Label9.Text = dates[2].ToString();
                        Panel3.Visible = true;

                        i++;
                    }
                    if (i < compt)
                    {
                        Image4.ImageUrl = ("nonTraité.jpg");
                        Label10.Text = employes[3];
                        Label11.Text = documents[3];
                        Label12.Text = dates[3].ToString();
                        Panel4.Visible = true;
                        i++;
                    }


                }
            }
        }

        

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["idDemande"] = idDemandes[0];
            Response.Redirect("DétailDemandeDocument.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Session["idDemande"] = idDemandes[1];
            Response.Redirect("DétailDemandeDocument.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Session["idDemande"] = idDemandes[2];
            Response.Redirect("DétailDemandeDocument.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Session["idDemande"] = idDemandes[3];
            Response.Redirect("DétailDemandeDocument.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("listeToutesDemandesDoc.aspx");
            
        }
    }
}