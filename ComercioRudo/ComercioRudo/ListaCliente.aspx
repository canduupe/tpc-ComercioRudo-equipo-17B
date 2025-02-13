<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="ComercioRudo.ListaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="dgvListaCli" runat="server" CssClass="table" 
     DataKeyNames="IdCliente"
         AutoGenerateColumns="false"
     OnSelectedIndexChanged="dgvListaCli_SelectedIndexChanged" >

    <Columns>
        <asp:BoundField HeaderText="Id"  DataField="IdCliente" />
        <asp:BoundField HeaderText="Nombre"  DataField="Nombre" />
        <asp:BoundField HeaderText="Apellido"  DataField="Apellido" />
        <asp:BoundField HeaderText="DNI"  DataField="DNI" />
        <asp:CommandField HeaderText="Modificar" ShowSelectButton="true"  SelectText="🛠️" />



    </Columns>


    </asp:GridView>
      
        
 




    <asp:Button ID="btnAgregarCli" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarCli_Click"    />

</asp:Content>
