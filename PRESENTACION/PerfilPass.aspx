<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="PerfilPass.aspx.cs" Inherits="PRESENTACION.PerfilPass" %>
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
                    <h3>Contraseña</h3>
                </div>
                <br />
                <div>
                    <h6>Contraseña actual:</h6>
                    <asp:TextBox ID="txtActual" type="password" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Nueva contraseña:</h6>
                    <asp:TextBox ID="txtNueva" type="password" runat="server" Width="500px"></asp:TextBox>
                </div>
                <br />
                <div>
                    <h6>Volver a ingresar nueva contraseña:</h6>
                    <asp:TextBox ID="txtNueva2" type="password" runat="server" Width="500px"></asp:TextBox>
                </div>
                <div style="text-align:center">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
                <br />
                <div style="text-align:center">
                    <asp:Button ID="btnConfirmar" class="btn btn-danger" runat="server" Text="CONFIRMAR NUEVA CONTRASEÑA" OnClick="btnConfirmar_Click" />
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
