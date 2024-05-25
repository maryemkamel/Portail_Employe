<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="DemandeDocument.aspx.cs" Inherits="PortailEmploye.WebForm14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!doctype html>
    <html>
    <head>
        <link href="css/styles.css" rel="stylesheet" />
    </head>
    <body>
         <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Demande documents</h4></div>
      <br />  <div style="float:right;padding-right:80px;">
          <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Vos demandes</asp:LinkButton>
              </div>
        <center>
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header">
                    <strong>Choisir votre document</strong> 
                </div>
                <div class="card-body card-block">
                    <form action="" method="post" enctype="multipart/form-data" class="form-horizontal">
                        
                        
                         <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="select" class=" form-control-label">Document</label></div>
                            <div class="col-12 col-md-9">
                                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control">
                                
                                    <asp:ListItem Value="">Please Select</asp:ListItem>  
                                    <asp:ListItem>Attestation de travail</asp:ListItem>  
                                    <asp:ListItem>Attestation de salaire</asp:ListItem>  
                                    <asp:ListItem>Document3</asp:ListItem>  
                                    <asp:ListItem>Document4</asp:ListItem>  
                                    <asp:ListItem>Document5</asp:ListItem>  
                                  </asp:DropDownList>
                            </div>
                        </div>
                      
                        
                        <div class="row form-group">
                            <div class="col col-md-3">
                                <label for="textarea-input" class=" form-control-label">Commentaire</label></div>
                            <div class="col-12 col-md-9">
                                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" class="form-control" placeholder="Commentaire..."></asp:TextBox>
                             <!--   <textarea name="textarea-input" id="textarea-input" rows="9" placeholder="Content..." class="form-control"></textarea></div>-->
                           </div>
                  
                    </form>
                </div>
                <center>
                <div class="card-footer">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="reset" type="reset" OnClientClick="this.form.reset()" class="btn btn-primary btn-xl"/>
                    
                     <!--   <i class="fa fa-dot-circle-o"></i>Submit-->
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" type="submit" OnClick="Button2_Click" Text="Envoyer" class="btn btn-primary btn-xl"/>
                       <!-- <i class="fa fa-ban"></i>Reset-->
                </div>
                    </center>
            </div>
            </div>
            </center>
     
    </body>
    </html>
</asp:Content>
