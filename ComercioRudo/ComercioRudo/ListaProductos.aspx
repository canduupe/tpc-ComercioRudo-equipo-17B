<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="ComercioRudo.ListaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView ID="dgvListaProduc" runat="server" CssClass="table"></asp:GridView>
<asp:Button ID="btnAgregarProd" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary"/>


</asp:Content>
