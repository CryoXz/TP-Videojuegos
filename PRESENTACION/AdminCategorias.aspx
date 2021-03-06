﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminCategorias.aspx.cs" Inherits="PRESENTACION.AdminCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="col-md-10">
        <div class="container">
            <h3>Agregar Nueva Categoría</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                    <asp:Label ID="lblNombreCtegoria" runat="server" Text="INGRESE EL NOMBRE DE LA NUEVA CATEGORIA:"></asp:Label>
                    &nbsp
                    <asp:TextBox ID="txtNombreCategoria" runat="server" CssClass="rounded"></asp:TextBox>                   
                   &nbsp;
                    <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR" CssClass="btn btn-danger" OnClick="btnAgregar_Click" />
                </div>
            </div>
        </div>
         <hr />
        
        <h3>Categorías</h3>

        <div class="col-lg-2">
            <asp:GridView ID="grdCategorias" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="grdCategorias_RowCancelingEdit" OnRowDeleting="grdCategorias_RowDeleting" OnRowEditing="grdCategorias_RowEditing" OnRowUpdating="grdCategorias_RowUpdating" AllowPaging="True" OnPageIndexChanging="grdCategorias_PageIndexChanging" Width="498px" PageSize="3" >
    <EmptyDataTemplate>
        There are currently no items in this table.
    </EmptyDataTemplate>
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField HeaderText="Código">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_codigoCategoria" runat="server" Text='<%# Bind("Cod_Categoria_C") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_eit_codigoCategoria" runat="server" Text='<%# Bind("Cod_Categoria_C") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_nombreCategoria" runat="server" Text='<%# Bind("Nombre_Categoria_C") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_nombreCategoria" runat="server" Text='<%# Bind("Nombre_Categoria_C") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                                  <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#999999" />
                <FooterStyle BackColor="#dc3545" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#dc3545" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#dc3545" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView> 

        </div>

         </div>

</asp:Content>
