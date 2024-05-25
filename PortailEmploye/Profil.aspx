<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="PortailEmploye.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!doctype html>
    <html>
        <head>
            <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
            <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
            <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
             <link href="StyleProfil.css" rel="stylesheet" />
             <link href="css/styles.css" rel="stylesheet" /><!--css pour le style chocolat-->
        </head>
        <body>
            <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Profil Utilisateur</h4></div>
      
            <div class="container emp-profile">
            <form method="post">
                <div class="row">
                    <div style="padding-left:950px;">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Mes demandes</asp:LinkButton>
                     </div>
                    <br /><br />
                    <div class="col-md-4">
                        <div class="profile-img">
                            
                            <img src="Logo_Auto_Hall.jpg" alt=""/>
                           <!-- <div class="file btn btn-lg btn-primary">
                                Change Photo
                                <input type="file" name="file"/>
                            </div>-->
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="profile-head" width="800">
                                    <h5>
                                        <asp:Label ID="Label1" runat="server" Text="Nom Complet"></asp:Label>
                                    </h5>
                                    <h6>
                                        <asp:Label ID="Label2" runat="server" Text="Postion"></asp:Label>
                                    </h6>
                                    <p class="proile-rating"> 
                                        
                                    </p>
                            <ul class="nav nav-tabs" id="myTab" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Infos Personnelles</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Infos Profetionnelles</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="profil" data-toggle="tab" href="#contact" role="tab" aria-controls="profile" aria-selected="false">Contact</a>
                                    </li>
                                
                            </ul>
                        </div>
                    </div>
                   
                </div>
                <div class="row">
                  <div class="col-md-4">
                        <div class="profile-work">
                            <p></p>
                            <a href=""></a><br/>
                            <a href=""></a><br/>
                            <a href=""></a>
                            <p></p>
                            <a href=""></a><br/>
                            <a href=""></a><br/>
                            <a href=""></a><br/>
                            <a href=""></a><br/>
                            <a href=""></a><br/>
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="tab-content profile-tab" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                        <div class="row" style="padding-top:50px;">
                                            <div class="col-md-6">
                                                <label>Nom</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label3" runat="server" Text="votre Nom"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Prénom</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label4" runat="server" Text="Votre prénom"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Sex</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label5" runat="server" Text="votre sex"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Situation familiale</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label6" runat="server" Text="votre situation"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Adresse</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label7" runat="server" Text="votre adresse"></asp:Label>
                                            </div>
                                        </div>
                                <div class="row">
                                            <div class="col-md-6">
                                                <label>Quartier</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label12" runat="server" Text="votre Quartier"></asp:Label>
                                            </div>
                                        </div>
                                <div class="row">
                                            <div class="col-md-6">
                                                <label>Ville</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label13" runat="server" Text="votre ville"></asp:Label>
                                            </div>
                                        </div>
                            </div>
                            <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                                        <div class="row" style="padding-top:50px;">
                                            <div class="col-md-6">
                                                <label>Position</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label8" runat="server" Text="Votre position"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Departement</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label9" runat="server" Text="votre departement"></asp:Label>
                                            </div>
                                        </div>
                                   <!--     <div class="row">
                                            <div class="col-md-6">
                                                <label>Total Projects</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>230</p>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>English Level</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>Expert</p>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Availability</label>
                                            </div>
                                            <div class="col-md-6">
                                                <p>6 months</p>
                                            </div>
                                        </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <label>Your Bio</label><br/>
                                        <p>Your detail description</p>
                                    </div>
                                </div>-->
                            </div>
                             <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="profile-tab">
                                        <div class="row" style="padding-top:50px;">
                                            <div class="col-md-6">
                                                <label>Tel</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label10" runat="server" Text="Votre tel"></asp:Label>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <label>Email</label>
                                            </div>
                                            <div class="col-md-6">
                                                <asp:Label ID="Label11" runat="server" Text="Votre Email"></asp:Label>
                                            </div>
                                        </div>
                                 </div>
                        </div>
                    </div>
                </div>
            </form>           
                  <div class="col-md-12" style="padding-left:700px;">
                 <%--<input type="submit" class="profile-edit-btn" name="btnAddMore" value="Edit Profile "/>--%>
                        <asp:HyperLink ID="HyperLink1" runat="server" Class="btn btn-primary btn-xl" NavigateUrl="~/ChangerD.aspx">Modifier profil</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server" Class="btn btn-primary btn-xl" NavigateUrl="~/ChangerMDP.aspx">Modifier MDP</asp:HyperLink>
               </div>
        </div>
          
        </body>
    </html>
</asp:Content>
