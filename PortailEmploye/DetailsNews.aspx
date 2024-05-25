<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="DetailsNews.aspx.cs" Inherits="PortailEmploye.WebForm7" %>
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
                        <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Détail de l'actualité</h4></div>

            <br />
             
            <div class="container">
                <div class="intro">              
                       <h2 class="section-heading mb-4">   
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;">  
                             <strong> 
                                    <asp:Label ID="Label6" runat="server" Text="Titre" style="color:chocolate;"></asp:Label>
                            </strong>
                           </span>
                           <br />
                        <span class="section-heading-upper">
                            <asp:Label ID="Label4" runat="server" Text="date" class="section-heading mb-6"></asp:Label></span>
                        </h2>
                       
                        <p>
                            <asp:Label ID="Label5" runat="server" Text="very cup of our quality artisan coffee starts with locally sourced, hand picked ingredients. Once you try it, our coffee will be a blissful addition to your everyday morning routine - we guarntee it!very cup of our quality artisan coffee starts with locally sourced,
                            hand picked ingredients. Once you try it, our coffee will be a blissful addition 
                            very cup of our quality artisan coffee starts with locally sourced, hand picked ingredients. Once you try it, our coffee will be a blissful addition to your everyday morning routine - we guarntee it!very cup of our quality artisan coffee starts with locally sourced,
                            hand picked ingredients. Once you try it, our coffee will be a blissful addition 
                            very cup of our quality artisan coffee starts with locally sourced, hand picked ingredients. Once you try it, our coffee will be a blissful addition to your everyday morning routine - we guarntee it!very cup of our quality artisan coffee starts with locally sourced,
                            hand picked ingredients. Once you try it, our coffee will be a blissful addition 
                            to your everyday morning routine - we guarntee it!" class="mb-3"></asp:Label>
                        </p>
                            
                            <br /> <br />
                        <div class="intro-button mx-auto">
                           <!-- <asp:LinkButton ID="LinkButton5" runat="server" class="btn btn-primary btn-xl" Text="Telecharger fiche"></asp:LinkButton>-->
                           <!--  <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="CHAPITRE_I.pdf">Exemple</asp:HyperLink>-->
                           
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" class="btn btn-primary btn-xl">Telecharger fiche</asp:LinkButton>

                        </div>
                     <hr /><br />
                </div>                                 
             <br />      
                </div>
        </body>
    </html>

</asp:Content>

