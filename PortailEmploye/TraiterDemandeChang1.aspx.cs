using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
     
    public partial class WebForm11 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
        String[] typeChangements = new string[4];
        String[] statutChangements = new string[4];
        String[] dateChangements = new string[4];
        int[] idEmployes = new int[4];
        string[] nomCompletsEmp = new string[4];
        int compt = 0;
        string nom = null;
        string prenom = null;
       


        protected void Page_Load(object sender, EventArgs e)
        {
            /*prendre les donnees des 4 premieres demandes de bdd*/
              SqlConnection con = new SqlConnection(conString);
              con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("SELECT TOP 4 typeChangement, statutChangement, dateChangement, idEmploye from changDPerso ORDER BY idChangDPerso DESC");
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    typeChangements[compt] = rd1["typeChangement"].ToString();
                    statutChangements[compt] = rd1["statutChangement"].ToString();
                    dateChangements[compt] =rd1["dateChangement"].ToString();
                    idEmployes[compt] = (int)rd1["idEmploye"];
                    compt++;
                }
                rd1.Close();

                String req2 = String.Format("SELECT nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[0]);
                SqlCommand cmd2 = new SqlCommand(req2, con);
                SqlDataReader rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    nom = rd2["nomEmploye"].ToString();
                    prenom = rd2["prenomEmploye"].ToString();
                    nomCompletsEmp[0] =nom+" "+prenom;
                 }
                rd2.Close();

                String req3 = String.Format("SELECT nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[1]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                while (rd3.Read())
                {
                    nom = rd3["nomEmploye"].ToString();
                    prenom = rd3["prenomEmploye"].ToString();
                    nomCompletsEmp[1] = nom + " " + prenom;
                }
                rd3.Close();

                String req4 = String.Format("SELECT nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[2]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                while (rd4.Read())
                {
                    nom = rd4["nomEmploye"].ToString();
                    prenom = rd4["prenomEmploye"].ToString();
                    nomCompletsEmp[2] = nom + " " + prenom;
                }
                rd4.Close();

                String req5 = String.Format("SELECT nomEmploye, prenomEmploye from employe where idEmploye='{0}'", idEmployes[3]);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                while (rd5.Read())
                {
                    nom = rd5["nomEmploye"].ToString();
                    prenom = rd5["prenomEmploye"].ToString();
                    nomCompletsEmp[3] = nom + " " +prenom;
                }
                rd5.Close();


            }
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;

            int i = 0;
            if (i < compt)
            {
                if (i < compt)
                {
                    if (statutChangements[i] =="traité")
                    {
                        Image1.ImageUrl = "traité.jpg";
                    }
                    if (statutChangements[i] == "non traité")
                    {
                        Image1.ImageUrl = "nonTraité.jpg";
                    }
                    Label3.Text= nomCompletsEmp[0];
                    Label1.Text = typeChangements[i];
                    Label4.Text = dateChangements[i];
                    Panel1.Visible = true;
                    i++;
                }
                if (i < compt)
                {
                    if (statutChangements[i] == "traité")
                    {
                        Image2.ImageUrl = "traité.jpg";
                    }
                    if (statutChangements[i] == "non traité")
                    {
                        Image2.ImageUrl = "nonTraité.jpg";
                    }
                    Label5.Text = nomCompletsEmp[1];
                    Label2.Text = typeChangements[i];
                    Label6.Text = dateChangements[i];
                    Panel2.Visible = true;
                    i++;
                }
                if (i < compt)
                {
                    if (statutChangements[i] == "traité")
                    {
                        Image3.ImageUrl = "traité.jpg";
                    }
                    if (statutChangements[i] == "non traité")
                    {
                        Image3.ImageUrl = "nonTraité.jpg";
                    }
                    Label7.Text = nomCompletsEmp[2];
                    Label8.Text = typeChangements[i];
                    Label9.Text = dateChangements[i];
                    Panel3.Visible = true;
                    i++;
                }
                if (i < compt)
                {
                    if (statutChangements[i] == "traité")
                    {
                        Image4.ImageUrl = "traité.jpg";
                    }
                    if (statutChangements[i] == "non traité")
                    {
                        Image4.ImageUrl = "nonTraité.jpg";
                    }
                    Label10.Text = nomCompletsEmp[3];
                    Label11.Text = typeChangements[i];
                    Label12.Text = dateChangements[i];
                    Panel4.Visible = true;
                    i++;
                }

            }
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
           if(Label1.Text == "Changement adresse")
            {
                Session["typeChangement"] = "Changement adresse";
            }
           else
            {
                if(Label1.Text == "Changement date naissance")
                {
                    Session["typeChangement"] = "Changement date naissance";
                }
                else
                {
                    if(Label1.Text == "Changement situation")
                    {
                        Session["typeChangement"] = "Changement situation";
                    }
                    else
                    {
                        if(Label1.Text == "declaration enfant")
                        {
                            Session["typeChangement"] = "declaration enfant";
                        }
                        else
                        {
                            if(Label1.Text == "Changement RIB")
                            {
                                Session["typeChangement"] = "Changement RIB";
                            }
                        }
                    }
                }
            }
            Response.Redirect("TraiterDemandeChang2.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            if (Label2.Text == "Changement adresse")
            {
                Session["typeChangement"] = "Changement adresse";
            }
            else
            {
                if (Label2.Text == "Changement date naissance")
                {
                    Session["typeChangement"] = "Changement date naissance";
                }
                else
                {
                    if (Label2.Text == "Changement situation")
                    {
                        Session["typeChangement"] = "Changement situation";
                    }
                    else
                    {
                        if (Label2.Text == "declaration enfant")
                        {
                            Session["typeChangement"] = "declaration enfant";
                        }
                        else
                        {
                            if (Label2.Text == "Changement RIB")
                            {
                                Session["typeChangement"] = "Changement RIB";
                            }
                        }
                    }
                }
            }
            Response.Redirect("TraiterDemandeChang2.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            if (Label8.Text == "Changement adresse")
            {
                Session["typeChangement"] = "Changement adresse";
            }
            else
            {
                if (Label8.Text == "Changement date naissance")
                {
                    Session["typeChangement"] = "Changement date naissance";
                }
                else
                {
                    if (Label8.Text == "Changement situation")
                    {
                        Session["typeChangement"] = "Changement situation";
                    }
                    else
                    {
                        if (Label8.Text == "declaration enfant")
                        {
                            Session["typeChangement"] = "declaration enfant";
                        }
                        else
                        {
                            if (Label8.Text == "Changement RIB")
                            {
                                Session["typeChangement"] = "Changement RIB";
                            }
                        }
                    }
                }
            }
            Response.Redirect("TraiterDemandeChang2.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            if (Label11.Text == "Changement adresse")
            {
                Session["typeChangement"] = "Changement adresse";
            }
            else
            {
                if (Label11.Text == "Changement date naissance")
                {
                    Session["typeChangement"] = "Changement date naissance";
                }
                else
                {
                    if (Label11.Text == "Changement situation")
                    {
                        Session["typeChangement"] = "Changement situation";
                    }
                    else
                    {
                        if (Label11.Text == "declaration enfant")
                        {
                            Session["typeChangement"] = "declaration enfant";
                        }
                        else
                        {
                            if (Label11.Text == "Changement RIB")
                            {
                                Session["typeChangement"] = "Changement RIB";
                            }
                        }
                    }
                }
            }
            Response.Redirect("TraiterDemandeChang2.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("ToutesDemandesChang.aspx");
        }
    }
}