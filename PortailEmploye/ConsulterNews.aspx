<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="ConsulterNews.aspx.cs" Inherits="PortailEmploye.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!doctype html>
    <html>
        <head>
       
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
                p
                {
                    width:80%;
                    height:30px;
                    overflow:hidden;
                    
                }
               .d
                {
                    display:block;
                    float:left;
                }
            </style>

      <!--  <script src="assets/js/vendor/modernizr-2.8.3-respond-1.4.2.min.js"></script>-->



        </head>
        <body>
            <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Liste des actualités</h4>
            </div>
                      <br />
             
            <div class="container">
                <div class="intro">              
                       <h2 class="section-heading mb-4">   
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;">  
                             <strong>  <asp:LinkButton ID="LinkButton3" runat="server" style="color:chocolate;" OnClick="LinkButton3_Click" Text="Annonce pour les congés"></asp:LinkButton>
                            </strong></span>
                           <br />
                        <span class="section-heading-upper"><asp:Label ID="Label1" runat="server" Text="12/12/1212" class="section-heading mb-6"></asp:Label></span>
                        </h2>
                       
                        <p><asp:Label ID="Label3" runat="server" Text="very cup of our quality artisan coffee starts with locally sourced, hand picked ingredients. Once you try it, our coffee will be a blissful addition to your everyday morning routine - we guarntee it!very cup of our quality artisan coffee starts with locally sourced,
                            hand picked ingredients. Once you try it, our coffee will be a blissful addition 
                            to your everyday morning routine - we guarntee it!" class="mb-3"></asp:Label></p>
                            <br /> <br />
                        <div class="intro-button mx-auto">
                            <asp:Button ID="Button3" runat="server" Text="Lire la suite" class="btn btn-primary btn-xl" OnClick="Button3_Click" />     
                        </div>
                     <hr /><br />
                </div>
                       
                             
             <br />
          
               
                  <div class="intro">
                      <h2 class="section-heading mb-4">
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;"> 
                                 <strong><asp:LinkButton ID="LinkButton4" runat="server" style="color:chocolate;" OnClick="LinkButton4_Click">Annonce</asp:LinkButton>
                              
                                 </strong></span>
                                <br />
                              
                           <span class="section-heading-upper"><asp:Label ID="Label4" runat="server" Text="date" class="section-heading mb-6"></asp:Label>
                           
                           </span>
                      </h2>
                         <p>  <asp:Label ID="Label5" runat="server" Text="very cup of our quality artisan coffee starts with locally sourced"  class="mb-3"></asp:Label></p>
                      <br /><br />
                           <div class="intro-button mx-auto">
                               <asp:Button ID="Button4" runat="server" Text="Lire la suite" class="btn btn-primary btn-xl" OnClick="Button4_Click" />
                           </div>
                       <hr /><br />
                    </div>

               <br />
                  <!--   -->
          
                 <div class="intro">
                      <h2 class="section-heading mb-4">
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;"> 
                                 <strong><asp:LinkButton ID="LinkButton5" runat="server" style="color:chocolate;" OnClick="LinkButton5_Click">Annonce</asp:LinkButton>  
                                 </strong>
                           
                           </span>
                                <br />
                              
                           <span class="section-heading-upper"><asp:Label ID="Label7" runat="server" Text="date" class="section-heading mb-6"></asp:Label>
                           </span>
                      </h2>
                         <p><asp:Label ID="Label8" runat="server" Text="very cup of our quality artisan coffee starts with locally sourced"  class="mb-3"></asp:Label></p>  
                      <br /><br />
                           <div class="intro-button mx-auto">
                               <asp:Button ID="Button5" runat="server" Text="Lire la suite" class="btn btn-primary btn-xl" OnClick="Button5_Click"/>
                           </div>
                     <hr /> <br />
                    </div>

               
                
                <br />

                <!--  -->
          
                 <div class="intro">
                      <h2 class="section-heading mb-4">
                           <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;"> 
                                 <strong>
                                     <asp:LinkButton ID="LinkButton6" runat="server" style="color:chocolate;" OnClick="LinkButton6_Click">Annonce</asp:LinkButton>  
                                 </strong></span>
                                <br />
                              
                           <span class="section-heading-upper">
                               <asp:Label ID="Label11" runat="server" Text="date" class="section-heading mb-6"></asp:Label>
                           </span>
                      </h2>
                   <p><asp:Label ID="Label12" runat="server"  Text="very cup of our quality artisan coffee starts with locally sourced"  class="mb-3"></asp:Label></p>  
                      <br /><br />
                           <div class="intro-button mx-auto">
                               <asp:Button ID="Button6" runat="server"  Text="Lire la suite" class="btn btn-primary btn-xl" OnClick="Button6_Click" />
                           </div>
                      <hr /> <br />
                    </div>

               
                
               
    
                <br />

                        <!--  -->
          
                        <div class="intro">
                              <h2 class="section-heading mb-4">
                                   <span class="section-heading-lower" style="text-decoration:underline;font-size:30px;"> 
                                         <strong><asp:LinkButton ID="LinkButton7" runat="server" style="color:chocolate;" OnClick="LinkButton7_Click">Annonce</asp:LinkButton>  
                                         </strong>
                                   
                                   </span>
                                        <br />
                              
                                   <span class="section-heading-upper"><asp:Label ID="Label13" runat="server"  Text="date" class="section-heading mb-6"></asp:Label>
                                   </span>
                              </h2>
                                <p><asp:Label ID="Label14" runat="server" Text="very cup of our quality artisan coffee starts with locally sourced very cup of our quality artisan coffee starts with locally sourced"  class="mb-3"></asp:Label></p>   
                              <br /><br />  
                                   <div class="intro-button mx-auto">
                                       <asp:Button ID="Button7" runat="server" Text="Lire la suite" class="btn btn-primary btn-xl" OnClick="Button7_Click" />
                                   </div>
                            <hr /><br />
                            </div>

                        <br />

                </div>
        </body>
    </html>

</asp:Content>
