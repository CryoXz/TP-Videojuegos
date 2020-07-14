<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CarritoConfirmar.aspx.cs" Inherits="PRESENTACION.CarritoConfirmar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <br />
        <div class="main row">
            <div class="col-lg-4" style="background-color:crimson"></div>
            <div class="col-lg-4" style="background-color:white">
                <br />
                <h2 style="color:crimson;text-align:left">Total de la compra: $<%=this.Session["PrecioTotal"] %></h2>
                <br />
                <br />
                <h5 style="color:crimson;text-align:left">Seleccione tipo de pago: <asp:DropDownList ID="ddlTipoPago" runat="server"> 
                                    <asp:ListItem Value="TP1">Efectivo</asp:ListItem>
                                    <asp:ListItem Value="TP2">Tarjeta de Debito</asp:ListItem>
                                    <asp:ListItem Value="TP3">Tarjeta de Credito</asp:ListItem>
                                </asp:DropDownList></h5>
                <br />
                <br />
                <br />
            </div>
            <div class="col-lg-4" style="background-color:crimson"></div>
        </div>
        <div class="row">
            <div class="col-lg-4"></div>
            <div class="col-lg-4" style="text-align:center;background-color:white">
                <asp:Button ID="btnComprar" runat="server" class="btn btn-danger" Text="CONFIRMAR COMPRA"  OnClick="btnComprar_Click" />
                <br />
                <br />
            </div>
            <div class="col-lg-4"></div>
        </div>
        <br />
        <br />
        <br />

    </div>
</asp:Content>
