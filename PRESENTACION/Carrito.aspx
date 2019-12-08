<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="PRESENTACION.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <br />
        <div class="main row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-8" style="background-color:ghostwhite">
                <asp:GridView ID="grdCarrito" runat="server">
                </asp:GridView>
            </div>
            <div class="col-lg-2" style="background-color:crimson"></div>
        </div>

    </div>

</asp:Content>
