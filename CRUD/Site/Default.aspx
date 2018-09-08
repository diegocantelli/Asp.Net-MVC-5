<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    
</head>
<body>
    <form id="form2" runat="server">
        <div class="container">
            <div class="jumbotron">
                <div class="row">
                    <h3 class="well">Detalhes do cliente</h3>
                </div>
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="15%" /><br />
                <asp:Button ID="btnPesquisar" runat="server" CssClass="btn btn-info btn-lg" Text="Pesquisar" OnClick="btnPesquisarCliente"/>
                <asp:Button ID="btnExcluir" runat="server" CssClass="btn btn-info btn-lg" Text="Excluir" OnClick="btnExcuirCliente"/>
                <asp:Button ID="btnAtualizar" runat="server" CssClass="btn btn-info btn-lg" Text="Atualizar" OnClick="btnAtualizarCliente"/>

                <asp:Panel ID="pnlDados" runat="server">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="45%" placeholder="Nome do cliente" /><br />
                    <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" Width="45%" placeholder="Endereço do cliente" /><br />
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="45%" placeholder="Email do cliente" /><br />
                    <asp:Label ID="lblMensagem" runat="server"/>
                </asp:Panel>
                <a href="/Pages/Principal.aspx" class="btn btn-default  btn-lg">Voltar</a>
            </div>
        </div>
    </form>
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>