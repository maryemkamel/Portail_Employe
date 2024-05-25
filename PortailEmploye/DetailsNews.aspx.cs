using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PortailEmploye
{

    public partial class WebForm7 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Label6.Text = (string)Session["titre"];
            Label4.Text = (string)Session["date"];
            Label5.Text = (string)Session["description"];
            Boolean etat = (Boolean)Session["etat"];
            String lien = (string)Session["ficheJointe"];
            if(etat == false)
            {
                LinkButton1.Visible = false;
            }
         
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if ((Boolean)Session["etat"] == true)
            { 


                string filePath = (string)Session["ficheJointe"];
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
            }else
            {
                LinkButton1.Visible = false;
            }
        }

    }
    }
