﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMvendedores.aspx.cs" Inherits="ComercioRudo.ABMvendedores" %>
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


            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

        <% if(Request.QueryString["IdVendedor"] != null){ %>

        <div class="Boton">
            <asp:Button Text="Eliminar" ID="btnEliminar" OnClick="btnEliminar_Click"       runat="server" CssClass="btn btn-danger" />
        </div>

        <% } %>


        <%if (confirmarEli)
            { %>
        <div>
            <asp:CheckBox Text="Confirmar Eliminacion" ID="chkConfirm" runat="server" />
            <asp:Button Text="Confirmar" ID="btnConfirm" runat="server" OnClick="btnConfirm_Click"    CssClass="btn btn-danger" />

        </div>

        <% } %>
    </ContentTemplate>
</asp:UpdatePanel>


</asp:Content>
