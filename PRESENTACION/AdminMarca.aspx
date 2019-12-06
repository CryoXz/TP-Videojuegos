<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminMarca.aspx.cs" Inherits="PRESENTACION.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class ="col-lg-10">
    <div class="row">
            <div class="col-lg-10">

                    <h3> Marcas</h3>
                <hr />
                    </div>
                 </div>
            
     

        <div class="row">
 
 
<div class="col-lg-2">
    <asp:Button class="btn btn-danger" ID="Button10" runat="server" Text="Agregar Marca" />
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
    <input type="text" class="form-control" placeholder="Marca"/>
    <div class="input-group-btn">
      <button class="btn btn-danger" type="submit" >Buscar</button>
    </div>
  </div>
     </div>
            </div>
               </div>

         <div class="col-lg-2">
             <asp:GridView ID="grdMarca" runat="server"></asp:GridView>
    </div>
                    <table class="table ">
                        <thead>
                           
                            <tr class="active">
                                <th>Codigo de Marca</th>
                                <th>Nombre de Companía</th>
                                <th>Nombre de Contacto</th>
                                <th>Direccion</th>
                                <th>Ciudad</th>
                                <th>Telefono</th>
                                <th>Email</th>
                                <th>Modificar</th>
                                 <th>Eliminar</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Nintendo</td>
                                <td>Pedro Casares </td>
                                <td> Alvear 200</td>
                                <td>Buenos Aires</td>
                                <td>0115552378</td>
                                <td>P_Casares@gmail.com</td>
                                <td>
                                    <asp:Button ID="btnModificar" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button5" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                 <tr>
                                <td>1</td>
                                <td>Nintendo</td>
                                <td>Pedro Casares </td>
                                <td> Alvear 200</td>
                                <td>Buenos Aires</td>
                                <td>0115552378</td>
                                <td>P_Casares@gmail.com</td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                 <tr>
                                <td>1</td>
                                <td>Nintendo</td>
                                <td>Pedro Casares </td>
                                <td> Alvear 200</td>
                                <td>Buenos Aires</td>
                                <td>0115552378</td>
                                <td>P_Casares@gmail.com</td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button4" runat="server" Text="X" CssClass="btn-danger" />
                                </td>
                                </tr>
                                 <tr>
                                <td>1</td>
                                <td>Nintendo</td>
                                <td>Pedro Casares </td>
                                <td> Alvear 200</td>
                                <td>Buenos Aires</td>
                                <td>0115552378</td>
                                <td>P_Casares@gmail.com</td>
                                <td>
                                    <asp:Button ID="Button6" runat="server" Text="M" CssClass="btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="Button7" runat="server" Text="X" CssClass="btn-danger" />
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
 
 

 
 
</asp:Content>
