<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminAltaProducto.aspx.cs" Inherits="PRESENTACION.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="col-lg-10">
        <div class="container">
            <h3>Agregar Nuevo Producto</h3>
            <hr />
          <div class="form-group row">

               <label class="col-lg-2 col-form-label">Nombre Producto:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </div>
                
              </div>

         <div class="form-group row">
  <label class="col-lg-2 col-form-label">Código Categoría:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  </div>
                           </div>

         <div class="form-group row">
 <label class="col-lg-2 col-form-label">Código Plataforma: </label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                  </div>
                           </div>

         <div class="form-group row">
                <label class="col-lg-2 col-form-label">Código Marca:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                  </div>
                           </div>
                    <div class="form-group row">
 <label class="col-lg-2 col-form-label">Descripción:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                  </div>
                           </div>
                    <div class="form-group row">
 <label class="col-lg-2 col-form-label">Año de Fabricación:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                  </div>
                           </div>

         <div class="form-group row">
 <label class="col-lg-2 col-form-label">Precio Unitario:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                  </div>
                           </div>

         <div class="form-group row">
 <label class="col-lg-2 col-form-label">Stock:</label> 
              <div class ="col-lg-4">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                  </div>
                           </div>

         <div class="row">
                          <div class="col-lg-2">
                              </div>
             <div class="col-lg-4">
                <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Agregar" />

                 </div>


            </div>
        
            </div>




            </div>


</asp:Content>
