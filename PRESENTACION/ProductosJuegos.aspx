<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ProductosJuegos.aspx.cs" Inherits="PRESENTACION.ProductosJuegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/ProductosJuegos.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color: ghostwhite">
        <br />
        <br />
        <br />
        <div class="main row">
            <div class="col-lg-12 text-center">
                <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-5"></div>
            <div class="col-lg-2 text-center">
                <label>Ordenar por:</label>
                <asp:DropDownList ID="ddlOrden" class="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrden_SelectedIndexChanged">
                    <asp:ListItem Text="A - Z" Value="1" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Z - A" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Precio: Menor a Mayor" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Precio: Mayor a Menor" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-lg-5"></div>
                    
        </div>
        <br />
        <div class="row">
            <div class="col-lg-2" style="background-color: crimson"></div>
            <div class="col-lg-8" style="background-color: ghostwhite">
                <asp:ListView runat="server" ID="grdProducto" GroupItemCount="4" Style="margin-right: 0px; margin-top: 0px">
                    <LayoutTemplate>
                        <div>
                            <asp:PlaceHolder runat="server" ID="groupPlaceHolder" />
                        </div>
                    </LayoutTemplate>
                    <GroupTemplate>
                        <div class="Grid" style="clear:both;">
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                        </div>
                    </GroupTemplate>
                    <ItemTemplate>
                        <div class="productItem">
                            <td>
                                <asp:ImageButton ID="ImgBtnProd" runat="server" ImageUrl='<%# Eval("Imagen_Producto_PxP") %>' OnClick="ImgBtnProd_Click" CssClass="imgbut" />
                                <br />
                                <asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' />
                                <br />
                                $<asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP", "{0:0.00}") %>' />
                                <br />
                            </td>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="col-lg-2" style="background-color: crimson"></div>
        </div>

    </div>
</asp:Content>
