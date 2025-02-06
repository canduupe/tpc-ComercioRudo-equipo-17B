<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMarca.aspx.cs" Inherits="ComercioRudo.AgregarMarca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>   
        <label> Nombre </label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="Botons">  
        <asp:Button ID="btnAgregar" runat="server" Text="ACEPTAR" OnClick="btnAgregar_Click"  CssClass="btn btn-outline-secondary"   />        
        <asp:Button ID="btnCancel" runat="server" Text="CANCELAR" OnClick="btnCancel_Click"   CssClass="btn btn-outline-danger"   />        
    </div>



</asp:Content>
