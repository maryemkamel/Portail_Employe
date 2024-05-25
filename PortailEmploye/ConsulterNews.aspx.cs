using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace PortailEmploye
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
        String[] titres = new string[5];
        String[] descriptions = new string[5];
        string[] dates = new string[5];
        string[] fiches = new string[5];
        Boolean[] etats = new Boolean[5];
        int compt=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["titre"] = null;
            Session["description"] = null;
            Session["date"] = null;
            Session["ficheJointe"] = null;
            Session["etat"] = null;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("SELECT TOP 5 titreNews, descriptionNews, dateNews, ficheJointe, etatFicheJointe FROM news ORDER BY idNews DESC");
                 SqlCommand cmd1 = new SqlCommand(req1, con);
                 SqlDataReader rd1 = cmd1.ExecuteReader();
                 while (rd1.Read())
                 {
                    titres[compt] = rd1["titreNews"].ToString();
                    descriptions[compt] = rd1["descriptionNews"].ToString();
                    dates[compt] = rd1["dateNews"].ToString();
                    fiches[compt] = rd1["ficheJointe"].ToString();
                    etats[compt] =(Boolean)rd1["etatFicheJointe"];
                    compt++;
                }
                rd1.Close();
                LinkButton3.Visible = false;
                LinkButton4.Visible = false;
                LinkButton5.Visible = false;
                LinkButton6.Visible = false;
                LinkButton7.Visible = false;

                Label3.Visible = false;
                Label5.Visible = false;
                Label8.Visible = false;
                Label12.Visible = false;
                Label14.Visible = false;

                Label1.Visible = false;
                Label4.Visible = false;
                Label7.Visible = false;
                Label11.Visible = false;
                Label13.Visible = false;


                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                Button6.Visible = false;
                Button7.Visible = false;

                int i = 0;
                while(i < compt)
                {
                    if (i < compt)
                    {
                        LinkButton3.Text = null;
                        LinkButton3.Text = titres[i].ToString();
                        LinkButton3.Visible = true;
                        Label3.Text = null;
                        Label3.Text = descriptions[i].ToString();
                        Label3.Visible = true;
                        Label1.Text = null;
                        Label1.Text = dates[i].ToString();
                        Label1.Visible = true;
                        Button3.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton4.Text = null;
                        LinkButton4.Text = titres[i].ToString();
                        LinkButton4.Visible = true;
                        Label5.Text = null;
                        Label5.Text = descriptions[i].ToString();
                        Label5.Visible = true;
                        Label4.Text = null;
                        Label4.Text = dates[i].ToString();
                        Label4.Visible = true;
                        Button4.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton5.Text = null;
                        LinkButton5.Text = titres[i].ToString();
                        LinkButton5.Visible = true;
                        Label8.Text = null;
                        Label8.Text = descriptions[i].ToString();
                        Label8.Visible = true;
                        Label7.Text = null;
                        Label7.Text = dates[i].ToString();
                        Label7.Visible = true;
                        Button5.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton6.Text = null;
                        LinkButton6.Text = titres[i].ToString();
                        LinkButton6.Visible = true;
                        Label12.Text = null;
                        Label12.Text = descriptions[i].ToString();
                        Label12.Visible = true;
                        Label11.Text = null;
                        Label11.Text = dates[i].ToString();
                        Label11.Visible = true;
                        Button6.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton7.Text = null;
                        LinkButton7.Text = titres[i].ToString();
                        LinkButton7.Visible = true;
                        Label14.Text = null;
                        Label14.Text = descriptions[i].ToString();
                        Label14.Visible = true;
                        Label13.Text = null;
                        Label13.Text = dates[i].ToString();
                        Label13.Visible = true;
                        Button7.Visible = true;
                        i++;
                    }

                }
            }

            
            
        }

                protected void Button3_Click(object sender, EventArgs e)
        {
            
            Session["titre"] = LinkButton3.Text;
            Session["description"] = Label3.Text;
            Session["date"] = Label1.Text;
            Session["etat"] = etats[0];
            Session["ficheJointe"] = fiches[0];
            Response.Redirect("DetailsNews.aspx");
            /*  Session["ficheJointe"] = ;*/


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            Session["titre"] = LinkButton4.Text;
            Session["description"] = Label5.Text;
            Session["date"] = Label4.Text;
            Session["etat"] = etats[1];
            Session["ficheJointe"] = fiches[1];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            
            Session["titre"] = LinkButton5.Text;
            Session["description"] = Label8.Text;
            Session["date"] = Label7.Text;
            Session["etat"] = etats[2];
            Session["ficheJointe"] = fiches[2];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
            Session["titre"] = LinkButton6.Text;
            Session["description"] = Label12.Text;
            Session["date"] = Label11.Text;
            Session["etat"] = etats[3];
            Session["ficheJointe"] = fiches[3];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            Session["titre"] = LinkButton7.Text;
            Session["description"] = Label14.Text;
            Session["date"] = Label13.Text;
            Session["etat"] = etats[4];
            Session["ficheJointe"] = fiches[4];
            Response.Redirect("DetailsNews.aspx");
        }

        public void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["titre"] = LinkButton3.Text;
            Session["description"] = Label3.Text;
            Session["date"] = Label1.Text;
            Session["etat"] = etats[0];
            Session["ficheJointe"] = fiches[0];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["titre"] = LinkButton4.Text;
            Session["description"] = Label5.Text;
            Session["date"] = Label4.Text;
            Session["etat"] = etats[1];
            Session["ficheJointe"] = fiches[1];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["titre"] = LinkButton5.Text;
            Session["description"] = Label8.Text;
            Session["date"] = Label7.Text;
            Session["etat"] = etats[2];
            Session["ficheJointe"] = fiches[2];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {

            Session["titre"] = LinkButton6.Text;
            Session["description"] = Label12.Text;
            Session["date"] = Label11.Text;
            Session["etat"] = etats[3];
            Session["ficheJointe"] = fiches[3];
            Response.Redirect("DetailsNews.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["titre"] = LinkButton7.Text;
            Session["description"] = Label14.Text;
            Session["date"] = Label13.Text;
            Session["etat"] = etats[4];
            Session["ficheJointe"] = fiches[4];
            Response.Redirect("DetailsNews.aspx");
        }

       
    }


}