<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminGenero.aspx.cs" Inherits="PRESENTACION.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="col-md-10">
        <div class="container">
            <h3>Agregar Nuevo Género</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                   <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del nuevo género:"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                   
                    &nbsp;&nbsp;
                   
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-danger" OnClick="btnAgregar_Click" />
                </div>
            </div>
        </div>
        <br />
        <h3>Generos</h3>

        <div class="col-lg-2">
            <asp:GridView ID="grdGeneros" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="grdGeneros_RowCancelingEdit" OnRowDeleting="grdGeneros_RowDeleting" OnRowEditing="grdGeneros_RowEditing" OnRowUpdating="grdGeneros_RowUpdating" AllowPaging="True" OnPageIndexChanging="grdGeneros_PageIndexChanging" Width="498px" PageSize="5">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Código">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_codigo" runat="server" Text='<%# Bind("Cod_Genero_G") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_codigo" runat="server" Text='<%# Bind("Cod_Genero_G") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_eit_nombre" runat="server" Text='<%# Bind("Nombre_Genero_G") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_nombre" runat="server" Text='<%# Bind("Nombre_Genero_G") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#CC0000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView> 

        </div>

         </div>



</asp:Content>