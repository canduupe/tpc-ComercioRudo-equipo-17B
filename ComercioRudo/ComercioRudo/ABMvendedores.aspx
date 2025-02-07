<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMvendedores.aspx.cs" Inherits="ComercioRudo.ABMvendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <label>Usuario</label>
        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <label>Contraseña</label>
        <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>   
        <label> Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>
        <label> Apellido</label>
        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="Boton">
        <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR"  OnClick="btnAceptar_Click" CssClass="btn btn-outline-secondary"/>
        <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" CssClass="btn btn-outline-warning" />
    </div>



</asp:Content>
