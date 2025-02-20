<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="ComercioRudo.ListaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListaUsu" runat="server" CssClass="table" DataKeyNames="IdUsuario" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvListaUsu_SelectedIndexChanged"   >

        <Columns>
            <asp:BoundField HeaderText="Id" DataField="IdUsuario" />
            <asp:BoundField HeaderText="Usuario" DataField="Usuario" />
            <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />
            <asp:BoundField HeaderText="TipoUsuario" DataField="tipoUsuario" />
            <asp:CommandField HeaderText="Modificar" SelectText="🛠" ShowSelectButton="true" />        

        </Columns>


    </asp:GridView>
    <asp:Button ID="btnAgregarUsu" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarUsu_Click"    />

    
</asp:Content>
