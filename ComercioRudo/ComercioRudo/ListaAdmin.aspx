<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaAdmin.aspx.cs" Inherits="ComercioRudo.ListaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListaAdmin" runat="server" CssClass="table"></asp:GridView>
    <asp:Button ID="btnAgregarAd" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarAd_Click"  />

</asp:Content>
