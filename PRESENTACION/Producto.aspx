<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="PRESENTACION.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color:ghostwhite">
        <div class="main row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-4" style="background-color:ghostwhite">
                &nbsp;<asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                    <EditItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Actualizar" />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancelar" />
                            </td>
                            <td>
                                <asp:TextBox ID="Imagen_Producto_PxPTextBox" runat="server" Text='<%# Bind("Imagen_Producto_PxP") %>' />
                            </td>
                        </tr>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <table runat="server" style="">
                            <tr>
                                <td>No se han devuelto datos.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <InsertItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insertar" />
                                <asp:Button ID="Button1" runat="server" CommandName="Cancel" Text="Borrar" />
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Imagen_Producto_PxP") %>' />
                            </td>
                        </tr>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <tr style="">
                            <td>
                               <asp:Image ID="ImgProd" runat="server" Height="300px" ImageUrl='<%# Eval("Imagen_Producto_PxP") %>' Width="500px" />  
                            </td>
                        </tr>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                        <tr runat="server" style="">
                                            
                                        </tr>
                                        <tr runat="server" id="itemPlaceholder">
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
                        <tr style="">
                            <td>
                                <asp:Label ID="Imagen_Producto_PxPLabel" runat="server" Text='<%# Eval("Imagen_Producto_PxP") %>' />
                            </td>
                        </tr>
                    </SelectedItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TiendaVideojuegosConnectionString2 %>" SelectCommand="SELECT PlataformaxProducto.Imagen_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P"></asp:SqlDataSource>
            </div>
            <div class="col-lg-4" style="background-color:ghostwhite">
                <div>
                    <asp:ListView ID="ListView2" runat="server" DataSourceID="SqlDataSource2">
                        <EditItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="Button2" runat="server" CommandName="Update" Text="Actualizar" />
                                    <asp:Button ID="Button3" runat="server" CommandName="Cancel" Text="Cancelar" />
                                </td>
                                <td>
                                    <asp:TextBox ID="Nombre_Producto_PRTextBox" runat="server" Text='<%# Bind("Nombre_Producto_PR") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="Nombre_Plataforma_PTextBox" runat="server" Text='<%# Bind("Nombre_Plataforma_P") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="PrecioUnitario_Producto_PxPTextBox" runat="server" Text='<%# Bind("PrecioUnitario_Producto_PxP") %>' />
                                </td>
                            </tr>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="">
                                <tr>
                                    <td>No se han devuelto datos.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Button ID="Button4" runat="server" CommandName="Insert" Text="Insertar" />
                                    <asp:Button ID="Button5" runat="server" CommandName="Cancel" Text="Borrar" />
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Nombre_Producto_PR") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Nombre_Plataforma_P") %>' />
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("PrecioUnitario_Producto_PxP") %>' />
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <tr style="">
                                <br />
                                <br />
                                <td>
                                    <h2><asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' /></h2>
                                </td>
                                <br />
                                <td>
                                    <h6><asp:Label ID="Nombre_Plataforma_PLabel" runat="server" Text='<%# Eval("Nombre_Plataforma_P") %>' /></h6>
                                </td>
                                
                                Cantidad: <asp:DropDownList ID="ddlCant" runat="server">
                                             <asp:listitem text="1" value="1"></asp:listitem>
                                             <asp:listitem text="2" value="2"></asp:listitem>
                                             <asp:listitem text="3" value="3"></asp:listitem>
                                             <asp:listitem text="4" value="4"></asp:listitem>
                                             <asp:listitem text="5" value="5"></asp:listitem>
                                         </asp:DropDownList>
                                <br />
                                <br />
                                <td>
                                    <h4>$<asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' /></h4>
                                </td>
                                <br />
                            </tr>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <tr style="">
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' />
                                </td>
                                
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Nombre_Plataforma_P") %>' />
                                </td>
                                
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' />
                                </td>
                            </tr>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TiendaVideojuegosConnectionString2 %>" SelectCommand="SELECT Productos.Nombre_Producto_PR, Plataformas.Nombre_Plataforma_P, PlataformaxProducto.PrecioUnitario_Producto_PxP  FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P"></asp:SqlDataSource>
                    <asp:Button ID="btnCarrito" runat="server" class="btn btn-danger" Text="AGREGAR AL CARRITO" OnClick="btnCarrito_Click" />
                </div>                
            </div>
            <div class="col-lg-2" style="background-color:crimson">
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12" style="background-color:crimson">
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>

        </div>
    </div>

</asp:Content>
