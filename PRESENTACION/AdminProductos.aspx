﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminProductos.aspx.cs" Inherits="PRESENTACION.AdminProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                        <asp:DropDownList ID="ddlPlataformas" runat="server" AutoPostBack="True" CssClass="btn btn-danger">
                        </asp:DropDownList>
                </div>
            &nbsp
                <div class="dropdown">
                    <asp:DropDownList ID="ddlCategorias" runat="server" AutoPostBack="True" CssClass="btn btn-danger">
                    </asp:DropDownList>
                </div>
            &nbsp
                <div class="dropdown">
                        <asp:DropDownList ID="ddlGeneros" runat="server" AutoPostBack="True" CssClass="btn btn-danger" >
                        </asp:DropDownList>
                </div>
                     &nbsp   
                <asp:Label ID="lbldesde" runat="server" Text="Label">DESDE:</asp:Label> 
                                 &nbsp                  
                <asp:TextBox ID = "TxtFechaInicio" runat="server" TextMode="Date" CssClass="btn btn-danger"></asp:TextBox>           
                 &nbsp   
                <asp:Label ID="LblHasta" runat="server" Text="Label">HASTA:</asp:Label> 
                 
                 <asp:TextBox ID = "TxtFechaFin" runat="server" TextMode="Date" CssClass="btn btn-danger"></asp:TextBox>
                 &nbsp
                 <asp:Button ID="btnFiltrar" runat="server" Text="FILTRAR" CssClass="btn btn-danger" OnClick="btnFiltrar_Click" />
                &nbsp         
                   <asp:Button ID="btnQuitarFiltro" runat="server" Text="QUITAR FILTRO" CssClass="btn btn-danger" OnClick="btnQuitarFiltro_Click" />
            </div>            
        </div>
        <br />
        <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="1173px" OnRowCancelingEdit="grdProductos_RowCancelingEdit" OnRowDataBound="grdProductos_RowDataBound" OnRowDeleting="grdProductos_RowDeleting" OnRowEditing="grdProductos_RowEditing" OnRowUpdating="grdProductos_RowUpdating" OnPageIndexChanging="grdProductos_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" PageSize="5" OnDataBound="grdProductos_DataBound">
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
                        <asp:HiddenField ID="hfMarcaId" runat="server" Value='<%# Bind("CodMarca") %>' />
                        <asp:DropDownList ID="ddl_eit_marca" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Marca" runat="server" Text='<%# Bind("NombreMarca") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Categoría">
                    <EditItemTemplate>
                        <asp:HiddenField ID="hfCategoriaId" runat="server" Value='<%# Bind("CodCategoria") %>' />
                        <asp:DropDownList ID="ddl_eit_categoria" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Categoria" runat="server" Text='<%# Bind("NombreCategoria") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Género">
                    <EditItemTemplate>
                        <asp:HiddenField ID="hfGeneroId" runat="server" Value='<%# Bind("CodGenero") %>' />
                        <asp:DropDownList ID="ddl_eit_genero" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Genero" runat="server" Text='<%# Bind("NombreGenero") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Plataforma">
                    <EditItemTemplate>
                        <asp:HiddenField ID="hfPlataformaId" runat="server" Value='<%# Bind("CodPlataforma") %>' />
                        <asp:DropDownList ID="ddl_eit_plataforma" runat="server">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Plataforma" runat="server" Text='<%# Bind("NombrePlataforma") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de Publicación">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_FPublicacion" runat="server" Text='<%# Bind("FPublicacion", "{0:d/M/yyy}") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_FPublicacion" runat="server" Text='<%# Bind("FPublicacion", "{0:d/M/yyy}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Precio Unitario">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnitario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnitario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Stock" runat="server" Text='<%# Bind("Stock") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Stock" runat="server" Text='<%# Bind("Stock") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="URL Imagen">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Imagen" runat="server" Text='<%# Bind("ImgURL") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Imagen" runat="server" Text='<%# Bind("ImgURL") %>'></asp:Label>
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
