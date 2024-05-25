using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public String conString = "Data Source=DESKTOP-FJ8DKG3\\SQLEXPRESS;Initial Catalog=collab;Integrated Security=True";
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            int etatFiche;
            String savePath = @"c:\temp\uploads\";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (FileUpload2.HasFile)
            {
                etatFiche = 1;
                String fileName = FileUpload2.FileName;
                savePath += fileName;
                FileUpload2.SaveAs(savePath);
                Label1.Text = "Votre fichier est enregistré sous le nom : " + fileName;
            }
            else
            {
                etatFiche = 0;
                savePath = null;
            }

                if (con.State == System.Data.ConnectionState.Open)
                {
                
                String req = String.Format("insert into news(titreNews,descriptionNews,dateNews,ficheJointe,etatFicheJointe) values ('{0}','{1}',SYSDATETIME (),'{2}','{3}')", TextBox1.Text, TextBox3.Text, savePath, etatFiche);

                    SqlCommand cmd = new SqlCommand(req, con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
         
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = null;
        }
    }
}