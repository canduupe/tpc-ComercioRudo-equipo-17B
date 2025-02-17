<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarMarcas.aspx.cs" Inherits="ComercioRudo.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <asp:GridView ID="dgvListaMarcas" runat="server" CssClass="table"
   DataKeyNames="IdMarca"
     OnSelectedIndexChanged="dgvListaMarcas_SelectedIndexChanged"
      AutoGenerateColumns="false">

      <Columns>
          <asp:BoundField  HeaderText="Id" DataField="IdMarca" />
          <asp:BoundField HeaderText ="Nombre" DataField="Nombre" />


          <asp:CommandField HeaderText="Modificar" SelectText="🛠️" ShowSelectButton="true" />


      </Columns>




  </asp:GridView>



      <asp:Button ID="btnAgregarMarca" runat="server" Text="AGREGAR" CssClass="btn btn-outline-primary" OnClick="btnAgregarMarca_Click"/>

    






</asp:Content>
