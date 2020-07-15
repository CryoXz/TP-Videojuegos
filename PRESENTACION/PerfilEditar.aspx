<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="PerfilEditar.aspx.cs" Inherits="PRESENTACION.PerfilEditar" %>
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
                    <asp:TextBox ID="txtNombre" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Apellido:</h6>
                    <asp:TextBox ID="txtApellido" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Nombre de usuario:</h6>
                    <asp:TextBox ID="txtUsername" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Email:</h6>
                    <asp:TextBox ID="txtEmail" runat="server" type="email" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>DNI:</h6>
                    <asp:TextBox ID="txtDNI" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Fecha de nacimiento:</h6>
                    <asp:TextBox ID="txtFecha" runat="server" type="date"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Provincia:</h6>
                    <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <br />
                <div>
                    <h6>Localidad:</h6>
                    <asp:DropDownList ID="ddlLocalidad" runat="server"></asp:DropDownList>
                </div>
                <br />
                <div>
                    <h6>Direccion:</h6>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Telefono:</h6>
                    <asp:TextBox ID="txtTelefono" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <br />
                <div style="text-align:center">
                    <asp:Button ID="btnFinalizar" class="btn btn-danger" runat="server" Text="FINALIZAR EDICION" OnClick="btnFinalizar_Click" />
                </div>
                
                <br />
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
