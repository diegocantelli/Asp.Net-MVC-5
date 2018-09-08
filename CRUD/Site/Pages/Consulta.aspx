<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta de clientes</title>
    <link type="text/css" rel="stylesheet" href="../Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="Content/estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset-1">
            <div class="row jumbotron">
                <h3>Consulta de clientes</h3> 
            </div>
            <p>
                <asp:Label ID="lblMensagem" runat="server"/>
            </p>
            <a href="Principal.aspx" class="btn btn-primary btn-lg">Voltar</a> 
            
            <asp:GridView ID="GridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" 
                AutoGenerateColumns="false" BackColor="#ccff99" OnRowCommand="acaoCart">
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Código" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                    <asp:BoundField DataField="NomeEstado" HeaderText="Estado" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />                    
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="linkExcluir" CommandName="Excluir"
                                CommandArgument='<%#Eval("Codigo") %>' Text="Excluir" />
                            <asp:LinkButton runat="server" ID="LinkButton1" CommandName="Editar"
                                CommandArgument='<%#Eval("Codigo") %>' Text="Editar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <RowStyle CssClass="cursor-pointer" />  
            </asp:GridView>           
        </div>    
    </div>
    </form>
<script src="../Scripts/jquery-3.0.0.min.js"></script>
<script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
