<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PRESENTACION.Home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid" style="background-color:ghostwhite">
        <br />
        <div class="main row">
            <div class="col-lg-2" style="background-color:crimson"></div>
            <div class="col-lg-8" style="background-color:ghostwhite">
                <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                  <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                  </ol>
                  <div class="carousel-inner">
                    <div class="carousel-item active">
                      <img class="d-block w-100" src="IMAGES/codmw-poster.jpg" alt="Call of Duty: Modern Warfare">
                    </div>
                    <div class="carousel-item">
                      <img class="d-block w-100" src="IMAGES/fifa20-poster.png" alt="FIFA 2020">
                    </div>
                    <div class="carousel-item">
                      <img class="d-block w-100" src="IMAGES/daysgone-poster.jpg" alt="Days Gone">
                    </div>
                  </div>
                  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                  </a>
                  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                  </a>
                </div>
            </div>
            <div class="col-lg-2" style="background-color:crimson"></div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-12 text-center" style="background-color:ghostwhite">
                <h1>Descubrí las mejores ofertas en juegos para tu consola preferida</h1>
            </div>
        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <a href="ProductosJuegos.aspx?plat=pf7"><img src="IMAGES/xboxlogo.png" alt="XBOX" style="width:250px;height:250px;"></a>
            </div>
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <a href="ProductosJuegos.aspx?plat=pf4"><img src="IMAGES/ps4logo.png" alt="PS4" style="width:250px;height:250px;"></a>
            </div>
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <a href="ProductosJuegos.aspx?plat=pf1"><img src="IMAGES/switchlogo.png" alt="Nintendo Switch" style="width:250px;height:250px;"></a>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <b>Ofertas de XBOX ONE</b>
            </div>
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <b>Ofertas de PLAYSTATION 4</b>
            </div>
            <div class="col-lg-4 text-center" style="background-color:ghostwhite">
                <b>Ofertas de NINTENDO SWITCH</b>
            </div>
        </div>
        <br />
        <br />
    </div>

</asp:Content>
