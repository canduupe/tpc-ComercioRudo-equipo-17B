<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCategoria.aspx.cs" Inherits="ComercioRudo.AgregarCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>   
    <label> Nombre </label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
</div>
<div class="Boton">  
    <asp:Button ID="btnAgregar" runat="server" Text="ACEPTAR" OnClick="btnAgregar_Click"  CssClass="btn btn-outline-secondary"   />        
    <asp:Button ID="btnCancel" runat="server" Text="CANCELAR" OnClick="btnCancel_Click"   CssClass="btn btn-outline-danger"   />        
</div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
            <% if(Request.QueryString["IdCategoria"] != null){ %>

        <div class="Boton">
            <asp:Button Text="Eliminar" ID="btnEliminar"  OnClick="btnEliminar_Click"   runat="server" CssClass="btn btn-danger" />
        </div>

        <% } %>


        <%if (confirmarEli)
            { %>
        <div>
            <asp:CheckBox Text="Confirmar Eliminacion" ID="chkConfirm" runat="server" />
            <asp:Button Text="Confirmar" ID="btnConfirm" runat="server"  OnClick="btnConfirm_Click"  CssClass="btn btn-danger" />

        </div>

        <% } %>
    </ContentTemplate>
</asp:UpdatePanel>

</asp:Content>
