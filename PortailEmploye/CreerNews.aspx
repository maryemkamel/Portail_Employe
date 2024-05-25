<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="CreerNews.aspx.cs" Inherits="PortailEmploye.WebForm5" %>
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
            <div class="container-fluid" style="padding-top:20px;">
               
                <div class="row">
                    <div class="col-md-6" style="padding-top:50px;">
                        <div class="card" style="padding-top:10px;">
                            <form class="form-horizontal was-validated">
                                <div class="card-body" style="padding-top:10px;padding-bottom:0px;">
                                    <h4 class="card-title">Créer votre actualité</h4>
                                    <div class="form-group row" style="padding-top:50px;">
                                         <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Titre</label></div>
                                       <!-- <label for="fname"
                                            class="col col-md-12 text-end control-label col-form-label">Titre</label>-->
                                        <div class="col-sm-12">
                          <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" class="form-control required form-control"  placeholder="Entrer le titre de l'actualité" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir le titre.</div>

                                        </div>
                                    </div>

                             
                                    <div class="form-group row">
                                        <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Description</label></div>
                                      
                                        &nbsp;<div class="col-sm-9">

                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" class="form-control required form-control" Width="400px" Height="200px" required></asp:TextBox>

                                            <div class="valid-feedback">Valid.</div>
                                            <div class="invalid-feedback">S'il vous plaît remplir la description.</div>
                                        </div>
                                    </div>


                          

                                    
                    <div class="row form-group">
                              <div class="col col-md-12"><label for="file-input" class=" form-control-label ">Fiche jointe</label></div>
                             <div class="col-12 col-md-9">
                               <asp:FileUpload ID="FileUpload2" runat="server" class="form-control-file" />
                             </div>
                             </div>
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>




                                </div>
                                <div class="border-top">
                                    <div  class="form-group d-flex align-items-center justify-content-between mt-4 mb-0 col-md-12">
                                        <asp:Button ID="Button3" runat="server" Text="Réinitialiser" class="btn btn-primary btn-xl" type="reset" OnClientClick="this.form.reset()" OnClick="Button3_Click"/>
                                        <asp:Button ID="Button2" runat="server" Text="Publier" class="btn btn-primary btn-xl"  type="submit" OnClick="Button2_Click"/>

                                    </div>
                                </div>
                            </form>
                        </div>
                        </div>
                    </div>
        </body>
    </html>
</asp:Content>
