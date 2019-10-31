<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminVentas.aspx.cs" Inherits="PRESENTACION.AdminVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-color:ghostwhite">
    <div class="row">
            <div class="btn-group-vertical btn-group-lg col-md-2 bg-danger"  >      
                <br />                
                <button type="button" class="btn btn-danger">Usuarios</button>
                <button type="button" class="btn btn-danger">Ventas</button>
                <button type="button" class="btn btn-danger">Productos</button>
                <button type="button" class="btn btn-danger">Pedidos</button>
            </div>
 
            <div class="col-md-10">   
                <br /> 
                <asp:Label Text="Ultimas Ventas" runat="server" Font-Size="Medium"/>
                <div class="table-responsive">
                    <table class="table ">
                        <thead>
                            <tr class="active">
                                <th>Codigo de Venta</th>
                                <th>Codigo Usuario</th>
                                <th>Fecha Venta</th>
                                <th>Tipo de Pago</th>
                                <th>Venta</th>
                                <th>Estado</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>0002</td>
                                <td>
                                    4
                                    <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
                                        </td>
                                <td>19/12/2010</td>
                                <td>1</td>
                                <td>5000</td>
                                <td>
                                     <asp:CheckBox ID="CheckBox3" runat="server" Text="Activo" />
                                </td>
                            </tr>
                            <tr>
                                <td>0025</td>
                                <td>
                                    3
                                   <%-- <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>--%>
                                    </td>                              
                                <td>02/02/2014</td>
                                <td>2</td>
                                <td>2500</td>
                                <td>
                                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Activo" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
           
             <div class="btn-group-vertical btn-group-lg col-md-2 bg-danger"  >
                         
            </div>
                                                                       
             <div class="col-md-10">                
                <asp:Label Text="Producto mas Vendido" runat="server" Font-Size="Medium"/>
                <div class="table-responsive">
                    <table class="table ">
                        <thead>
                            <tr class="active">
                                <th>Codigo de Producto</th>                  
                                <th>Categoria</th>
                                <th>Plataforma</th>
                                <th>Nombre Producto</th>
                                <th>Cantidad Vend</th>
                                <th>Estado</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>2020</td>                                
                                <td>Video Juego</td>
                                <td>Nintendo Switch</td>
                                <td>Super Smash Bros. Ultimate</td>
                                <td>10</td>                                
                                <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Activo" />
                                </td>
                            </tr>
                            <tr>
                                <td>1015</td>                                
                                <td>Accesorio</td>
                                <td>Playstation 4</td>
                                <td>joystick</td>
                                <td>2</td>                                
                                <td>
                                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Activo" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
                                 
        </div>
    </div>

</asp:Content>
