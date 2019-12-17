<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAltaProducto.aspx.cs" Inherits="PRESENTACION.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            left: -18px;
            top: 90px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-10">
        <div class="container">
            <h3>Agregar Nuevo Producto</h3>
            <hr />
            <div class="form-group row">

                <label class="col-lg-2 col-form-label">Nombre Producto:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtNombreProducto" runat="server" CssClass="rounded" TextMode="SingleLine"></asp:TextBox>
                </div>

            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Categoría:</label>
                <div class="col-lg-4">
                    <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="btn btn-danger"></asp:DropDownList>

                </div>
            </div>

            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Genero: </label>
                <div class="col-lg-4">

                    <asp:DropDownList ID="ddlGeneros" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
                </div>
            </div>

            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Marca:</label>
                <div class="col-lg-4">

                    <asp:DropDownList ID="ddlMarcas" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Descripción:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="rounded"></asp:TextBox>
                </div>
            </div>
            <%--<div class="form-group row">
                <label class="col-lg-2 col-form-label">Fecha de Fabricación:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtAnioFabricacion" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>--%>

            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Precio Unitario:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtPrecio" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Number" CssClass="rounded"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row">

                <div class="col-lg-4">
                </div>
            </div>

            <div class="row">
                <div class="col-lg-4">
                    <asp:Button class="btn btn-danger" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />

                </div>


            </div>
            <div class="col-lg-4">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
        </div>




    </div>


</asp:Content>
