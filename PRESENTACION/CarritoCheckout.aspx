﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="CarritoCheckout.aspx.cs" Inherits="PRESENTACION.CarritoCheckout" %>
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
                <br />
                <br />
                <h2 style="color:crimson;text-align:center">Muchas Gracias por su compra!</h2>
                <br />
                <br />
                <br />
            </div>
            <div class="col-lg-4" style="background-color:crimson"></div>
        </div>
        <div class="row">
            <div class="col-lg-4"></div>
            <div class="col-lg-4" style="text-align:center;background-color:white">
                <a ID="btnHome" runat="server" class="btn btn-danger" href="Home.aspx">VOLVER AL HOME</a>
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
