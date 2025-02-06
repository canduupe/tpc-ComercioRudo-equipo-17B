<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="ComercioRudo.ListaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListaCli" runat="server" CssClass="table"></asp:GridView>
    <asp:Button ID="btnAgregarCli" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarCli_Click"    />

</asp:Content>
