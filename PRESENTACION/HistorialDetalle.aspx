<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="HistorialDetalle.aspx.cs" Inherits="PRESENTACION.HistorialDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Carrito.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <h2 style="color:white;text-align:center">HISTORIAL DE COMPRAS</h2>
        <br />
        <div class="main row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-8" style="background-color:white">
                <div class="container">   
                    <asp:GridView ID="grdDetalle" CssClass="Grid" runat="server" ShowHeader="False" AutoGenerateColumns="False">
                    <Columns>
                        
                        <asp:TemplateField HeaderText="IMAGEN">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Imagen_Producto_PxP") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="NOMBRE">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PLATAFORMA">
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Plataforma") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="CANTIDAD">
                            <ItemTemplate>
                                Cantidad: <asp:Label ID="Label3" runat="server" Text='<%# Bind("Cantidad") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRECIOTOTAL">
                            <ItemTemplate>
                                $<asp:Label ID="Label4" runat="server" Text='<%# Bind("PrecioTotal", "{0:0.00}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                    </Columns>
                    <FooterStyle BackColor="#FFFFFF" ForeColor="#FFFFFF" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                </asp:GridView>
                </div>
            </div>
            <div class="col-lg-2" style="background-color:crimson"></div>
        </div>   
        
        <div class="row" style="background-color:crimson">
        <div class="col-lg-2" style="background-color:crimson"></div>
        <div class="col-lg-8" style="background-color:white;text-align:center">
        <br />
        <a ID="btnHome" runat="server" class="btn btn-danger" href="HistorialCompras.aspx">VOLVER</a>
        <br />
        <br />
        </div>
        <div class="col-lg-2" style="background-color:crimson"></div>
        </div>
        <div class="row" style="background-color:crimson">
            <br />
            <br />
            <br />
        </div>

    </div>
</asp:Content>
