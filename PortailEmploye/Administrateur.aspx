<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Administrateur.aspx.cs" Inherits="PortailEmploye.WebForm8" %>
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

        </head>
        <body>
             <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Ajout d'un compte utilisateur</h4></div>
            <br />
            <div class="container">
                <div style="padding-left:3px;">
                    <h5>Veuillez saisir les champs suivants :</h5>

                </div> 
  
                     <form class="was-validated">
                          <div class="form-group">
                             <label for="uname">Login:</label>
                              <asp:TextBox ID="TextBox1" runat="server"  class="form-control"  width="450" placeholder="Entre Login" name="uname" required></asp:TextBox>
                  
                             <div class="valid-feedback">Valid.</div>
                             <div class="invalid-feedback">S'il vous plaît remplir Login.</div>
                          </div>
                          <div class="form-group">
                             <label for="pwd">Mot de passe:
                              </label>
                              <asp:TextBox ID="TextBox2" runat="server"  width="450" class="form-control"  placeholder="Entrer le mot de passe" name="pswd" required></asp:TextBox>
                            
                             <div class="valid-feedback">Valid.</div>
                             <div class="invalid-feedback">S'il vous plaît remplir le mot de passe.</div>
                          </div>
                         <div class="form-group">
                             <label for="pwd">Profil:
                              </label>
                             <br />
                             <asp:DropDownList ID="DropDownList1" runat="server" width="300">
                                 <asp:ListItem Value="" Text="Choisir le profil"/>
                                    <asp:ListItem Value="collaborateur" Text="collaborateur"/> 
	                                <asp:ListItem Value="responsable" Text="responsable"/> 
	                                <asp:ListItem Value="administrateur" Text="administrateur"/> 
                             </asp:DropDownList>
                              <%--<asp:TextBox ID="TextBox3" runat="server"  width="450" class="form-control"  placeholder="Entrer le profil de cet utilisateur"  required></asp:TextBox>--%>
                            
                             <div class="valid-feedback">Valid.</div>
                             <div class="invalid-feedback">S'il vous plaît remplir le profil.</div>
                          </div>
                        <!--  <div class="form-group form-check">
                             <label class="form-check-label">
                             <input class="form-check-input" type="checkbox" 
                             name="remember" required> Je suis d'accord.
                             <div class="valid-feedback">Valid.</div>
                             <div class="invalid-feedback">Cochez cette case pour continuer.</div>
                             </label>
                          </div>-->
                         <asp:Button ID="Button2" runat="server" Text="Enregistrer" type="submit" class="btn btn-primary btn-xl" OnClick="Button2_Click" />
             
                       </form>
           </div> 
        </body>
    </html>
</asp:Content>
