<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProductos.aspx.cs" Inherits="PRESENTACION.AdminProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class ="col-lg-10">
    <div class="row">
            <div class="col-lg-10">
                 <h3> Productos</h3>
                <hr />
                    </div>
                 </div>
            
     

        <div class="row">
 
 
<div class="col-lg-2">
    <asp:Button class="btn btn-danger" ID="Button10" runat="server" Text="Agregar Producto" OnClick="Button10_Click" />
    </div>



           </div>
          <div class="row">
 
 
<div class="col-lg-2">

    </div>
           </div>

           <div class="row">
    <div class="col-lg-2">
 

 <div class="input-group">
      <div class="input-group-prepend">
    <input type="text" class="form-control" placeholder="Producto"/>
    <div class="input-group-btn">
      <button class="btn btn-danger" type="submit" >Buscar</button>
    </div>
  </div>
     </div>
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
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Categorias
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Video Juego</a>
                        <a class="dropdown-item" href="#">Accesorio</a>
                    </div>
                </div>
                                              &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Marcas
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Nintendo</a>
                        <a class="dropdown-item" href="#">Sony</a>
                        <a class="dropdown-item" href="#">Logitech</a>
                        <a class="dropdown-item" href="#">Microsoft</a>
                    </div>
                </div>
               </div>


                    <table class="table ">
                        <thead>
                           
                            <tr class="active">
                                <th>Código de producto</th>
                                <th>Código de Marca</th>
                                <th>Código de Categoría</th>
                                <th>Código de Plataforma</th>
                                <th>Nombre</th>
                                <th>Descripción</th>
                                <th>Año de Fabricación</th>
                                <th>Precio Unitario</th>
                                <th>Stock</th>
                                <th>Modificar</th>
                                 <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>35</td>
                                <td>1</td>
                                <td>3</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>Videojuego de pelea.</td>
                                <td>2018</td>
                                <td>$ 3500 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="btnModificar" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button5" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                        <tr>
                                <td>1</td>
                                <td>35</td>
                                <td>1</td>
                                <td>3</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>Videojuego de pelea.</td>
                                <td>2018</td>
                                <td>$ 3500 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                        <tr>
                                <td>1</td>
                                <td>35</td>
                                <td>1</td>
                                <td>3</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>Videojuego de pelea.</td>
                                <td>2018</td>
                                <td>$ 3500 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button4" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                        <tr>
                                <td>1</td>
                                <td>35</td>
                                <td>1</td>
                                <td>3</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>Videojuego de pelea.</td>
                                <td>2018</td>
                                <td>$ 3500 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="Button6" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button7" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                        <tr>
                                <td>1</td>
                                <td>35</td>
                                <td>1</td>
                                <td>3</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>Videojuego de pelea.</td>
                                <td>2018</td>
                                <td>$ 3500 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="Button8" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button9" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>

 
                        </tbody>
                    </table>
  <ul class="pagination">
    <li><a href="#"> 1 </a> </li>
    <li><a href="#"> 2 </a> </li>
    <li><a href="#"> 3 </a> </li>
    <li><a href="#"> 4 </a> </li>
    <li class="auto-style1"><a href="#"> 5 
        <asp:Calendar ID="Calen" runat="server"></asp:Calendar>
        </a> </li>
  </ul>
                </div>
 
 

 
 
 
 
</asp:Content>
