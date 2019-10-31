<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProductos.aspx.cs" Inherits="PRESENTACION.AdminProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:ghostwhite">
    <div class="row">
            <div class="col-md-6">
    </div>
             <div class=" col-md-2"  >
                    <div>
                    <h2> Productos</h2>
                    </div>
                 </div>
            </div>
       <div class="row">
 
 
<div class="col-md-2">
    </div>
    <div class="col-md-2">
 
 
 <div class="input-group">
      <div class="input-group-prepend">
    <input type="text" class="form-control" placeholder="Producto"/>
    <div class="input-group-btn">
      <button class="btn btn-danger" type="submit" >Buscar </button>
    </div>
  </div>
     </div>
            </div>
           </div>
 
        <div class="row">
 
        </div>
            <div class="row">
        <div class="btn-group-vertical btn-group-lg col-md-2 bg-danger"  >
 
                <button type="button" class="btn btn-danger">Usuarios</button>
                <button type="button" class="btn btn-danger">Ventas</button>
                <button type="button" class="btn btn-danger">Productos</button>
                <button type="button" class="btn btn-danger">Pedidos</button>
            </div>
 
 
 
            <div class="col-md-10">
               
               
                <div class="table-responsive">
                    <table class="table ">
                        <thead>
                           
                            <tr class="active">
                                <th>Codigo de producto</th>
                                <th>Nombre</th>
                                <th>Precio Unitario</th>
                                <th>Stock</th>
                                <th>Modificar</th>
                                 <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>PlayStation 4</td>
                                <td>$ 40.000 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="btnModificar" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button5" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                      <tr>
                                <td>2</td>
                                <td>PlayStation 4 Slim</td>
                                <td>$ 45.000 </td>
                                <td>100</td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button6" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                                            <tr>
                                <td>3</td>
                                <td>XBox 360</td>
                                <td>$ 38.000 </td>
                                <td>120</td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button7" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
 
                            </tr>
                                                                                        <tr>
                                <td>4</td>
                                <td>XBox ONE</td>
                                <td>$ 30.000 </td>
                                <td>100</td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button8" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                                                                              </tr>
                                                      <tr>
                                <td>5</td>
                                <td>Nintendo Switch</td>
                                <td>$ 335.000 </td>
                                <td>200</td>
                                <td>
                                    <asp:Button ID="Button4" runat="server" Text="M" CssClass="btn-primary" />
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
    <li><a href="#"> 5 </a> </li>
  </ul>
                </div>
 
 
 
 
 
        </div>
 
 
 
        </div>
        </div>
</asp:Content>
