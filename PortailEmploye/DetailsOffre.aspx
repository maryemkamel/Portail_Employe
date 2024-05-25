<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="DetailsOffre.aspx.cs" Inherits="PortailEmploye.WebForm20" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!doctype html>
    <html>
        <head>
            <meta charset="utf-8" />

            <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Business Casual - Start Bootstrap Theme</title>
        <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
        <!-- Font Awesome icons (free version)-->
        <script src="https://use.fontawesome.com/releases/v5.15.3/js/all.js" crossorigin="anonymous"></script>
        <!-- Google fonts-->
        <link href="https://fonts.googleapis.com/css?family=Raleway:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet" />
        <link href="https://fonts.googleapis.com/css?family=Lora:400,400i,700,700i" rel="stylesheet" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href="css/styles.css" rel="stylesheet" />

                   
            <style>
             /*  p
                {
                    width:80%;
                    height:30px;
                    overflow:hidden;
                    
                }*/ 
               .d
                {
                    display:block;
                    float:left;
                }
            </style>
           

        <script src="assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>



        </head>
        <body>
                        <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Détail de l'offre</h4></div>

                        

            <br />
             
            <div class="container">
                <div class="intro">              
                       <h2 class="section-heading mb-4">   
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:40px;">  
                             <strong> 
                                    <asp:Label ID="Label6" runat="server" Text="" style="color:chocolate;"></asp:Label>&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="épuisé" class="btn btn-warning" OnClick="Button2_Click" />
                            </strong>
                           </span>
                           <br />
                        <span class="section-heading-upper">
                            <asp:Label ID="Label4" runat="server" Text="" class="section-heading mb-6"></asp:Label>

                        </span>
                        </h2>
                       <label class="section-heading mb-6" style="color:chocolate;">Statut</label>
                        <p>
                            <asp:Label ID="Label5" runat="server" Text="" class="mb-3"></asp:Label>
                        </p>
                    <label class="section-heading mb-6" style="color:chocolate;">Détail</label>
                      <p>
                            <asp:Label ID="Label1" runat="server" Text="" class="mb-3"></asp:Label>
                        </p>
                    <label class="section-heading mb-6" style="color:chocolate;">Conditions</label>
                      <p>
                            <asp:Label ID="Label2" runat="server" Text="" class="mb-3"></asp:Label>
                        </p>
                            
                            <br /> <br />
                    <asp:Panel ID="Panel1" runat="server" class="intro-button mx-auto">
                    
                            <asp:Label ID="Label3" runat="server" Text="Commentaire"></asp:Label> &nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-xl" Text="Postuler" OnClick="Button1_Click" />
                                             
                       </asp:Panel>
                       
                     <hr /><br />
                </div>                                 
             <br />      
                </div>
        </body>
    </html>
</asp:Content>
