<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de clientes</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="Content/estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="offset-1 ">
            <div class="row jumbotron">
                <h3>Cadastro de clientes</h3><br /><br />                   
            </div>
            <label>Nome do cliente: 
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Informe o nome do cliente" CssClass="form-control"></asp:TextBox>                   
            </label>
                <br />

                <label>Endereço do cliente:
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Informe o endereço do cliente" CssClass="form-control"></asp:TextBox>                    
                </label>
                <br />

                <label>Email do cliente:
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Informe o email do cliente" CssClass="form-control"></asp:TextBox>
                </label>
                <br />
                
                <asp:DropDownList ID="ddlEstado" AutoPostBack="true" DataTextField="Sigla" DataValueField="id_estado" CssClass="form-control"
                    runat="server" width="200px"/>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                
                <asp:Button ID="btnCadastro" required="true" runat="server" text="Cadastrar" CssClass="btn btn-success btn-lg"
                    OnClick="btnCadastrarCliente" />
                <a href="Principal.aspx" class="btn btn-primary btn-lg">Voltar </a>
        </div>
    </div>
      
    </form>
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
