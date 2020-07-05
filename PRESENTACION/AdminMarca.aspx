﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminMarca.aspx.cs" Inherits="PRESENTACION.Formulario_web13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-10">
        <%--<div class="row">--%>
        <div class="container">
            <h3>Marcas</h3>
            <hr />            
            <div class="row">
                <div class="col-lg-2">
                    <asp:Button class="btn btn-danger" ID="btnAgregarMarca" runat="server" Text="AGREGAR MARCA" OnClick="btnAgregar_Click" />
                </div>
            </div>
            <br />
            <div class="form-inline">
                <asp:Label ID="lblBuscarMarca" runat="server" Text="INGRESE NOMBRE DE MARCA A BUSCAR: "></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtNombreMarca" runat="server" CssClass="rounded"></asp:TextBox>
                &nbsp;
                <asp:Button ID="btnAceptar" class="btn btn-danger"  runat="server" Text="BUSCAR" OnClick="btnAceptar_Click" />
            </div>
                     
        </div>
     <hr /> 

    <div class="col-lg-2">
        <asp:GridView ID="grdMarcas" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnPageIndexChanging="grdMarcas_PageIndexChanging" OnRowCancelingEdit="grdMarcas_RowCancelingEdit" OnRowDeleting="grdMarcas_RowDeleting" OnRowEditing="grdMarcas_RowEditing" OnRowUpdating="grdMarcas_RowUpdating" Height="308px" Width="917px" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Código">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_eit_Codigo" runat="server" Text='<%# Bind("Cod_Marca_M") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Codigo" runat="server" Text='<%# Bind("Cod_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_nombre" runat="server" Text='<%# Bind("Nombre_Marca_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_nombre" runat="server" Text='<%# Bind("Nombre_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Contacto">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_contacto" runat="server" Text='<%# Bind("Nombre_Contacto_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_contacto" runat="server" Text='<%# Bind("Nombre_Contacto_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Dirección">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_direccion" runat="server" Text='<%# Bind("Direccion_Marca_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_direccion" runat="server" Text='<%# Bind("Direccion_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ciudad">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_ciudad" runat="server" Text='<%# Bind("Ciudad_Marca_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Ciudad" runat="server" Text='<%# Bind("Ciudad_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Teléfono">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_Telefono" runat="server" Text='<%# Bind("Telefono_Marca_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Bind("Telefono_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_eit_email" runat="server" Text='<%# Bind("Email_Marca_M") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Email" runat="server" Text='<%# Bind("Email_Marca_M") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#999999" />
            <FooterStyle BackColor="#dc3545" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#dc3545" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="#330099" HorizontalAlign="Center" />
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
