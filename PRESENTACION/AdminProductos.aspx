﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProductos.aspx.cs" Inherits="PRESENTACION.AdminProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-lg-10">
        <div class="container">
            <h3>Productos</h3>
            <hr />
            <div class="row">
                <div class="col-lg-2">
                    <asp:Button class="btn btn-danger" ID="btnAgregar" runat="server" Text="Agregar Producto" OnClick="btnAgregar_Click" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="form-inline">
                    <asp:Label ID="lblBuscarProducto" runat="server" Text="Label">NOMBRE DE PRODUCTO A BUSCAR: </asp:Label>
                    &nbsp
                    <asp:TextBox ID="txtNombreBuscar" runat="server" CssClass="rounded"></asp:TextBox>
                    &nbsp
                    <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" CssClass="btn btn-danger" OnClick="btnBuscar_Click1" />
                </div>
            </div>
            <hr />     
            <div class="row">
                    <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Plataformas</button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Nintendo Switch</a>
                        <a class="dropdown-item" href="#">Nintendo 3ds</a>
                        <a class="dropdown-item" href="#">Playstation 3</a>
                        <a class="dropdown-item" href="#">Playstation 4</a>
                        <a class="dropdown-item" href="#">PS Vita</a>
                        <a class="dropdown-item" href="#">Xbox 360</a>
                        <a class="dropdown-item" href="#">Xbox One</a>
                        <a class="dropdown-item" href="#">Pc</a>
                    </div>
                </div>
            &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Categorias
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Video Juego</a>
                        <a class="dropdown-item" href="#">Accesorio</a>
                    </div>
                </div>
            &nbsp
                <div class="dropdown">
                    <button class="btn btn-danger dropdown-toggle" type="button" id="dropdownMenuButton3" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Marcas
                    </button>
                    <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
                        <a class="dropdown-item" href="#">Nintendo</a>
                        <a class="dropdown-item" href="#">Sony</a>
                        <a class="dropdown-item" href="#">Logitech</a>
                        <a class="dropdown-item" href="#">Microsoft</a>
                    </div>
                </div>
            </div>            
        </div>
        <br />
        <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="1173px" OnRowCancelingEdit="grdProductos_RowCancelingEdit" OnRowDataBound="grdProductos_RowDataBound" OnRowDeleting="grdProductos_RowDeleting" OnRowEditing="grdProductos_RowEditing" OnRowUpdating="grdProductos_RowUpdating" OnPageIndexChanging="grdProductos_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Código">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_codigo" runat="server" Text='<%# Bind("Codigo") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Codigo" runat="server" Text='<%# Bind("Codigo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_nombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Descripción">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_descripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Descripcion" runat="server" Text='<%# Bind("Descripcion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Marca">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_marca" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Marca" runat="server" Text='<%# Bind("NombreMarca") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Categoría">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_categoria" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Categoria" runat="server" Text='<%# Bind("NombreCategoria") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Género">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddl_eit_genero" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Genero" runat="server" Text='<%# Bind("NombreGenero") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de Publicación">
                    <EditItemTemplate>
                        <asp:TextBox ID="lbl_eit_FPublicacion" runat="server" Text='<%# Bind("FPublicacion") %>' TextMode="DateTime"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_FPublicacion" runat="server" Text='<%# Bind("FPublicacion") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio Unitario">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_PrecioUnitario" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnitario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_stock" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Stock" runat="server" Text='<%# Bind("Stock") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Estado">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Estado") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#999999" />
            <FooterStyle BackColor="#dc3545" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#dc3545" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#cd3545" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>  

</asp:Content>
