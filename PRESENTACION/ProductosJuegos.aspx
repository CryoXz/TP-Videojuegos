<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ProductosJuegos.aspx.cs" Inherits="PRESENTACION.ProductosJuegos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:ghostwhite">
        <br />
        <br />
            <br />
        <div class="main row">
            <div class="col-lg-12 text-center">
                <h1 ID="lblTitulo">-JUEGOS SWITCH-</h1>
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-lg-5"></div>
            <div class="col-lg-2 text-center">
                <div class="form-group">
                    <label>Ordenar por:</label>
                    <select class="form-control" id="exampleFormControlSelect1">
                      <option>Mas Vendidos</option>
                      <option>Precio: Menor a Mayor</option>
                      <option>Precio: Mayor a Menor</option>
                      <option>A - Z</option>
                      <option>Z - A</option>
                    </select>
                </div>
            </div>
            <div class="col-lg-5"></div>
        </div>
        <div class="row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-8 text-center" style="background-color:ghostwhite">
                
                <asp:ListView ID="grdProducto" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="5" OnSelectedIndexChanged="grdProducto_SelectedIndexChanged">
                    <EditItemTemplate>
                        <td runat="server" style="">Imagen_Producto_PxP:
                            <asp:TextBox ID="Imagen_Producto_PxPTextBox" runat="server" Text='<%# Bind("Imagen_Producto_PxP") %>' />
                            <br />Nombre_Producto_PR:
                            <asp:TextBox ID="Nombre_Producto_PRTextBox" runat="server" Text='<%# Bind("Nombre_Producto_PR") %>' />
                            <br />PrecioUnitario_Producto_PxP:
                            <asp:TextBox ID="PrecioUnitario_Producto_PxPTextBox" runat="server" Text='<%# Bind("PrecioUnitario_Producto_PxP") %>' />
                            <br />
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                            <br />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                            <br /></td>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <table runat="server" style="">
                            <tr>
                                <td>No se han devuelto datos.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <EmptyItemTemplate>
<td runat="server" />
                    </EmptyItemTemplate>
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <InsertItemTemplate>
                        <td runat="server" style="">Imagen_Producto_PxP:
                            <asp:TextBox ID="Imagen_Producto_PxPTextBox" runat="server" Text='<%# Bind("Imagen_Producto_PxP") %>' />
                            <br />Nombre_Producto_PR:
                            <asp:TextBox ID="Nombre_Producto_PRTextBox" runat="server" Text='<%# Bind("Nombre_Producto_PR") %>' />
                            <br />PrecioUnitario_Producto_PxP:
                            <asp:TextBox ID="PrecioUnitario_Producto_PxPTextBox" runat="server" Text='<%# Bind("PrecioUnitario_Producto_PxP") %>' />
                            <br />
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                            <br />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Borrar" />
                            <br /></td>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <td runat="server" style="">&nbsp;<asp:ImageButton ID="ImgBtnProd" runat="server" Height="100px" ImageUrl='<%# Eval("Imagen_Producto_PxP") %>' Width="100px" />
                            <br />
                            <asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' />
                            <br />$<asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' />
                            <br /></td>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                        <tr id="groupPlaceholder" runat="server">
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" style=""></td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                        <td runat="server" style="">Imagen_Producto_PxP:
                            <asp:Label ID="Imagen_Producto_PxPLabel" runat="server" Text='<%# Eval("Imagen_Producto_PxP") %>' />
                            <br />Nombre_Producto_PR:
                            <asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' />
                            <br />PrecioUnitario_Producto_PxP:
                            <asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' />
                            <br /></td>
                    </SelectedItemTemplate>
                </asp:ListView>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TiendaVideojuegosConnectionString %>"></asp:SqlDataSource>
                
            </div>
            <div class="col-lg-2" style="background-color:crimson"></div>
        </div>
  
    </div>

</asp:Content>