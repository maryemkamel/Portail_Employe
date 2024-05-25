<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="listeToutesDemandesDoc.aspx.cs" Inherits="PortailEmploye.WebForm23" %>
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
        <style>
            .T
            {
                border:4px solid chocolate;
               /* height:200px;*/
                width:1050px;
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
                    <table class="T" id="table" runat="server">
                        <tr style="height:20px;width:650px;">
                            <td style="width:400px;"><strong> <asp:Label ID="Label4" runat="server" Text="N°" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                            <td style="width:400px;"><strong> <asp:Label ID="Label1" runat="server" Text="Employe" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                             <td style="width:400px;"><strong> <asp:Label ID="Label2" runat="server" Text="Document" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                             <td style="width:450px;"> <strong><asp:Label ID="Label3" runat="server" Text="Date" style="color:chocolate;font-size:30px;" class="section-heading mb-6"></asp:Label></strong></td>
                             <td style="width:400px;"><strong> <asp:Label ID="Label7" runat="server" Text="Comment" style="color:chocolate;font-size:30px;" class="mb-3"></asp:Label></strong></td>
                            <td style="width:400px;"><strong> <asp:Label ID="Label8" runat="server" Text="Statut" style="color:chocolate;font-size:30px;"></asp:Label></strong></td>
                        </tr>
                       <%-- <tr style="height:40px;width:6OOpx;">
                            <td style="width:400px;">
                                <asp:Label ID="Label4" runat="server" Text=""></asp:Label></td>
                             <td style="width:400px;">
                                 <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                             <td style="width:400px;">
                                 <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                             <td style="width:400px;">
                                 <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
                            <td style="width:400px;">
                                <asp:Button ID="Button1" runat="server" Text="Traité" OnClick="Button1_Click" class="btn btn-success" />
                             
                            </td>
                        </tr>--%>
                    </table>
                     </center>
                    <br />
                    <div class="col-md-12" style="padding-left:250px;">
                    <asp:Label ID="Label5" runat="server" Text="Veuillez saisir le N° de la demande traité :"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Traité" class="btn btn-primary btn-xl" OnClick="Button1_Click"/>
                        </div>
                   
                <br /><br />
                           
                     
                     
            </body>
        </html>
</asp:Content>
