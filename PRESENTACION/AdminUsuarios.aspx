﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminUsuarios.aspx.cs" Inherits="PRESENTACION.AdminUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="col-md-10">
        <div class="container">
            <h3>Filtros Usuarios</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                    <asp:Label ID="lblNombreUsuario" runat="server" Text="Label">NOMBRE DE USUARIO</asp:Label>
                    &nbsp                
                    <asp:TextBox ID="txtBuscarNombre" runat="server" placeholder="Nombre o Apellido" CssClass="rounded" ></asp:TextBox>
                    &nbsp
                    <asp:Button ID="btnBuscar" runat="server" Text="BUSCAR" CssClass="btn btn-danger" OnClick="btnBuscar_Click" />
                    &nbsp
                    <asp:Label ID="lblFiltrarPor" runat="server" Text="Label">FILTRAR POR:</asp:Label>
                    &nbsp
                    <asp:DropDownList ID="ddlTipoUsuario" runat="server" CssClass="btn btn-danger"></asp:DropDownList>
                    &nbsp
                    <asp:Button ID="btnFiltrar" runat="server" Text="FILTRAR" CssClass="btn btn-danger" OnClick="btnFiltrar_Click" />
                </div>
            </div>
        </div>
        <hr />
        <div>
            <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:TemplateField HeaderText="Codigo">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Codigo" runat="server" Text='<%# Bind("Cod_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tipo">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Tipo" runat="server" Text='<%# Bind("Nombre_TipoUsuario_TU") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Bind("Nombre_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apellido">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Bind("Apellido_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dni">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Dni" runat="server" Text='<%# Bind("DNI_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Telefono">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("Telefono_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="E-mail">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("EMail_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Direccion">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Bind("Direccion_Usuario_U") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:CheckBox ID="chk_it_Estado" runat="server" Checked='<%# Bind("Estado_Usuario_U") %>' Text="Activo" Enabled="False" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#dc3545" ForeColor="White" Font-Bold="True" />
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



    </div>
</asp:Content>
