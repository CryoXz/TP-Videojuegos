<%@ Page Title="" Language="C#" MasterPageFile="~/Logo.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="PRESENTACION.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <div id="login">
            <div class="text-center">
                <img src="IMAGES/gslogo.png" alt="gs" style="width:300px;height:90px;margin-right:10px;">
            </div>
        
        <br />
        <br />
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-lg-6" style="background-color:ghostwhite;border:1px">
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
                                <asp:TextBox runat="server" class="form-control" ID="txtContraseña" Width="100%" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="dni" class="text-info">DNI:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtDni" Width="100%" TextMode="Number"></asp:TextBox>
                            </div>
                            <div class="form-group" style="margin:1%">
                                <label for="fNac" class="text-info">Fecha de Nacimiento (dd/mm/aa):</label>
                                <asp:TextBox runat="server" class="form-control" ID="txtFecha" Width="100%" TextMode="Date"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="telefono" class="text-info">Telefono:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtTelefono" Width="100%" TextMode="Phone"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="email" class="text-info">E-Mail:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtMail" Width="100%" TextMode="Email"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="direccion" class="text-info">Direccion:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtDireccion" Width="100%"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnRegistrarse" runat="server" CssClass="btn-danger" Text="Acceder" OnClick="btnRegistrarse_Click" />
                            </div>
                            <asp:label ID="lblIncorrecto" runat="server" Text="Usuario o Contraseña incorrecto." ForeColor="Red" Width="90%"></asp:label>
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
