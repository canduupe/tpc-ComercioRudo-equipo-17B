<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="ComercioRudo.AgregarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   

    <div>
        <label> Usuario </label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtUsuario" />
    </div>
    <div>   
        <label class="Boton">Contraseña </label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtContraseña"/>  
    </div>
    <div>   
        <label class="Boton">TipoUsuario </label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtTipoUsuario"/>  
    </div>


</asp:Content>
