<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaGames.Site.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
       <div class="container">
           <asp:Label ID="lblUserNaoEncontrado" runat="server"></asp:Label>
           <div>Usuário:</div>
           <div>
               <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
           </div>       
           <div>Senha:</div>
           <div>
               <asp:TextBox ID="txtSenha" runat="server" TextMode="Password">
               </asp:TextBox>
           </div>
           <div>
               <asp:Button ID="BtnLogar" runat="server" text="Logar" OnClick="BtnLogar_Click" />
           </div>    
       </div>   
    </form>

    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</body>
</html>
