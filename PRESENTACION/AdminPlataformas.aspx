﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminPlataformas.aspx.cs" Inherits="PRESENTACION.AdminPlataformas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-10">
        <div class="container">
            <h3>Agregar Nueva Plataforma</h3>
            <hr />
            <div class="row">
                <div class="form-inline">
                    <input class="form-control mr-sm-2" type="search" placeholder="Nombre Plataforma" aria-label="Search">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>     
        <br />
        <h3>Plataformas</h3>
        <table class="table">
            <caption>List of users</caption>
            <thead>
                <tr>
                    <th scope="col">Codigo</th>
                    <th scope="col">Nombre</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Nintendo Switch</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Nintendo 3ds</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Playstation 3</td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>Playstation 4</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>PS Vita</td>
                </tr>
            </tbody>
        </table>
    </div>          
</asp:Content>
