<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="PRESENTACION.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/ProductosJuegos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid" style="background-color: ghostwhite">
        <div class="main row">
            <div class="col-lg-2" style="background-color: crimson"></div>
            <div class="col-lg-4" style="background-color: ghostwhite">
                <asp:ListView ID="grdProd" runat="server">
                    <ItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Image ID="ImgProd" CssClass="productoFoto" runat="server" ImageUrl='<%# Eval("Imagen_Producto_PxP") %>' />
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
                </asp:ListView>
             </div>
            <div class="col-lg-4" style="background-color: ghostwhite">
                <div>
                    <asp:ListView ID="grdDatos" runat="server">
                        <ItemTemplate>
                            <tr>
                                <br />
                                <br />
                                <td>
                                    <h2>
                                        <asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' /></h2>
                                </td>
                                <br />
                                <td>
                                    <h6>
                                        <asp:Label ID="Nombre_Plataforma_PLabel" runat="server" Text='<%# Eval("Nombre_Plataforma_P") %>' /></h6>
                                </td>

                                Cantidad:
                                <asp:TextBox ID="txtCant" runat="server" type="number" min="1" max="10" >1</asp:TextBox>
                                <br />
                                <br />
                                <td>
                                    <h4>$<asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' /></h4>
                                </td>
                                <br />
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                    <asp:Button ID="btnCarrito" runat="server" class="btn btn-danger" Text="AGREGAR AL CARRITO" OnClick="btnCarrito_Click" />
                </div>
            </div>
            <div class="col-lg-2" style="background-color: crimson">
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12" style="background-color: crimson">
                <br />
                <br />
                <br />
                <br />
                <br />
            </div>

        </div>
    </div>

</asp:Content>
