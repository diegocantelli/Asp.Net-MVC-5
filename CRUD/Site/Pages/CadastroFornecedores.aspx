<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFornecedores.aspx.cs" Inherits="Site.Pages.CadastroFornecedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de fornecedores</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link href="Content/estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1 class="jumbotron">Cadastro de fornecedores</h1>
        <div id="#form-dados-pessoais">
            <fieldset>
                <legend>Dados pessoais</legend>
                <label>ID:
                    <asp:TextBox ID="txtId" Width="50px" runat="server" CssClass="form-control" disabled="true" />
                </label><br />
                <label>Fantasia:
                    <asp:TextBox ID="txtFantasia" Width="200px" runat="server" CssClass="form-control" placeholder="Nome da empresa" />
                </label><br />
                <label>Email:
                    <asp:TextBox ID="txtEmail" Width="200px" runat="server" CssClass="form-control" placeholder="email da empresa" />
                </label><br />
                <label>Cnpj:
                    <asp:TextBox ID="txtCnpj" Width="150px" runat="server" CssClass="form-control" placeholder="Cnpj da empresa" />
                </label>
            </fieldset>
            <asp:Label ID="lblMensagem" runat="server" /> <br />
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" CssClass="btn btn-primary btn-lg" OnClick="btnGravarFornecedor" />         
            <a href="Principal.aspx" class="btn btn-primary btn-lg">Voltar</a>
        </div>
    </div>
    </form>
</body>
</html>
