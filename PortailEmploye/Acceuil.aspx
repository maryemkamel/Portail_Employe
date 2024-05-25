<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="Acceuil.aspx.cs" Inherits="PortailEmploye.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
 
    <!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <title>Page d'acceuil</title>
        <link href="StyleAcceuil.css" rel="stylesheet" />
		<style>
			.T1 {
    background-image: url(news3.jpg);
    background-size: 350px 200px;
}
			.T3 {
    background-image: url(modification1.jpg);
    background-size: 300px 200px;
	
}
			table{
				height:550px;
			}
			table tr td{
				height:10px;
			}
			
			table tr{
				height:50px;
			}
		</style>
		<link href="css/styles.css" rel="stylesheet" />
    </head>
    <body>
		<div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Page d'accueil</h4></div>
                      <br />
        <table align="center" cellspacing="4" cellpadding="0" style="padding-top:100px;background-color: floralwhite;">
		<tr>
			<td  class="zoom" style="border:5px solid gray; border-style: outset;padding-left:20px;height:150px;padding-right:20px;">
				<div>
				<table style="width:350px;height: 200px;border-collapse: collapse;" cellspacing="0" class="T1" cellpadding="0">
					<tr style="width: 350px;height: 150px;"><td style="height: 150px;"></td></tr>
					<tr style="width: 350px;height: 50px;"><td style="height: 50px;padding-left: 20px;"><strong>
						<asp:LinkButton ID="LinkButton1" runat="server" class="L" style="color: white;" OnClick="LinkButton1_Click">voir détails</asp:LinkButton>
						<%--<a href="http://www.google.com" style="color: white;" >voir détails </a>--%></strong></td></tr>
				</table>
				</div>
			</td>
			<td style="width: 200px;"></td>
			<td  class="zoom" style="border:5px solid gray; border-style: outset;padding-left:20px;height:150px;padding-right:20px;">
				<div>
				<table style="width:350px;height: 200px;border-collapse: collapse;" cellspacing="0" class="T2" cellpadding="0">
					<tr style="width: 350px;height: 150px;"><td style="height: 150px;"></td></tr>
					<tr style="width: 350px;height: 50px;"><td style="height: 50px;padding-left: 20px;"><strong>
						<asp:LinkButton ID="LinkButton2" runat="server" style="color: black;" OnClick="LinkButton2_Click">voir détails</asp:LinkButton>
						<%--<a href="http://www.google.com" >voir détails </a>--%></strong></td></tr>
				</table>
				</div>
			</td>
		</tr>

			<%--<tr style="height:10px;">
				<td></td>
				<%--<td></td>
				<td></td>--%>
			<%--</tr>--%>
		<tr>
			<td></td>
			<td style="width: 20px;">
			<div onclick="location.href='http://www.google.com'" style="cursor:pointer;">
				<table style="width:20px;height: 2px;border-collapse: collapse;" cellspacing="0"cellpadding="0">
					<tr style="width: 20px;height: 2px;"><td style="height: 2px;"></td></tr>	
				</table>
			</div>
			</td>
			<td></td>
		</tr>
		<tr>
			<td  class="zoom" style="border:5px solid gray; border-style: outset;padding-left:20px;height:150px;padding-right:20px;">
				<div>
				<table style="width:350px;height: 200px;border-collapse: collapse;" cellspacing="0" class="T3" cellpadding="0">
					<tr style="width: 350px;height: 150px;"><td style="height: 150px;"></td></tr>
					<tr style="width: 350px;height: 50px;"><td style="height: 50px;padding-left: 20px;"><strong>
						<asp:LinkButton ID="LinkButton3" runat="server" style="color: white;" OnClick="LinkButton3_Click">voir détails</asp:LinkButton>
				<%--		<a href="http://www.google.com" > </a>--%></strong></td></tr>
				</table>
				</div>
			</td>
			<td style="width: 200px;"></td>
			<td  class="zoom" style="border:5px solid gray; border-style: outset;padding-left:20px;height:150px;padding-right:20px;">
				<div>
				<table style="width:350px;height: 200px;border-collapse: collapse;" cellspacing="0" class="T4" cellpadding="0">
					<tr style="width: 350px;height: 150px;"><td style="height: 150px;"></td></tr>
					<tr style="width: 350px;height: 50px;"><td style="height: 50px;padding-left: 20px;"><strong>
						<asp:LinkButton ID="LinkButton4" runat="server" style="color: white;" OnClick="LinkButton4_Click">voir détails</asp:LinkButton>
					<%--	<a href="http://www.google.com" > </a>--%>

					  </strong></td></tr>
				</table>
				</div>
			</td>
		</tr>
	</table>
		<div style="display:none;">
			<asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-primary btn-xl"/>
		</div>
	

    </body>

</html>

</asp:Content>

