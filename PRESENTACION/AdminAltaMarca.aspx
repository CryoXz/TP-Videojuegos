<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAltaMarca.aspx.cs" Inherits="PRESENTACION.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-10">
        <div class="container">
            <h3>Agregar Nueva Marca</h3>
            <hr />
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Nombre Companía:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtNombreMarca" runat="server" onkeypress="javascript:return soloLetras(event)"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Nombre de Contacto:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtNombreContacto" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Dirección: </label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Ciudad:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">Teléfono:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row">
                <label class="col-lg-2 col-form-label">E-Mail:</label>
                <div class="col-lg-4">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="rounded" TextMode="Email"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-2">
                </div>
                <div class="col-lg-4">
                    <asp:Button class="btn btn-danger" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
