<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAltaCompras.aspx.cs" Inherits="PRESENTACION.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <div class="col-lg-10">
        <div class="container">
            <h3>Agregar Nueva Compra</h3>
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
                               
                                 <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                 <td>1</td>
                                <td>PlayStation 4</td>
                         
                                <td>100</td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                            

                                                      <tr>
                                <td>5</td>
                                 <td>1</td>
                                <td>Nintendo Switch</td>
                      
                                <td>200</td>

                                <td>
                                    <asp:Button ID="Button10" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
 
                        </tbody>
                    </table>



          <div class="form-group row">

               <label class="col-lg-2 col-form-label">Código de Producto:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </div>
                
              </div>

         <div class="form-group row">
  <label class="col-lg-2 col-form-label">Cantidad:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  </div>
                           </div>

          <div class="form-group row">
  <label class="col-lg-2 col-form-label">Codigo de Plataforma:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  </div>
                           </div>

                                 <div class="row">
                          <div class="col-lg-2">
                              </div>
             <div class="col-lg-4">
                <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Agregar Producto" />

                 </div>


            </div>
            <div class="row">
                                          <div class="col-lg-2">

                                              <br />
                                              <br />

                              </div>
            </div>
                     <div class="row">
                          <div class="col-lg-2">
                              </div>
             <div class="col-lg-4">
                <asp:Button class="btn btn-danger" ID="Button2" runat="server" Text="Terminar Compra" />

                 </div>


            </div>
        
            </div>




            </div>
</asp:Content>
