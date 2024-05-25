using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["typ"] = null;

            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            FileUpload2.Enabled = false;


            TextBox10.Enabled = false;
            TextBox9.Enabled = false;
            FileUpload7.Enabled = false;


            DropDownList1.Enabled = false;
            TextBox16.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;
            RadioButtonList1.Enabled = false;
            FileUpload6.Enabled = false;


            TextBox22.Enabled = false;
            TextBox23.Enabled = false;
            RadioButtonList2.Enabled = false;
            RadioButtonList3.Enabled = false;
            FileUpload4.Enabled = false;

            TextBox28.Enabled = false;
            TextBox29.Enabled = false;
            FileUpload5.Enabled = false;
            FileUpload1.Enabled = false;
            FileUpload3.Enabled = false;


            

        }

       protected void Button2_Click(object sender, EventArgs e)
        {

            Session["typ"] = "adresse";
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
            FileUpload2.Enabled = true;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Session["typ"] = "date Naissance";
            TextBox10.Enabled = true;
            TextBox9.Enabled = true;
            FileUpload7.Enabled = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            Session["typ"] = "situation familiale";
            DropDownList1.Enabled = true;
            TextBox16.Enabled = true;
            TextBox11.Enabled = true;
            TextBox12.Enabled = true;
            RadioButtonList1.Enabled = true;
            FileUpload6.Enabled = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            Session["typ"] = "Naissance enfant";
            TextBox22.Enabled = true;
            TextBox23.Enabled = true;
            RadioButtonList2.Enabled = true;
            RadioButtonList3.Enabled = true;
            FileUpload4.Enabled = true;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            Session["typ"] = "RIB";
            TextBox28.Enabled = true;
            TextBox29.Enabled = true;
            FileUpload5.Enabled = true;
            FileUpload1.Enabled = true;
            FileUpload3.Enabled = true;
        }
        string etat;
        protected void Button7_Click(object sender, EventArgs e)
        {
            
            String savePath = @"c:\temp\documents\";
            String savePath1 = @"c:\temp\documents\";
            String savePath2 = @"c:\temp\documents\";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                Session["idlog"]=0;
                Session["idEmp"]=0;
                string nom;
                string prenom;
                

                String req3 = String.Format("select idLogin from authentification where login='{0}'", Session["login"]);
                SqlCommand cmd3 = new SqlCommand(req3, con);
                SqlDataReader rd2 = cmd3.ExecuteReader();
                if(rd2.Read())
                {
                Session["idlog"] = (int)rd2["idLogin"];
                rd2.Close();
                }
                else
                {
                    Response.Redirect("ChangerD.aspx");
                }
                rd2.Close();
                String req1 = String.Format("select idEmploye,nomEmploye,prenomEmploye from employe where idLogin='{0}'", Session["idlog"]);
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if(rd1.Read())
                {
                Session["idEmp"] = (int)rd1["idEmploye"];
                
                }
                else
                {
                    Response.Redirect("ChangerD.aspx");
                }
                rd1.Close();

                if (Session["typ"].ToString() == "adresse")
                {
                    if (FileUpload2.HasFile)
                    {

                        String fileName = FileUpload2.FileName;
                        savePath += fileName;
                        FileUpload2.SaveAs(savePath);

                    }
                    else
                    {
                        savePath = null;
                    }
                    String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,nouvelleAdr,quartier,ville,copieCIN) values('{0}','{1}',SYSDATETIME (),'{2}','{3}','{4}','{5}','{6}')", Session["typ"], "non traité", Session["idEmp"], TextBox4.Text, TextBox5.Text, TextBox6.Text, savePath);
                    SqlCommand cmd2 = new SqlCommand(req2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else
                if (Session["typ"].ToString() == "date Naissance")
                {
                    if (FileUpload7.HasFile)
                    {

                        String fileName = FileUpload7.FileName;
                        savePath += fileName;
                        FileUpload7.SaveAs(savePath);

                    }
                    else
                    {
                        savePath = null;
                    }
                    String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,dateNaissance,lieuNaissance,extraitNaissance) values('{0}','{1}',SYSDATETIME (),'{2}','{3}','{4}','{5}')", Session["typ"], "non traité", Session["idEmp"], TextBox10.Text, TextBox9.Text, savePath);
                    SqlCommand cmd2 = new SqlCommand(req2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (Session["typ"].ToString() == "situation familiale")
                {
                    if(DropDownList1.SelectedValue == "1")
                    {
                        if (FileUpload6.HasFile)
                        {

                            String fileName = FileUpload6.FileName;
                            savePath += fileName;
                            FileUpload6.SaveAs(savePath);

                        }
                        else
                        {
                            savePath = null;
                        }
                        string appartenance = RadioButtonList1.SelectedValue;
                        Session["appart"] = 0 ;
                        if(appartenance== "OUI") { Session["appart"] = 1; }
                        else if(appartenance == "NON") { Session["appart"] = 0; }

                        String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,nouvelleSituation,dateMariage,nomPrenomConjoint,fonctionConjoint,appartenanceConjoint,acteMariage) values('{0}','{1}',SYSDATETIME (),'{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Session["typ"], "non traité", Session["idEmp"],"marié", TextBox16.Text, TextBox11.Text, TextBox12.Text, Session["appart"], savePath);
                        SqlCommand cmd2 = new SqlCommand(req2, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    else if (DropDownList1.SelectedValue == "2")
                    {
                        String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,nouvelleSituation) values('{0}','{1}',SYSDATETIME (),'{2}','{3}')", Session["typ"], "non traité", Session["idEmp"],"divorcé");
                        SqlCommand cmd2 = new SqlCommand(req2, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
                if (Session["typ"].ToString() == "Naissance enfant")
                {
                    if (FileUpload4.HasFile)
                    {

                        String fileName = FileUpload4.FileName;
                        savePath += fileName;
                        FileUpload4.SaveAs(savePath);

                    }
                    else
                    {
                        savePath = null;
                    }
                    string acharge = RadioButtonList3.SelectedValue;
                    Session["Acharge"] = 0;
                    if (acharge == "OUI") { Session["Acharge"] = 1; }
                    else if (acharge == "NON") { Session["Acharge"] = 0; }
                    string aCharge = RadioButtonList3.SelectedValue;
                    String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,nomPrenomEnfant,dateNaissanceEnfant,sexeEnfant,enfACharge,acteNaissance) values('{0}','{1}',SYSDATETIME (),'{2}','{3}','{4}','{5}','{6}','{7}')", Session["typ"], "non traité", Session["idEmp"], TextBox23.Text, TextBox22.Text, RadioButtonList2.SelectedValue, Session["Acharge"], savePath);
                    SqlCommand cmd2 = new SqlCommand(req2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                if (Session["typ"].ToString() == "RIB")
                {
                    if (FileUpload5.HasFile)
                    {

                        String fileName = FileUpload5.FileName;
                        savePath += fileName;
                        FileUpload5.SaveAs(savePath);

                    }
                    else
                    {
                        savePath = null;
                    }
                    if (FileUpload1.HasFile)
                    {

                        String fileName = FileUpload1.FileName;
                        savePath1 += fileName;
                        FileUpload1.SaveAs(savePath1);

                    }
                    else
                    {
                        savePath1 = null;
                    }
                    if (FileUpload3.HasFile)
                    {

                        String fileName = FileUpload3.FileName;
                        savePath2 += fileName;
                        FileUpload3.SaveAs(savePath2);

                    }
                    else
                    {
                        savePath2 = null;
                    }

                    int rib2 = Int32.Parse(TextBox29.Text);
                    String req2 = String.Format("insert into changDPerso(typeChangement,statutChangement,dateChangement,idEmploye,nouvelleBanque,nouveauRIB,demandeChangRIB,attestationNvRib,MainLevee) values('{0}','{1}',SYSDATETIME (),'{2}','{3}','{4}','{5}','{6}','{7}')", Session["typ"], "non traité", Session["idEmp"], TextBox28.Text, rib2, savePath, savePath1, savePath2);
                    SqlCommand cmd2 = new SqlCommand(req2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }


            }
        }
            
            
        }
    }

