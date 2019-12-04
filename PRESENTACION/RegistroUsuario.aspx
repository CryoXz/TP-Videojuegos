<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="PRESENTACION.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro Usuario</title>
    <link type="text/css" href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="~/Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="~/Scripts/jquery-3.0.0.min.js"></script>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">

        

        <div class="container-fluid" style="width: 500px; margin: auto;">
            <div class="container">
                <h3>Registro de Usuario</h3>
                <hr />
                <div>
                    <div class="form-group">
                        <label for="tipo">Tipo de Usuario</label>
                        <asp:DropDownList ID="ddlTipoUsuario" runat="server"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="nombre">Nombre</label>
                                <asp:TextBox ID="txtNombre_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                            <div class="col">
                                <label for="nombre">Apellido</label>
                                <asp:TextBox ID="txtApellido_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="nombre">Nickname</label>
                                <asp:TextBox ID="txtNickname_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                            <div class="col">
                                <label for="nombre">Contraseña</label>
                                <asp:TextBox ID="txtContraseña_usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="nombre">Dni</label>
                                <asp:TextBox ID="txtDni_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                            <div class="col">
                                <label for="nombre">Fecha de Nacimiento</label>
                                <asp:TextBox ID="txtfNacimiento_Usuario" runat="server" class="form-control" placeholder="dd/mm/aaaa"> </asp:TextBox>

                                <input type="date" name="bday" />            
                                <input type="submit" />
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="nombre">Telefono</label>
                                <asp:TextBox ID="txtTelefono_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                            <div class="col">
                                <label for="nombre">Email</label>
                                <asp:TextBox ID="txtEmail_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col">
                                <label for="nombre">Direccion</label>
                                <asp:TextBox ID="txtDireccion_Usuario" runat="server" class="form-control"> </asp:TextBox>
                            </div>
                            <div class="col">
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-danger" OnClick="btnAgregar_Click" />
                    </div>
                </div>
            </div>
        </div>








    </form>
</body>
</html>
