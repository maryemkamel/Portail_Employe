<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="OffresRH.aspx.cs" Inherits="PortailEmploye.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!doctype html>
    <html>
        <head>
			<meta charset="utf-8">
	<title></title>
	<link href="StyleNEWS1.css" rel="stylesheet" />
	<style>
				.T1 {
			background-image: url(consulterOffre.jpeg);
			background-size: 300px 203px;
				}
				.T2 {
			background-image: url(créerOffre.jpeg);
			background-size: 300px 203px;
				}
	</style>
			<link href="css/styles.css" rel="stylesheet" />

        </head>
        <body>
            <br></br><br></br>
	<table align="center">
		<tr>
			<td class="zoom"><div style="width: 300px; height: 200px;" class="T1"></div></td>
			<td style="width:80px;" class="A1"></td>
			<td class="zoom"><div style="width: 300px; height: 200px;" class="T2"></div></td>
		</tr>
		<tr style="height: 50px;">
			<td style="height: 50px;border: none;" align="center">

				<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Consulter offres" Width="300px" class="btn btn-primary btn-xl" />
			
			</td>
			<td style="width:80px;border-color: white;"></td>
			<td style="height: 50px;border: none;" align="center">
			    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Gérer offres" width="300px" class="btn btn-primary btn-xl" />
			</td>
		</tr>
	</table>
        </body>
    </html>
</asp:Content>
