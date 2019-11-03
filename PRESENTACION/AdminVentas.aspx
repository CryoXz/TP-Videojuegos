<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminVentas.aspx.cs" Inherits="PRESENTACION.AdminVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-md-10">
        <div class="container">

            <h3>Filtros de Ventas</h3>
            <hr />
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="Label1" runat="server" Text="Label">Nombre Usuario</asp:Label>
                </div>
                <div class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Nombre de Producto" aria-label="Search">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-danger" />
                </div>
                &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Plataformas
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Nintendo Switch</a>
                        <a class="dropdown-item" href="#">Nintendo 3ds</a>
                        <a class="dropdown-item" href="#">Playstation 3</a>
                        <a class="dropdown-item" href="#">Playstation 4</a>
                        <a class="dropdown-item" href="#">PS Vita</a>
                        <a class="dropdown-item" href="#">Xbox 360</a>
                        <a class="dropdown-item" href="#">Xbox One</a>
                        <a class="dropdown-item" href="#">Pc</a>
                    </div>
                </div>
                &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Generos
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Aventura</a>
                        <a class="dropdown-item" href="#">Lucha</a>
                        <a class="dropdown-item" href="#">Shoother</a>
                        <a class="dropdown-item" href="#">Deportes</a>
                        <a class="dropdown-item" href="#">Accion</a>
                        <a class="dropdown-item" href="#">Arcade</a>
                        <a class="dropdown-item" href="#">Carreras</a>
                        <a class="dropdown-item" href="#">Estrategias</a>
                    </div>
                </div>
                &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Categorias
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Video Juego</a>
                        <a class="dropdown-item" href="#">Accesorio</a>
                    </div>
                </div>

            </div>
        </div>
                                 
        <asp:Label Text="Top ten" runat="server" Font-Size="large" />
            &nbsp
        <asp:Label Text="Playstation 4" runat="server" Font-Size="medium" />

        <div class="table-responsive">
            <table class="table ">
                <thead>
                    <tr class="active">
                        <th>Codigo</th>
                         <th>Nombre Producto</th>
                        <th>Categoria</th>
                        <th>Plataforma</th>
                         <th>Genero</th>
                       
                        <th>Vendidos</th>
                        <th>Estado</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1502</td>
                        <td>Grid</td>
                        <td>Video Juego</td>
                         <td>Playatation 4s</td>
                        <td>Carreras</td>
                        
                        <td>200</td>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Activo" />
                        </td>
                    </tr>
                    <tr>
                        <td>1015</td>
                         <td>Watch Dogs Legion</td>
                        <td>Video Juego</td>
                        <td>Playstation 4</td>
                         <td>Acción</td>
                        <td>120</td>
                        <td>
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Activo" />
                        </td>
                    </tr>
                    <tr>
                        <td>2027</td>
                         <td>FIFA 20 Champions Edition</td>
                        <td>Video Juego</td>
                        <td>Playstation 4</td>
                         <td>Deportes</td>
                        <td>110</td>
                        <td>
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Activo" />
                        </td>
                    </tr>
                    <tr>
                        <td>2030</td>
                         <td>Dragon Z Kakarot</td>
                        <td>Video Juego</td>
                        <td>Playstation 4</td>
                         <td>Lucha</td>
                        <td>105</td>
                        <td>
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Activo" />
                        </td>
                    </tr>
                    <tr>
                        <td>3036</td>
                         <td>Call of Duty: Modern Warfare</td>
                        <td>Video Juego</td>
                        <td>Playstation 4</td>
                         <td>Acción</td>
                        <td>90</td>
                        <td>
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Activo" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>
