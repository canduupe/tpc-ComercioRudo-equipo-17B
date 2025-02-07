<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarVendedores.aspx.cs" Inherits="ComercioRudo.ListarVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListarVend" runat="server" CssClass="table"></asp:GridView>
    <asp:Button ID="btnAgregarVend" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarVend_Click"/>

</asp:Content>
