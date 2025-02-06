<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCategorias.aspx.cs" Inherits="ComercioRudo.ListaCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <asp:GridView ID="gdvListaCate" runat="server" CssClass="table"></asp:GridView>
        <asp:Button ID="btnAgregarCat" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarCat_Click"    />

</asp:Content>
