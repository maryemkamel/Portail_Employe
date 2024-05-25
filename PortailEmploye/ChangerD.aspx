<%@ Page Title="" Language="C#" MasterPageFile="~/PageMaster.Master" AutoEventWireup="true" CodeBehind="ChangerD.aspx.cs" Inherits="PortailEmploye.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!doctype html>
    <html>
        <head>
              <link href="StyleChangerD.css" rel="stylesheet" />
             <link href="css/styles.css" rel="stylesheet" />
           
        </head>
        <body>
              <div style="background-color:antiquewhite; height:70px;padding-left:20px;padding-top:20px;"><h4>Changer vos informations</h4></div>
            <br />
                

             <form class="form-horizontal" role="form" name="bord">
             

                 <div class="btn-group mr-2" role="group" aria-label="First group" style="padding-left:60px;">
                      <!--  <button type="button" class="btn btn-secondary">Adresse</button>-->
                     <asp:Button ID="Button2" runat="server" Text="Adresse" class="btn btn-secondary" OnClick="Button2_Click" />

                     <asp:Button ID="Button3" runat="server" class="btn btn-secondary" Text="Date de Naissance" OnClick="Button3_Click" />
                     <asp:Button ID="Button4" runat="server" class="btn btn-secondary" Text="Situation familiale: Mariage" OnClick="Button4_Click" />
                     <asp:Button ID="Button5" runat="server" class="btn btn-secondary" Text="Situation familiale: Naissance" OnClick="Button5_Click" />
                     <asp:Button ID="Button6" runat="server" class="btn btn-secondary" Text="RIB" OnClick="Button6_Click" />
                      </div>

                 
            <div class='container' style="padding-top:50px;">
                <!----- Changement d'adresse------>
           <div class="row" id="madiv1">
               <!----Adresse actuelle---->
              <%--  <div class="col-lg-5">



                    <div class="form-heading">

                        <span class="prg">Adresee actuelle</span>
                    </div>

                    <div style="border:1px;">

                        <div class="form-group">
                            <label for="programme" class="col-sm-2 control-label">Adresee</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox1" runat="server" class="form-control" disabled Text="adresse"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-2 control-label">Quartier</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox2" runat="server" class="form-control"  disabled Text="Quartier"></asp:TextBox>                                
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine2" class="col-sm-2 control-label">Ville</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox3" runat="server" class="form-control"  disabled Text="Ville"></asp:TextBox>
                            </div>
                        </div>                    
                    </div>

                </div>--%>
                                                       <!-------------------------------------------------------->

               <!-- nouvelle adresee--->
                <div class="col-lg-5">

                    <div class="form-heading">

                        <span class="prg">Nouvelle adresse</span>
                    </div>

                   <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Nouvelle adresse</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox4" runat="server" class="form-control"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-2 control-label">Quartier</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox5" runat="server" class="form-control"></asp:TextBox>                                
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine2" class="col-sm-2 control-label">Ville</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox6" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine2" class="col-sm-2 control-label">Copie CIN
                            </label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload2" runat="server" />
                            </div>
                        </div>



                </div>
  <!---aaaaaaaaa---> <asp:Panel ID="Panel1" runat="server"  class="col-lg-5">
                        
                    <div class="form-heading">

                        <span class="prg">Nouvelle date de naissance</span>
                    </div>

                   <div class="form-group">
                            <label for="programme" class="col-sm-8 control-label">Nouvelle date de naissance</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox10" runat="server" class="form-control" type="date"></asp:TextBox>
                            </div>
                        </div>
                    <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Lieu de naissance</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox9" runat="server" class="form-control"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine2" class="col-sm-10 control-label">CIN ou Copie intégrale extrait de naissance</label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload7" runat="server" />
                            </div>
                        </div>

                       

                    </asp:Panel>
               </div>
               <!-- ------------------changement date de naissance------------------ -->
              <div class="row" id="madiv2">
                    <div class="col-lg-5">

                    <div class="form-heading">

                        <span class="prg">Nouvelle situation Familiale</span>
                    </div>

                   <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Nouvelle situation</label>
                       <div class="col-sm-8">
                           <asp:DropDownList ID="DropDownList1" runat="server">
                                   <asp:ListItem Text ="Choisir situation" Value = ""></asp:ListItem>
                                    <asp:ListItem Text ="Marié" Value ="1"></asp:ListItem>
                                    <asp:ListItem Text ="Divorcé" Value ="2"></asp:ListItem>
                           </asp:DropDownList>
                            </div>
                       <div class="form-group">
                           <label for="origine" class="col-sm-6 control-label">Date de mariage</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox16" runat="server" class="form-control" type="date" Text="Date de mariage"></asp:TextBox> 
                            </div>
                       </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-6 control-label">Nom et Prénom conjoint</label> 
                            <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox11" runat="server" class="form-control"></asp:TextBox>                        
                            </div>
                        </div>
                       
                        <div class="form-group">
                                <label for="origine" class="col-sm-6 control-label">Fonction conjoint</label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="TextBox12" runat="server" class="form-control"></asp:TextBox>                                
                                </div>
                        </div>
                    <div class="form-group">
                                <label for="origine" class="col-sm-10 control-label">Est-ce que le conjoint fait partie du groupe ?</label>
                                <div class="col-sm-8">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="2" >
                        <asp:ListItem>OUI</asp:ListItem>
                        <asp:ListItem>NON</asp:ListItem>
                        
                        </asp:RadioButtonList>
                                </div>
                        </div>
                       
                        <div class="form-group">
                            <label for="origine2" class="col-sm-8 control-label">Copie acte du mariage</label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload6" runat="server" />
                            </div>
                        </div>




                </div>

                      <div class="col-lg-5">

                    <div class="form-heading">

                        <span class="prg">Informations d'enfant</span>
                    </div>

                   <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Date de naissance</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox22" runat="server" class="form-control" type="date"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-8 control-label">Nom et Prénom Enfant</label><asp:TextBox ID="TextBox23" runat="server" class="form-control"></asp:TextBox>
                            <div class="col-sm-8">
                                                                
                            </div>
                        </div>
                        
                     <div class="form-group">
                                <label for="origine" class="col-sm-8 control-label">Sex</label>
                                <div class="col-sm-8">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" RepeatColumns="2" >
                        <asp:ListItem>masculin</asp:ListItem>
                        <asp:ListItem>feminin</asp:ListItem>
                        
                        </asp:RadioButtonList>
                                </div>
                        </div>
                     <div class="form-group">
                                <label for="origine" class="col-sm-8 control-label">A charge</label>
                                <div class="col-sm-8">
                        <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" RepeatColumns="2" >
                        <asp:ListItem>OUI</asp:ListItem>
                        <asp:ListItem>NON</asp:ListItem>
                        
                        </asp:RadioButtonList>
                                </div>
                        </div>

                        <div class="form-group">
                            <label for="origine2" class="col-sm-8 control-label">Extrait d’acte de naissance
                            </label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload4" runat="server" />
                            </div>
                        </div>



                </div>
                  <!-- date actuelle-->
               <%-- <div class="col-lg-5">



                    <div class="form-heading">

                        <span class="prg">Date de naissance actuelle</span>
                        
                        
                    </div>

                    <div style="border:1px;">

                        <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Date de naissance</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox7" runat="server" class="form-control" disabled Text="Date de naissance" type="date"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-6 control-label">Lieu de naissance</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox8" runat="server" class="form-control"  disabled Text="Lieu de naissance"></asp:TextBox>                                
                            </div>
                        </div>
                        
                       


                        <!--</form>-->
                    </div>

                </div>--%>
                                        <!-------------------------------------------------------->

                  <!-- nouvelle date--->
              <!--  <div class="col-lg-5">-->
                    
              <!--  </div>-->

               </div>
                   <!-- ------------------situation familiale-------------------- -->
                   <div class="row" id="madiv3">
                       <!--- situation actuelle ---->
                <%--<div class="col-lg-5">



                    <div class="form-heading">

                        <span class="prg">Situation Familiale actuelle</span>
                        
                    </div>

                    <div style="border:1px;">

                        <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Situation familiale actuelle</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox13" runat="server" class="form-control" disabled Text="situation actuelle"></asp:TextBox> 
                            </div>
                        </div>
                       


                        <!--</form>-->
                    </div>

                </div>--%>
                                        <!-------------------------------------------------------->

                       <!---nouvelle situation-->
              
               </div>
                <!----------------situation familiale : naissance --------------->
                <div class="row" id="madiv4">
                    <!---situation actuelle--->
              <%--  <div class="col-lg-5">



                    <div class="form-heading">

                        <span class="prg">Situation familiale actuelle : Naissance</span>
                        
                    </div>

                    <div style="border:1px;">

                        <div class="form-group">
                            <label for="programme" class="col-sm-8 control-label">Nombre d'enfants</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox19" runat="server" class="form-control" disabled Text="Nombre d'enfants"></asp:TextBox> 
                            </div>
                        </div>
                       
                       
                       


                        <!--</form>-->
                    </div>

                </div>--%>
                                          <!-------------------------------------------------------->

                    <!---nouvelle situation--->
            
               </div>
                <!------------------------changement RIB----------------->
                <div class="row" id="madiv5">
                    <!------RIB actuel------>
                <%--<div class="col-lg-5">



                    <div class="form-heading">

                        <span class="prg">RIB actuel</span>
                        
                    </div>

                    <div style="border:1px;">

                        <div class="form-group">
                            <label for="programme" class="col-sm-8 control-label">Banque actuelle</label>
                            <div class="col-sm-8">
                               <asp:TextBox ID="TextBox25" runat="server" class="form-control" disabled Text="Banque actuelle"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-2 control-label">RIB actuel</label>
                            <div class="col-sm-8">
                                <asp:TextBox ID="TextBox26" runat="server" class="form-control"  disabled Text="RIB actuel"></asp:TextBox>                                
                            </div>
                        </div>
                     

                        <!--</form>-->
                    </div>

                </div>--%>
                                                  <!-------------------------------------------------------->
                    <!-----nouveau RIB ---->

                <div class="col-lg-5">

                    <div class="form-heading">

                        <span class="prg">Nouveau RIB</span>
                        
                    </div>

                   <div class="form-group">
                            <label for="programme" class="col-sm-6 control-label">Nouvelle banque</label>
                            <div class="col-sm-8">
                               
                                <asp:TextBox ID="TextBox28" runat="server" class="form-control"></asp:TextBox> 
                               
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="origine" class="col-sm-2 control-label">Nouveau RIB</label>
                            <div class="col-sm-8">
                                  <asp:TextBox ID="TextBox29" runat="server" class="form-control"></asp:TextBox>                              
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <label for="origine2" class="col-sm-10 control-label">Demande manuscrite de changement
                            </label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload5" runat="server" />
                            </div>
                        </div>
                      <div class="form-group">
                            <label for="origine2" class="col-sm-10 control-label">Attestation de nouveau RIB
                            </label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </div>
                        </div>
                    <div class="form-group">
                            <label for="origine2" class="col-sm-10 control-label">Main levée
                            </label>
                            <div class="col-sm-8">
                                <asp:FileUpload ID="FileUpload3" runat="server" />
                            </div>
                        </div>

                </div>
               </div>
                <!------------------fin------------------------->
           </div>
               
                   <div style="float:right;padding-right:20px;" >
                     <asp:Button ID="Button7" runat="server" Text="Envoyer" class="btn btn-primary btn-xl" OnClick="Button7_Click"/>
                 </div>

             

           </form>

        </body>
    </html>
</asp:Content>
