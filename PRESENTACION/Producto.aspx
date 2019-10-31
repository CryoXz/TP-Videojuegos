<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="PRESENTACION.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:ghostwhite">
        <div class="main row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-4" style="background-color:ghostwhite">
                <img src="IMAGES/smash-box.jpg" alt="CAJA" style="width:500px;height:500px;">
            </div>
            <div class="col-lg-4" style="background-color:ghostwhite">
                <div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <h3> Super Smash Bros. Ultimate</h3>
                    <h5>Nintendo Switch</h5>
                    <br />
                    <br />
                    <h4>$4500</h4>
                    <br />
                    <button type="button" class="btn btn-danger">AGREGAR AL CARRITO</button>
                </div>                
            </div>
            <div class="col-lg-2" style="background-color:crimson">
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12" style="background-color:crimson">
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>

        </div>
    </div>

</asp:Content>
