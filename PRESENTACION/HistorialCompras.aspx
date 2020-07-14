<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="HistorialCompras.aspx.cs" Inherits="PRESENTACION.HistorialCompras" %>
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
                <asp:GridView ID="grdVentas" CssClass="Grid" runat="server" ShowHeader="False" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="grdVentas_PageIndexChanging" PageSize="2">
                    <Columns>
                        <asp:TemplateField HeaderText="CODIGO DE VENTA">
                            <ItemTemplate>
                                Codigo de venta: <asp:Label ID="lblCodVenta" runat="server" Text='<%# Bind("Cod_Venta_V") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="FECHA">
                            <ItemTemplate>
                                <asp:Label ID="lblFecha" runat="server" Text='<%# Bind("fVenta_V", "{0:d/M/yyyy}") %>'></asp:Label>                  
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="PRECIO TOTAL">
                            <ItemTemplate>
                                <h5>$<asp:Label ID="lblPrecio" runat="server" Text='<%# Bind("PrecioTotal") %>'></asp:Label></h5>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="VER DETALLE">
                            <ItemTemplate>           
                                <asp:Button ID="Button" class="btn btn-danger" runat="server" Text="VER DETALLE" OnClick="btnDetalle_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#FFFFFF" ForeColor="#FFFFFF" />
                    <RowStyle BackColor="White" ForeColor="#330099" />
                    <PagerStyle CssClass="pagination-ys" />
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
        <br />
        <br />
        <br />
        </div>

    </div>
</asp:Content>
