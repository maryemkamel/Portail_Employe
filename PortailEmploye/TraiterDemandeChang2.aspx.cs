using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                
                String req6 = String.Format("select typeChangement,idEmploye from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {

                    Session["typ"] = rd6["typeChangement"].ToString();
                    Session["empl"] =(int)rd6["idEmploye"];
                }
                rd6.Close();
            }
                if ((Session["typ"].ToString()) == "adresse")
            {
                String req6 = String.Format("select ville,quartier,adresse from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    TextBox1.Text = rd6["adresse"].ToString();
                    TextBox2.Text = rd6["quartier"].ToString();
                    TextBox3.Text = rd6["ville"].ToString();


                }
                rd6.Close();
                String req7 = String.Format("select nouvelleAdr,quartier,ville,copieCIN from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                SqlDataReader rd7 = cmd7.ExecuteReader();
                if (rd7.Read())
                {

                    TextBox4.Text = rd7["nouvelleAdr"].ToString();
                    TextBox5.Text = rd7["quartier"].ToString();
                    TextBox6.Text = rd7["ville"].ToString();
                    Session["docAdress"]= rd7["copieCIN"].ToString();
                    LinkButton1.Click += new EventHandler(DynamicClick);
                  

                }
                rd6.Close();
                Panel1.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Panel6.Visible = false;
            }
            if (Session["typ"].ToString() == "date Naissance")
            {
                String req6 = String.Format("select dateNaissance,lieuNaissance from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    TextBox7.Text =rd6["dateNaissance"].ToString();
                    TextBox8.Text = rd6["lieuNaissance"].ToString();

                }
                rd6.Close();
                String req7 = String.Format("select dateNaissance,lieuNaissance,extraitNaissance from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                SqlDataReader rd7 = cmd7.ExecuteReader();
                if (rd7.Read())
                {

                    TextBox10.Text = rd7["dateNaissance"].ToString();
                    TextBox9.Text = rd7["lieuNaissance"].ToString();
                    Session["docDateNaiss"] = rd7["extraitNaissance"].ToString();
                    LinkButton2.Click += new EventHandler(DynamicClick2);


                }
                rd7.Close();
                Panel2.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
                Panel6.Visible = false;
            }
            if ((Session["typ"].ToString()) == "situation familiale")
            {
                String req3 = String.Format("select idSituation from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                if (rd3.Read())
                {
                    Session["idsit"] = (int)rd3["idSituation"];
                }
                rd3.Close();

                String req4 = String.Format("select nomSituation from situationfamiliale where idSituation='{0}'", Session["idsit"]);
                SqlCommand cmd4 = new SqlCommand(req4, con);
                SqlDataReader rd4 = cmd4.ExecuteReader();
                if (rd4.Read())
                {
                    Session["sitActuelle"] = rd4["nomSituation"].ToString();
                }
                rd4.Close();

                TextBox13.Text = Session["sitActuelle"].ToString();

                String req5 = String.Format("select nouvelleSituation from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                if (rd5.Read())
                {
                    Session["sitNouvelle"] = rd5["nouvelleSituation"].ToString();
                }
                rd5.Close();
                if((Session["sitNouvelle"]).ToString() == "divorcé")
                {
                    TextBox14.Text = (Session["sitNouvelle"]).ToString();
                }
                else if((Session["sitNouvelle"]).ToString() == "marié")
                {
                String req6 = String.Format("select dateMariage,nomPrenomConjoint,fonctionConjoint,appartenanceConjoint,acteMariage from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                        TextBox14.Text = Session["sitNouvelle"].ToString();
                        TextBox16.Text = rd6["dateMariage"].ToString();
                        TextBox11.Text = rd6["nomPrenomConjoint"].ToString();
                        TextBox12.Text = rd6["fonctionConjoint"].ToString();
                        if((Boolean)rd6["appartenanceConjoint"] == false)
                        {
                            Label1.Text = "NON";
                        }
                        else if((Boolean)rd6["appartenanceConjoint"] == true)
                        {
                            Label1.Text = "OUI";
                        }
                        Session["docSitFamille"] = rd6["acteMariage"].ToString();
                        LinkButton3.Click += new EventHandler(DynamicClick3);



                }
                    rd6.Close();
                }
                Panel2.Visible = false;
                Panel1.Visible = false;
                Panel5.Visible = false;
                Panel6.Visible = false;
            }
            if (Session["typ"].ToString() == "Naissance enfant")
            {
                String req6 = String.Format("select nbreEnfants from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    TextBox19.Text =rd6["nbreEnfants"].ToString();

                }
                rd6.Close();
                String req7 = String.Format("select nomPrenomEnfant,dateNaissanceEnfant,sexeEnfant,enfACharge,acteNaissance from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                SqlDataReader rd7 = cmd7.ExecuteReader();
                if (rd7.Read())
                {

                    TextBox22.Text = rd7["dateNaissanceEnfant"].ToString();
                    TextBox23.Text = rd7["nomPrenomEnfant"].ToString();
                    if(rd7["sexeEnfant"].ToString() =="masculin")
                    {
                        Label2.Text = "masculin";
                    }
                    else if(rd7["sexeEnfant"].ToString() == "feminin")
                    {
                        Label2.Text = "feminin";
                    }
                    if ((Boolean)rd7["enfACharge"] == true)
                    {
                        Label3.Text = "OUI";
                    }
                    else if ((Boolean)rd7["enfACharge"] == false)
                    {
                        Label3.Text = "NON";
                    }
                    Session["docActeNaiss"] = rd7["acteNaissance"].ToString();
                    LinkButton4.Click += new EventHandler(DynamicClick4);


                }
                rd7.Close();
                Panel2.Visible = false;
                Panel1.Visible = false;
                Panel4.Visible = false;
                Panel6.Visible = false;
            }
            if (Session["typ"].ToString() == "RIB")
            {
                String req6 = String.Format("select RIB,nomBanque from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                SqlDataReader rd6 = cmd6.ExecuteReader();
                if (rd6.Read())
                {
                    TextBox25.Text = rd6["nomBanque"].ToString();
                    TextBox26.Text = rd6["RIB"].ToString();

                }
                rd6.Close();
                String req7 = String.Format("select nouvelleBanque,nouveauRIB,demandeChangRIB,attestationNvRib,MainLevee from changDPerso where idChangDPerso='{0}'", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                SqlDataReader rd7 = cmd7.ExecuteReader();
                if (rd7.Read())
                {

                    TextBox28.Text = rd7["nouvelleBanque"].ToString();
                    TextBox29.Text = rd7["nouveauRIB"].ToString();
                    Session["docDemande"] = rd7["demandeChangRIB"].ToString();
                    Session["docAttestation"] = rd7["attestationNvRib"].ToString();
                    Session["docMainLevee"] = rd7["MainLevee"].ToString();
                    LinkButton5.Click += new EventHandler(DynamicClick5);
                    LinkButton6.Click += new EventHandler(DynamicClick6);
                    LinkButton7.Click += new EventHandler(DynamicClick7);


                }
                rd7.Close();
                Panel2.Visible = false;
                Panel1.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
            }
    
        }

        private void DynamicClick7(object sender, EventArgs e)
        {
            if (Session["docMainLevee"].ToString() != null)
            {
                string filePath = Session["docMainLevee"].ToString();
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
            else
            {
                LinkButton7.Visible = false;
            }
        }

        private void DynamicClick6(object sender, EventArgs e)
        {
              if (Session["docAttestation"].ToString() != null)
            {
                string filePath = Session["docAttestation"].ToString();
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
        }
                    else
                    {
                       LinkButton6.Visible = false;
                    }
        }

        private void DynamicClick5(object sender, EventArgs e)
        {
            if (Session["docDemande"].ToString() != null)
            {
                string filePath = Session["docDemande"].ToString();
        FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
                  else
                    {
                     LinkButton5.Visible = false;
                    }
        }

        private void DynamicClick4(object sender, EventArgs e)
        {
             if (Session["docActeNaiss"].ToString() != null)
            {
                string filePath = Session["docActeNaiss"].ToString();
        FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
             }
                  else
                    {
                LinkButton4.Visible = false;
                    }
        }

        private void DynamicClick3(object sender, EventArgs e)
        {
            if (Session["docSitFamille"].ToString() != null)
            {
                string filePath = Session["docSitFamille"].ToString();
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
            else
            {
                LinkButton3.Visible = false;
            }
        }

        private void DynamicClick2(object sender, EventArgs e)
        {
            if (Session["docDateNaiss"].ToString() != null)
            {
                string filePath = Session["docDateNaiss"].ToString();
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
            else
            {
                LinkButton2.Visible = false;
            }
        }

        private void DynamicClick(object sender, EventArgs e)
        {
            if (Session["docAdress"].ToString() != null)
            {
                string filePath = Session["docAdress"].ToString();
                FileInfo file = new FileInfo(filePath);
                if (file.Exists)
                {
                    // Clear Rsponse reference  
                    Response.Clear();
                    // Add header by specifying file name  
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                    // Add header for content length  
                    Response.AddHeader("Content-Length", file.Length.ToString());
                    // Specify content type  
                    Response.ContentType = "plain";
                    // Clearing flush  
                    Response.Flush();
                    // Transimiting file  
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
            else
            {
                LinkButton1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if ((Session["typ"].ToString()) == "adresse")
                {
                    String req6 = String.Format("UPDATE employe set ville = '{0}',quartier= '{1}',adresse= '{2}' WHERE idEmploye='{3}'", TextBox6.Text, TextBox5.Text, TextBox4.Text, Session["empl"]);
                    SqlCommand cmd6 = new SqlCommand(req6, con);
                    cmd6.ExecuteNonQuery();

                    String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'","accepté", Session["idChoisi"]);
                    SqlCommand cmd7 = new SqlCommand(req7, con);
                    cmd7.ExecuteNonQuery();


                }
            }

            if (Session["typ"].ToString() == "date Naissance")
            {
                String req6 = String.Format("UPDATE employe set dateNaissance = '{0}',lieuNaissance= '{1}' WHERE idEmploye='{2}'", TextBox10.Text, TextBox9.Text, Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                cmd6.ExecuteNonQuery();

                String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'", "accepté", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                cmd7.ExecuteNonQuery();

            }
            if ((Session["typ"].ToString()) == "situation familiale")
            {
                String req5 = String.Format("select idSituation from situationfamiliale where nomSituation='{0}'", TextBox14.Text);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                if (rd5.Read())
                {

                    Session["sit"] = (int)rd5["idSituation"];
                }
                rd5.Close();


                String req6 = String.Format("UPDATE employe set idSituation = '{0}' WHERE idEmploye='{1}'", Session["sit"], Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                cmd6.ExecuteNonQuery();

                String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'", "accepté", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                cmd7.ExecuteNonQuery();
            }
            if (Session["typ"].ToString() == "Naissance enfant")
            {
                String req5 = String.Format("select nbreEnfants from employe where idEmploye='{0}'", Session["empl"]);
                SqlCommand cmd5 = new SqlCommand(req5, con);
                SqlDataReader rd5 = cmd5.ExecuteReader();
                if (rd5.Read())
                {
                    int nbre = (int)rd5["nbreEnfants"];
                    nbre++;
                    Session["nbreEnfants"] = nbre;
                }
                rd5.Close();

                String req6 = String.Format("UPDATE employe set nbreEnfants = '{0}' WHERE idEmploye='{1}'", Session["nbreEnfants"], Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                cmd6.ExecuteNonQuery();

                String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'", "accepté", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                cmd7.ExecuteNonQuery();
            }
            if (Session["typ"].ToString() == "RIB")
            {
                String req6 = String.Format("UPDATE employe set RIB = '{0}',nomBanque='{1}' WHERE idEmploye='{2}'", TextBox29.Text, TextBox28.Text, Session["empl"]);
                SqlCommand cmd6 = new SqlCommand(req6, con);
                cmd6.ExecuteNonQuery();

                String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'", "accepté", Session["idChoisi"]);
                SqlCommand cmd7 = new SqlCommand(req7, con);
                cmd7.ExecuteNonQuery();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                

                    String req7 = String.Format("UPDATE changDPerso set statutChangement = '{0}' WHERE idChangDPerso='{1}'","refusé", Session["idChoisi"]);
                    SqlCommand cmd7 = new SqlCommand(req7, con);
                    cmd7.ExecuteNonQuery();


                
            }
        }
    }
}