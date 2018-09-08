<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BibliotecaGames.Site.Jogos.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Content/catalogo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="RepeaterJogos" runat="server">
        <ItemTemplate>
            <div class="jogo">
                <div class="capa-jogo">
                    <img src="../Content/ImgsJogos/fifa18.jpg" />" alt="Alternate Text" />
                </div>
                <div class="nome-jogo">
                    <%# DataBinder.Eval(Container.DataItem,"Titulo")%>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
