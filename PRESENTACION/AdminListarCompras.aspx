<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminListarCompras.aspx.cs" Inherits="PRESENTACION.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <div class="col-lg-10">
        <div class="container">
            <h3>Listar Compras</h3>

            <hr />
              <div class="row">
                <div class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Ingresar Fecha" aria-label="Search">
                    <asp:Button ID="btnAgregar" runat="server" Text="Filtrar" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>  
            <hr />
            <table class="table">
                <thead>
                   <tr class="active">
                        <th>Código de Compra</th>
                       <th>Código de Marca</th>
                         <th>Fecha</th>
                   </tr>
                </thead>
                <tbody>
                    <tr>
                    <td>1</td>
                    <td>2</td>
                    <td>3/11/2019</td>
                        </tr>
                </tbody>
            </table>
                           
                    <table class="table ">
                        <thead>
                           
                            <tr class="active">
                                <th>Codigo de Producto</th>
                                <th>Codigo de Plataforma</th>
                                <th>Nombre</th>
                              
                                <th>Cantidad</th>
                               
                            
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                 <td>1</td>
                                <td>PlayStation 4</td>
                         
                                <td>100</td>
                             
                                </tr>
                            

                                                      <tr>
                                <td>5</td>
                                 <td>1</td>
                                <td>Nintendo Switch</td>
                      
                                <td>200</td>

                           
                                </tr>
 
                        </tbody>
                    </table>
            <hr />
            <table class="table">
                <thead>
                   <tr class="active">
                        <th>Código de Compra</th>
                       <th>Código de Marca</th>
                         <th>Fecha</th>
                   </tr>
                </thead>
                <tbody>
                    <tr>
                    <td>2</td>
                    <td>2</td>
                    <td>3/11/2019</td>
                        </tr>
                </tbody>
            </table>
                           
                    <table class="table ">
                        <thead>
                           
                            <tr class="active">
                                <th>Codigo de Producto</th>
                                <th>Codigo de Plataforma</th>
                                <th>Nombre</th>
                              
                                <th>Cantidad</th>
                               
                            
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                 <td>1</td>
                                <td>PlayStation 4</td>
                         
                                <td>100</td>
                             
                                </tr>
                            

                                                      <tr>
                                <td>5</td>
                                 <td>1</td>
                                <td>Nintendo Switch</td>
                      
                                <td>200</td>

                           
                                </tr>
 
                        </tbody>
                    </table>


            </div>
        
      



            </div>
</asp:Content>
