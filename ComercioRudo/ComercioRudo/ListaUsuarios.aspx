<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="ComercioRudo.ListaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListaUsu" runat="server" CssClass="table"></asp:GridView>
    <asp:Button ID="btnAgregarUsu" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" />

    
</asp:Content>
