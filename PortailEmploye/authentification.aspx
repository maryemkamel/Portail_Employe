<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="authentification.aspx.cs" Inherits="PortailEmploye.WebForm2" %>



<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" http-equiv="Content-Type" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Page Title - SB Admin</title>
        <link href="dist/css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.11.2/js/all.min.js" crossorigin="anonymous"></script>
        <style>
            .b {
    margin: 0;
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
    font-size: 1rem;
    font-weight: 400;
    line-height: 1.5;
    color: #212529;
    text-align: left;
   /*background-image: url(5e6bb4a664fba.jpg);*/ 
    background-size: auto;
    background-repeat: no-repeat;
    background-image:url(dfsk.jpg);
    /* Safari */
      -webkit-filter: blur(5px);
    /* Firefox */
      -moz-filter: blur(5px);
     Opera 
     -o-filter: blur(5px);
     /*Internet Explorer*/ 
     -ms-filter: blur(5px);
    /* Filtre de floutage CSS3 standard */
    filter: blur(5px);
}
        </style>
        <link href="css/styles.css" rel="stylesheet" />
    </head>
    <body class="bg-info" style=" background-image:url(DFSKé2.jpg);">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content" style="padding-top:110px;">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-5" >
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Login</h3></div>
                                    <div class="card-body">
                                        <form id="form2" runat="server">
                                            <div class="form-group"><label class="small mb-1" for="inputEmailAddress">Login</label><asp:TextBox runat="server" class="form-control py-4" id="inputEmailAddress" placeholder="Enter login"></asp:TextBox></div>   

                                            <div class="form-group"><label class="small mb-1" for="inputPassword">Password</label><asp:TextBox runat="server" class="form-control py-4" id="inputPassword" type="password" placeholder="Enter password"></asp:TextBox></div>
                                            <div class="form-group">
                                              <!--  <div class="custom-control custom-checkbox"><input class="custom-control-input" id="rememberPasswordCheck" type="checkbox" /><label class="custom-control-label" for="rememberPasswordCheck">Remember password</label></div>-->
                                            </div>
                                            <div class="col-lg-12">
                                                <asp:Label ID="Label1" runat="server" Text=" " ForeColor="Red"></asp:Label>
                                          
                                            </div>
                                             <center>
                                            <div class="form-group d-flex align-items-center justify-content-between mt-4 mb-0" style="float:right;padding-right:138px;">
                                              <!--   <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" class="small">Forgot Password?</asp:LinkButton>-->

                                               
                                                <asp:Button ID="Button1" runat="server" Text="Se connecter" class="btn btn-primary btn-xl" OnClick="Button1_Click"  />
                                               
                                            </div>
                                                  </center>
                                            
                                            
                                        </form>
                                    </div>
                                    <div class="card-footer text-center">
                                      <!--  <div class="small"><a href="register.html">Need an account? Sign up!</a></div>-->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
            <div id="layoutAuthentication_footer">
                <footer class="py-3 bg-light mt-auto" >
                    <div class="container-fluid" >
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy;  Group Auto Hall 2021</div>
               
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src="https://code.jquery.com/jquery-3.4.1.min.js" crossorigin="anonymous"></script>
        <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="js/scripts.js"></script>
    </body>
</html>