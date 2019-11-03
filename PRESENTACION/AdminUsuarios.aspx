<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUsuarios.aspx.cs" Inherits="PRESENTACION.AdminUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <div class="col-md-10">
        <div class="container">
            <h3>Filtros Usuarios</h3>
            <hr />
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="Label1" runat="server" Text="Label">Nombre Usuario</asp:Label>
                </div>
                <div class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Nombre o Apellido" aria-label="Search">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-danger" />
                </div>
                <div class="col-md-2">
                    Filtrar por:
                </div>
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Tipo de Usuario
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Empleado</a>
                        <a class="dropdown-item" href="#">Cliente</a>                   
                    </div>
                </div>

            </div>
        </div>
        <hr />

        <h3>Usuarios</h3>
        <table class="table">
            <caption>List of users</caption>
            <thead>
                <tr>
                    <th scope="col">Codigo</th>
                    <th scope="col">Tipo</th>
                    <th scope="col">Nombre</th>
                    <th scope="col">Apellido</th>
                    <th scope="col">Dni</th>
                    <th scope="col">Telefono</th>
                    <th scope="col">E-mail</th>
                    <th scope="col">Direccion</th>
                    <th scope="col">Estado</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Administrador</td>
                    <td>Alexis</td>
                    <td>Rogriguez</td>
                    <td>41864284</td>
                    <td>1164004585</td>
                    <td>ard@gmail.com</td>
                    <td>Moreno 362</td>
                    <td>1</td>                   
                    <td>
                        <asp:Button ID="btnModificar1" runat="server" Text="Modificar" CssClass="btn btn-danger" />
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Empleado</td>
                    <td>Anahi</td>
                    <td>Favre</td>
                    <td>35123222</td>
                    <td>1546825737</td>
                    <td>RAF@Gmail.com</td>
                    <td>Av Centenario 664</td>
                    <td>1</td>
                    <td>
                        <asp:Button ID="btnModificar2" runat="server" Text="Modificar" CssClass="btn btn-danger" />
                    </td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Cliente</td>
                    <td>Sergio</td>
                    <td>Robledo</td>
                    <td>27802555</td>
                    <td>1166222234</td>
                    <td>srr2055@hotmail.com</td>
                    <td>san jose 362</td>
                    <td>1</td>
                    <td>
                        <asp:Button ID="btnModificar3" runat="server" Text="Modificar" CssClass="btn btn-danger" />
                    </td>
                </tr>

            </tbody>
        </table>
    </div>
</asp:Content>
