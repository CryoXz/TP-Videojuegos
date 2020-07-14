<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="PRESENTACION.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <h2 style="color:white;text-align:center">PERFIL</h2>
        <br />
        <div class="main row">
            <div class="col-lg-4" style="background-color:crimson"></div>
            <div class="col-lg-4" style="background-color:white; color:crimson">
                <br />
                <div>
                    <h3>Datos</h3>
                </div>
                <br />
                <div>
                    <h6>Nombre:</h6>
                    <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Apellido:</h6>
                    <asp:Label ID="lblApellido" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Nombre de usuario:</h6>
                    <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Contraseña:</h6>
                    <asp:Label ID="lblPassword" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Email:</h6>
                    <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>DNI:</h6>
                    <asp:Label ID="lblDNI" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Fecha de nacimiento:</h6>
                    <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Provincia:</h6>
                    <asp:Label ID="lblProvincia" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Localidad:</h6>
                    <asp:Label ID="lblLocalidad" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Direccion:</h6>
                    <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div>
                    <h6>Telefono:</h6>
                    <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div style="text-align:center">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div style="text-align:right">
                    <a href="PerfilEditar.aspx">Editar datos de usuario</a>
                </div>
                <div style="text-align:right">
                    <a href="HistorialCompras.aspx">Ver historial de compras</a>
                </div>
                <br />
            </div>
            <div class="col-lg-4" style="background-color:crimson"></div>
        </div>
        <div class="row" style="background-color:crimson">
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
