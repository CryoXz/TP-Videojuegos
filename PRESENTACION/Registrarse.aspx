<%@ Page Title="" Language="C#" MasterPageFile="~/Logo.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="PRESENTACION.Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color: crimson">
        <br />
        <br />
        <div id="login">
            <div class="text-center">
                <img src="IMAGES/gslogo.png" alt="gs" style="width: 300px; height: 90px; margin-right: 10px;">
            </div>

            <br />
            <br />
            <div class="container">
                <div id="login-row" class="row justify-content-center align-items-center">
                    <div id="login-column" class="col-lg-6" style="background-color: ghostwhite; border: 1px">
                        <br />
                        <div id="login-box" class="col-lg-12">
                            <form id="login-form" class="form" method="post">
                                <div class="form-group">
                                    <label for="nombre" class="text-info">Nombre:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtNombre" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="apellido" class="text-info">Apellido:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtApellido" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="username" class="text-info">Nombre de usuario:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtUsername" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="password" class="text-info">Contraseña:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtContraseña" Width="100%" type="password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="password" class="text-info">Vuelva a ingresar su contraseña:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtContraseña2" Width="100%" type="password"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <style>
                                        /* Chrome, Safari, Edge, Opera */
                                        input::-webkit-outer-spin-button,
                                        input::-webkit-inner-spin-button {
                                            -webkit-appearance: none;
                                            margin: 0;
                                        }

                                        /* Firefox */
                                        input[type=number] {
                                            -moz-appearance: textfield;
                                        }
                                    </style>
                                    <label for="dni" class="text-info">DNI:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtDNI" Width="100%" type="number"></asp:TextBox>
                                </div>
                                <div class="form-group" style="margin: 1%">
                                    <label for="fNac" class="text-info">Fecha de Nacimiento:</label>
                                    <asp:TextBox runat="server" class="form-control" ID="txtFecha" Width="100%" type="date"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="provincia" class="text-info">Provincia:</label><br>
                                    <asp:DropDownList runat="server" class="form-control" ID="ddlProvincia" AutoPostBack="True" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="localidad" class="text-info">Localidad:</label><br>
                                    <asp:DropDownList runat="server" class="form-control" ID="ddlLocalidad"></asp:DropDownList>
                                </div>
                                <div class="form-group">
                                    <label for="direccion" class="text-info">Direccion:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtDireccion" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="email" class="text-info">E-Mail:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtMail" Width="100%"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <label for="telefono" class="text-info">Telefono:</label><br>
                                    <asp:TextBox runat="server" class="form-control" ID="txtTelefono" Width="100%" type="number"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Button ID="btnRegistrarse" runat="server" class="btn btn-danger" Text="Acceder" OnClick="btnRegistrarse_Click" />
                                </div>
                                <asp:Label ID="lblIncorrecto" runat="server" Text="" ForeColor="Red" Width="90%"></asp:Label>
                            </form>
                        </div>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
