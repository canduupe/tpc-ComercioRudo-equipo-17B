<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarVendedores.aspx.cs" Inherits="ComercioRudo.ListarVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListarVend" runat="server" CssClass="table"
      DataKeyNames="IdVendedor"
       OnSelectedIndexChanged="dgvListarVend_SelectedIndexChanged"
        AutoGenerateColumns="true">

        <Columns>
            <asp:BoundField HeaderText="Id" DataField="IdVendedor" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="🛠️"



        </Columns>





    </asp:GridView>
    <asp:Button ID="btnAgregarVend" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarVend_Click"/>

</asp:Content>
