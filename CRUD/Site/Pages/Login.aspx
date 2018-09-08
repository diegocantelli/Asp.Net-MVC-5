<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Site.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="Content/estilos.css" />
</head>
<body>
    <div class="container align-content-center">
        <div class="login">
            <form id="formLogin" runat="server">
                <h1>Login</h1>
                <asp:TextBox ID="txtLogin" CssClass="espacamento form-control" runat="server" placeholder="Informe seu login" />
                <asp:TextBox type="password" ID="txtSenha" CssClass=" espacamento form-control" runat="server" placeholder="Informe sua senha" />
                <asp:Label ID="lblMensagem" CssClass="espacamento" runat="server" />
                <asp:Button ID ="btnLogin" CssClass="botao btn btn-primary btn-lg" runat="server" Text="Logar" OnClick="btnLogar" />
             </form>
        </div>        
    </div>
    
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
