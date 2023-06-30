<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="WebApplication3.Defualt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="content/Css/home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="main">
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="img/1.gif" alt="Los Angeles" style="width: 100%;">
                </div>
                <div class="item">
                    <img src="img/2.gif" alt="Chicago" style="width: 100%;">
                </div>
                <div class="item">
                    <img src="img/3.jpg" alt="New york" style="width: 100%;">
                </div>
                <div class="item">
                    <img src="img/4.gif" alt="New york" style="width: 100%;">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
        <br />
        <br />
        <div class="products">
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod1.png" class="product__preview" alt="Apple iPhone 7">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Apple iPhone 7 32Gb Black</b></h3>
                    <p class="product__price"><b>439 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod2.png" class="product__preview" alt="Apple iPhone 8">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Apple iPhone 8 64Gb Gray</b></h3>
                    <p class="product__price"><b>569 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod3.png" class="product__preview" alt="Apple iPhone 5S">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Apple iPhone 5S 16Gb Gray</b></h3>
                    <p class="product__price"><b>689 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod4.png" class="product__preview" alt="Apple iPhone 8">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Apple iPhone 8 64Gb Gold</b></h3>
                    <p class="product__price"><b>599 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod5.png" class="product__preview" alt="Apple iPhone SE">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Apple iPhone SE 128Gb Gray</b></h3>
                    <p class="product__price"><b>898 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod6.png" class="product__preview" alt="Samsung Galaxy Note 8">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Samsung Galaxy Note 8 64Gb</b></h3>
                    <p class="product__price"><b>689 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod7.png" class="product__preview" alt="Samsung Galaxy S7">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Samsung Galaxy S7 4G 32Gb Black</b></h3>
                    <p class="product__price"><b>990 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod8.png" class="product__preview" alt="Samsung Galaxy A5">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Samsung Galaxy A5 (2017) 4G 32Gb Black</b></h3>
                    <p class="product__price"><b>930 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod9.png" class="product__preview" alt="Samsung Galaxy S8">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Samsung Galaxy S8 4G 64Gb Black</b></h3>
                    <p class="product__price"><b>790 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
            <article class="product">
                <div class="product__imgbox">
                    <img src="https://netology-code.github.io/mq-homeworks/adaptive-layout/product-list/img/prod10.png" class="product__preview" alt="Samsung Galaxy A5">
                </div>
                <div class="product__body">
                    <h3 class="product__name"><b>Samsung Galaxy A5 (2017) 4G 32Gb Gold</b></h3>
                    <p class="product__price"><b>840 $</b></p>
                </div>
                <div>
                    <button type="button" class="btn btn-success btn-block">Details</button>
                </div>
            </article>
        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
