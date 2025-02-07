<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMadmin.aspx.cs" Inherits="ComercioRudo.ABMadmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <label>Usuario </label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtUsuario" />
    </div>
    <div>
        <label class="Boton">Contraseña </label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtContraseña" />
    </div>
    <div>
        <label>Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control "></asp:TextBox>
    </div>
    <div>
        <label>Apellido </label>
        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="Boton">
        <asp:Button ID="btnAgregar" runat="server" Text="ACEPTAR" OnClick="btnAgregar_Click" CssClass="btn btn-outline-primary" />
        <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" CssClass="btn btn-outline-warning" />
    </div>



</asp:Content>
