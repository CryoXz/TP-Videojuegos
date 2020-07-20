<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminVentas.aspx.cs" Inherits="PRESENTACION.AdminVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-md-10">
        <div class="container-fluid">
            <h3>Filtros de Ventas</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                    <asp:Label ID="Label1" runat="server" Text="Label">NOMBRE DE PRODUCTO</asp:Label>
                    &nbsp
                    <asp:TextBox ID="txtNombreBuscar" runat="server" Cssclass="rounded" pattern="[A-Za-z]*{1,30}" title="Solo se admiten Letras sin caracteres especiales. Tamaño mínimo: 1. Tamaño máximo: 30"></asp:TextBox>
                    &nbsp
                    <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" CssClass="btn btn-danger" OnClick="btnBuscar_Click1" />
                </div>
            </div>
            <br />
            <div class="row">
                
                 <asp:DropDownList ID="ddlPlataformas" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
                 &nbsp
                 <asp:DropDownList ID="ddlGeneros" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
                 &nbsp
                 <asp:DropDownList ID="ddlCategorias" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
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
        <hr />      
        <asp:GridView ID="grdVentas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Codigo">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Codigo" runat="server" Text='<%# Bind("Cod_Producto_DV") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre Producto">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("Nombre_Producto_PR") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Categoria">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Categoria" runat="server" Text='<%# Bind("nombre_categoria_C") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Plataforma">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Plataforma" runat="server" Text='<%# Bind("Nombre_Plataforma_P") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Genero">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Genero" runat="server" Text='<%# Bind("Nombre_Genero_G") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Vendidos">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Vendidos" runat="server" Text='<%# Bind("Vendidos") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha Venta">
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_FechaVenta" runat="server" Text='<%# Bind("fVenta_V") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#dc3545" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#dc3545" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
      </div>
</asp:Content>
