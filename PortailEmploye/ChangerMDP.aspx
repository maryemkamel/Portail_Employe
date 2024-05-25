<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="ChangerMDP.aspx.cs" Inherits="PortailEmploye.WebForm26" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!doctype html>
    <html>
        <head>
            <meta charset="utf-8" />
            <link href="css/styles.css" rel="stylesheet" />
        </head>
        <body>   
        <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Changer mot de passe</h4></div><br />
            <div class="container-fluid">
              
                <div class="row" style="padding-top:20px;">
                    <div class="col-md-6" style="padding-top:20px;">
                        <div class="card" style="padding-top:10px;">
                            <form class="form-horizontal was-validated">
                                <div class="card-body" style="padding-top:0px;">
                                    <h4 class="card-title">Changer mot de passe</h4>
                                    <div class="form-group row" style="padding-top:60px;">
                                         <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Votre mot de passe</label></div>
                                        <div class="col-sm-12">
                          <asp:TextBox ID="TextBox1" runat="server"  class="form-control required form-control"  placeholder="Entrer mot de passe" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir le titre.</div>

                                        </div>
                                    </div>


                                     <div class="form-group row">
                                         <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Nouveau mot de passe</label></div>
                                        <div class="col-sm-12">
                          <asp:TextBox ID="TextBox2" runat="server"  class="form-control required form-control"  placeholder="Entrer mot de passe" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir le titre.</div>

                                        </div>
                                    </div>

                                                    <div class="form-group row">
                                         <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Retaper le mot de passe</label></div>
                                        <div class="col-sm-12">
                          <asp:TextBox ID="TextBox3" runat="server"  class="form-control required form-control"  placeholder="Entrer mot de passe" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir le titre.</div>

                                        </div>
                                    </div>
                                    <div class="col-lg-12">
                                                <asp:Label ID="Label1" runat="server" Text=" " ForeColor="Red"></asp:Label>
                                          
                                   </div>

                                </div>
                                <div class="border-top">
                                    <div  class="form-group d-flex align-items-center justify-content-between mt-4 mb-0 col-md-12">
                                        <asp:Button ID="Button3" runat="server" Text="Réinitialiser" class="btn btn-primary btn-xl" type="reset" OnClientClick="this.form.reset()"/>
                                        <asp:Button ID="Button2" runat="server" Text="Modifier" class="btn btn-primary btn-xl"  type="submit" OnClick="Button2_Click" />

                                    </div>
                                </div>
                            </form>
                        </div>
                        </div>
                    </div>
               
        </body>
    </html>
</asp:Content>
