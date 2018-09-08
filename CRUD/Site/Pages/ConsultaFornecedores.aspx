<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaFornecedores.aspx.cs" Inherits="Site.Pages.ConsultaFornecedores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de fornecedores</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="Content/estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1 class="align-content-center jumbotron">Consulta de fornecedores</h1>
        <asp:Label ID="lblMensagem" runat="server" />
        <asp:GridView ID="GridFornecedores" runat="server" CssClass="table table-hover table-striped" GridLines="None" 
                AutoGenerateColumns="false" BackColor="#ccff99" OnRowCommand="EdicaoCliente">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Código" />
                <asp:BoundField DataField="Fantasia" HeaderText="Fantasia" />
                <asp:BoundField DataField="Email" HeaderText ="Email" />
                <asp:BoundField DataField="Cnpj" HeaderText ="Cnpj" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkExcluir" runat="server" CommandName="Excluir" 
                            CommandArgument='<%#Eval("Id") %>' Text="Excluir" />
                        <asp:LinkButton ID="LinkEditar" runat="server" CommandName="Editar"
                            CommandArgument='<%#Eval("Id")%>' Text="Editar"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle CssClass="cursor-pointer" />
        </asp:GridView>
        <a href="Principal.aspx" runat="server" class="btn btn-primary btn-lg">Voltar</a>
    </div>
    </form>
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
