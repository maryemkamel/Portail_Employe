using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
        String[] titres = new string[5];
        String[] details = new string[5];
        string[] dates = new string[5];
        string[] conditions = new string[5];
        string[] statuts = new string[5];
        int[] ids = new int[5];
        int compt = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Button7.Visible = false;
            Session["idOffre"] = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String req1 = String.Format("SELECT TOP 5 idOffre,titreOffre, detailOffre, conditionsOffre, dateOffre, statutOffre FROM offre ORDER BY idOffre DESC");
                SqlCommand cmd1 = new SqlCommand(req1, con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                while (rd1.Read())
                {
                    ids[compt] = (int)rd1["idOffre"];
                    titres[compt] = rd1["titreOffre"].ToString();
                    details[compt] = rd1["detailOffre"].ToString();
                    dates[compt] = rd1["dateOffre"].ToString();
                    conditions[compt] = rd1["conditionsOffre"].ToString();
                    statuts[compt] = rd1["statutOffre"].ToString();
                    compt++;
                }
                rd1.Close();
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel3.Visible = false;
                Panel4.Visible = false;

              

                int i = 0;
                while (i < compt)
                {
                    if (i < compt)
                    {
                        LinkButton3.Text = null;
                        LinkButton3.Text = titres[i].ToString();
                        Label1.Text = null;
                        Label1.Text = dates[i].ToString();
                        Label3.Text = null;
                        Label3.Text = details[i].ToString();
                        Panel1.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton4.Text = null;
                        LinkButton4.Text = titres[i].ToString();
                        Label4.Text = null;
                        Label4.Text = dates[i].ToString();
                        Label5.Text = null;
                        Label5.Text = details[i].ToString();
                        Panel2.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton5.Text = null;
                        LinkButton5.Text = titres[i].ToString();
                        Label7.Text = null;
                        Label7.Text = dates[i].ToString();
                        Label8.Text = null;
                        Label8.Text = details[i].ToString();
                        Panel3.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton6.Text = null;
                        LinkButton6.Text = titres[i].ToString();
                        Label11.Text = null;
                        Label11.Text = dates[i].ToString();
                        Label12.Text = null;
                        Label12.Text = details[i].ToString();
                        Panel4.Visible = true;
                        i++;
                    }
                    if (i < compt)
                    {
                        LinkButton7.Text = null;
                        LinkButton7.Text = titres[i].ToString();
                        Label13.Text = null;
                        Label13.Text = dates[i].ToString();
                        Label14.Text = null;
                        Label14.Text = details[i].ToString();
                        Button7.Visible = true;
                        Panel5.Visible = true;
                        i++;
                    }

                }
            }



        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[0];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[1];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void Button5_Click1(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[2];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[3];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[4];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[0];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[1];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[2];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[3];
            Response.Redirect("DetailsOffre.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["idOffre"] = ids[4];
            Response.Redirect("DetailsOffre.aspx");
        }
    }
}