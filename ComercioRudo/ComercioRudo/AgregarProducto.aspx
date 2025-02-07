<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarProducto.aspx.cs" Inherits="ComercioRudo.AgregarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>   
        <label> Nombre </label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>   
        <label> Marca</label>
        <asp:TextBox ID="txtMarca" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div>   
        <label> Categoria </label>
        <asp:TextBox ID="txtCate" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="Boton">   
        <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR" OnClick ="btnAgregar_Click" CssClass="btn btn-outline-secondary" />
        <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" CssClass="btn btn-outline-danger" />
    </div>
</asp:Content>
