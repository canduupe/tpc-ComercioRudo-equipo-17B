<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="ComercioRudo.AgregarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <label>Nombre </label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <label>Apellido </label>
        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <label>Documento</label>
        <asp:TextBox ID="txtDni" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="Boton">
        <asp:Button Text="ACEPTAR" runat="server" ID="btnAceptar" CssClass="btn btn-outline-secondary" OnClick="btnAceptar_Click" />
        <asp:Button Text="CANCELAR" runat="server" ID="btnCancelar" CssClass="btn btn-outline-warning" OnClick="btnCancelar_Click" />
    </div>

</asp:Content>
