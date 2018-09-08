<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Site.Pages.Detalhe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Projeto CRUD - Controle de clientes</h1>
        Selecione a operação desejada:
        <asp:DropDownList ID="ddlMenu" runat="server">
            <asp:ListItem Value="0" Text="- Escolha uma opção -" />
            <asp:ListItem Value="1" Text="Cadastrar cliente" />
            <asp:ListItem Value="2" Text="Consultar cliente" />
            <asp:ListItem Value="3" Text="Obter os dados do cliente" />
            <asp:ListItem Value="4" Text="Cadastrar Fornecedor" />
            <asp:ListItem Value="5" Text="Consulta de Fornecedores" />
        </asp:DropDownList>
        <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar" />
        <p>
            <asp:Label ID="LblMensagem" runat="server" />
        </p>
    </div>
    </form>
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
