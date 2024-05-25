<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="ListeDemandesParEmploye-Dperso.aspx.cs" Inherits="PortailEmploye.WebForm25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!doctype html>
    <html>
    <head>
        <meta charset="utf-8" />
        <title>Liste des demandes de l'employe</title>
        <link href="TraiterDemandeChang1Style.css" rel="stylesheet" />
         <link rel="stylesheet" type="text/css" href="//netdna.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css">
             <link href="css/styles.css" rel="stylesheet" />
        <style>
            .T
            {
                border:4px solid chocolate;
              /*  height:200px;*/
                width:1000px;
                padding-bottom:20px;

            }
            table tr td{
                border:4px solid chocolate;
                text-align:center;
            }
        </style>
    </head>
        <body>
                  <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Détail de la demande de document</h4></div>

            <br />
             
            <div class="container">
                <%--<div class="intro">--%>
                <center>
                    <table class="T" id="table1" runat="server">
                        <tr style="height:20px;width:600px;">
                            <td style="width:400px;"><strong> <asp:Label ID="Label4" runat="server" Text="Demande" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                            <td style="width:400px;"><strong> <asp:Label ID="Label1" runat="server" Text="Date" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                             <td style="width:400px;"><strong> <asp:Label ID="Label2" runat="server" Text="Statut" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                        </tr>
                    </table>
                     </center>
                           
                     <br />
                     
            </body>
        </html>
</asp:Content>
