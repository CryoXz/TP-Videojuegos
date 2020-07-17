<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="ProductosJuegosO.aspx.cs" Inherits="PRESENTACION.ProductosJuegosO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
        <br />
        <div class="row">
            <div class="col-lg-5"></div>
            <div class="col-lg-2 text-center">
                <div class="form-group">
                    <label>Ordenar por:</label>
                    <asp:DropDownList ID="ddlOrden" class="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrden_SelectedIndexChanged">
                        <asp:ListItem Text="A - Z" Value="1" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Z - A" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Precio: Menor a Mayor" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Precio: Mayor a Menor" Value="4"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-lg-5"></div>
        </div>
        <div class="row">
            <div class="col-lg-2" style="background-color: crimson"></div>
            <div class="col-lg-8 text-center" style="background-color: ghostwhite">

                <asp:ListView ID="grdProducto" runat="server" GroupItemCount="3">
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    <ItemTemplate>
                        <td runat="server">
                            <asp:ImageButton ID="ImgBtnProd" runat="server" Height="100px" ImageUrl='<%# Eval("Imagen_Producto_PxP") %>' Width="100px" OnClick="ImgBtnProd_Click" />
                            <br />
                            <asp:Label ID="Nombre_Producto_PRLabel" runat="server" Text='<%# Eval("Nombre_Producto_PR") %>' />
                            <br />
                            $<asp:Label ID="PrecioUnitario_Producto_PxPLabel" runat="server" Text='<%# Eval("PrecioUnitario_Producto_PxP") %>' />
                            <br />
                        </td>
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
                </asp:ListView>
            </div>
            <div class="col-lg-2" style="background-color: crimson"></div>
        </div>

    </div>
</asp:Content>
