<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCategorias.aspx.cs" Inherits="PRESENTACION.AdminCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="col-md-10">
        <div class="container">
            <h3>Agregar Nueva Categoría</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Nombre Categoría" aria-label="Search">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
        <br />
        <h3>Categorías</h3>

        <div class="col-lg-2">
            <asp:GridView ID="grdCategorias" runat="server"></asp:GridView>
            </div>

         </div>

</asp:Content>
