<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="TraiterDemandeDocuments1.aspx.cs" Inherits="PortailEmploye.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!doctype html>
    <html>

    
    <head>
			<meta charset="utf-8" />
        <title>demande de changement des infos</title>
        <link href="TraiterDemandeChang1Style.css" rel="stylesheet" />
         <link rel="stylesheet" type="text/css" href="//netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css">
             <link href="css/styles.css" rel="stylesheet" />
			
        </head>
        <body>
            <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Demandes des documents</h4></div>
            <br />
              
            <div class="container bootstrap snippets bootdey">
            <div class="col-lg-12">
             <div class="main-box clearfix">
             <div class="tabs-wrapper tabs-no-header">
           <div><a href="#tab-products" data-toggle="tab">Cliquer pour voir demandes</a></div>
      
         <div class="tab-content tab-content-body clearfix">
            </div>
            <div class="tab-pane fade" id="tab-products">
               <ul class="widget-products">
                   <!---premiere demande--->
                  <li>
                 <asp:Panel ID="Panel1" runat="server">
                     <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">
                     <span class="img">
                         <asp:Image ID="Image1" runat="server" class="img-thumbnail"/>
                     </span>
                     <span class="product clearfix">
                     <span class="name">
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="price">
                     <i ></i><asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="warranty">
                     <i class="fa fa-certificate"></i><asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                     </span>
                     </span>
                    </asp:LinkButton>
                      </asp:Panel>       
                  </li>
                   <!--- 2eme demande--->
                  <li>
                      <asp:Panel ID="Panel2" runat="server">
                    <asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click">
                     <span class="img">
                      <asp:Image ID="Image2" runat="server" class="img-thumbnail"></asp:Image>
                     </span>
                     <span class="product clearfix">
                     <span class="name">
                    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="price">
                     <i></i><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="warranty">
                     <i class="fa fa-certificate"></i><asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                     </span>
                     </span>
                     </asp:LinkButton>
                          </asp:Panel>
                  </li>
                   <!----3eme demande--->
                  <li>
                      <asp:Panel ID="Panel3" runat="server">
                    <asp:LinkButton ID="LinkButton9" runat="server" OnClick="LinkButton9_Click">
                     <span class="img">
                       <asp:Image ID="Image3" runat="server" class="img-thumbnail"/>
                     </span>
                     <span class="product clearfix">
                     <span class="name">
                     <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="price">
                     <i></i><asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="warranty">
                     <i class="fa fa-certificate"></i><asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                     </span>
                     </span>
                     </asp:LinkButton>
                          </asp:Panel>
                  </li>
                   <!----4eme demande--->
                  <li>
                      <asp:Panel ID="Panel4" runat="server">
                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">
                     <span class="img">
                         <asp:Image ID="Image4" runat="server" class="img-thumbnail"/>
                     </span>
                     <span class="product clearfix">
                     <span class="name">
                     <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="price">
                     <i></i><asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                     </span>
                     <span class="warranty">
                     <i class="fa fa-certificate"></i><asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                     </span>
                     </span>
                     </asp:LinkButton>
                     </asp:Panel>
                  </li>
               </ul>
               <br>
                <div style="float:right;padding-right:20px;padding-bottom:20px;">
                <asp:LinkButton ID="LinkButton11" runat="server" class="btn btn-primary btn-xl" OnClick="LinkButton11_Click">Voir toutes les demandes</asp:LinkButton>
               </div>
            </div>
        
         </div>
      
   </div>
</div>
</div>

        </body>
        </html>
</asp:Content>
