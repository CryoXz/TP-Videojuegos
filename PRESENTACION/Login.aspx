<%@ Page Title="" Language="C#" MasterPageFile="~/Logo.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PRESENTACION.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <div id="login">
            <div class="text-center">
                <a href="#"><img src="IMAGES/gslogo.png" alt="gs" style="width:300px;height:90px;margin-right:10px;"></a>
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
                                <label for="username" class="text-info">Nombre de usuario:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtUsuario" Width="100%"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="password" class="text-info">Contraseña:</label><br>
                                <asp:TextBox runat="server" class="form-control" ID="txtContraseña" Width="100%" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="remember-me" class="text-info"><span>Recordar</span> <span><input id="remember-me" name="remember-me" type="checkbox"></span></label><br>
                                <asp:Button ID="Button1" runat="server" CssClass="btn-danger" Text="Acceder" OnClick="Button1_Click" />
                            </div>
                            <asp:label ID="lblIncorrecto" runat="server" Text="Usuario o Contraseña incorrecto." ForeColor="Red" Width="90%"></asp:label>
                            <div id="register-link" class="text-right">
                                <a href="#" class="text-info">Registrarse</a>
                            </div>
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
