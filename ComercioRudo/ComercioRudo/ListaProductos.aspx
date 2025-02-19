<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="ComercioRudo.ListaProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:GridView ID="dgvListaProduc" runat="server" CssClass="table" DataKeyNames="IdProducto" OnSelectedIndexChanged="dgvListaProduc_SelectedIndexChanged" AutoGenerateColumns="false">
<Columns>
    <asp:BoundField HeaderText="Id" DataField="IdProducto" />
    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
    <asp:BoundField HeaderText="IdMarca" DataField="IdMarca" />
    <asp:BoundField HeaderText="IdCategoria" DataField="IdCategoria" />
    <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="🛠️"  />  

</Columns>



</asp:GridView>
<asp:Button ID="btnAgregarProd" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarProd_Click"/>


</asp:Content>
