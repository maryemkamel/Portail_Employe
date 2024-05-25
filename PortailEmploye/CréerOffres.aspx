<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="CréerOffres.aspx.cs" Inherits="PortailEmploye.WebForm18" %>
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
            <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Créer nouvelle offre
                </h4></div>
            
            <br /><%--<div style="padding-left:900px;">
                                            <asp:HyperLink ID="HyperLink1" runat="server" >Liste postulants</asp:HyperLink>
                                        </div>--%>
            <div class="container-fluid">
          <div style="float:right;padding-right:80px;">
          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Candidatures</asp:LinkButton>
              </div> 
                <div class="row" style="padding-top:10px;">
                    
                    <div class="col-md-6" style="padding-top:30px;">
                        <div class="card" style="padding-left:10px;">
                            <form class="form-horizontal was-validated">
                                  
                                <div class="card-body">
                                    <h4 class="card-title">Créer votre offre</h4></div>
                                    <div class="form-group row" style="padding-top:50px;">
                                      
                                         <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Titre</label></div>
                                       <!-- <label for="fname"
                                            class="col col-md-12 text-end control-label col-form-label">Titre</label>-->
                                        <div class="col-sm-12">
                          <asp:TextBox ID="TextBox1" runat="server" class="form-control required form-control"  placeholder="Entrer le titre de l'offre" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir le titre.</div>

                                        </div>
                                    </div>

                             
                                    <div class="form-group row">
                                        <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Détails</label></div>
                                        &nbsp;<div class="col-sm-9">
                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" class="form-control required form-control" Width="400px" Height="100px" required></asp:TextBox>
                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir la description.</div>
                                            </div>
                                    </div>
         
                             <div class="row form-group">
                              <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Conditions</label></div>
                                 &nbsp;<div class="col-sm-9">
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" class="form-control required form-control" Width="400px" Height="100px" required></asp:TextBox>
                              </div>
                             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="border-top">
                                    <div  class="form-group d-flex align-items-center justify-content-between mt-4 mb-0 col-md-12">
                                        <asp:Button ID="Button3" runat="server" Text="Réinitialiser" class="btn btn-primary btn-xl" type="reset" OnClientClick="this.form.reset()"/>
                                        <asp:Button ID="Button2" runat="server" Text="Publier" class="btn btn-primary btn-xl"  type="submit" OnClick="Button2_Click"/>

                                    </div>
                                </div>
                            </form>
                        </div>
                        </div>
                    </div>
                </div>
        </body>
    </html>
</asp:Content>
