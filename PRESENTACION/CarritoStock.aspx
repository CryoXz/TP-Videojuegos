<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CarritoStock.aspx.cs" Inherits="PRESENTACION.CarritoStock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="background-color:crimson">
        <br />
        <br />
        <br />
        <div class="main row">
            <div class="col-lg-4" style="background-color:crimson"></div>
            <div class="col-lg-4" style="text-align:center;background-color:crimson">
                <h4 style="color:white">No hay stock suficiente vuelva a intentarlo.</h4>
            </div>
            <div class="col-lg-4" style="background-color:crimson"></div>
        </div>
        <br />
        <br />
        <br />
        <div class="row">
            <div class="col-lg-4"></div>
            <div class="col-lg-4" style="text-align:center;background-color:crimson">
                <a ID="btnHome" runat="server" class="btn btn-warning" href="Home.aspx">VOLVER AL HOME</a>
                
            </div>
            <div class="col-lg-4"></div>
        </div>
        <br />
        <br />
        <br />

    </div>
</asp:Content>
