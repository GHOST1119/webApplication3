<%@ Page Title="projectsInfo" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="fullDataOfProjects.aspx.cs" Inherits="WebApplication3.account.fullDataOfProjects" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link href="../content/Css/showData.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:DataList ID="fullDataDataList" runat="server" OnItemDataBound="fullDataDataList_ItemDataBound">
        <ItemTemplate>
            <section class="container">

                <div class="row">
                    <div class="col-sm-4" id="ProductImg">
                        <div id="product-img">
                            <img src="../img/dark_tint.png" alt="Nike Roshe Run - Mint Green"
                                title="Nike Roshe Run - Mint Green" class="shoe fade-in one" />
                        </div>
                    </div>
                    <div class="col-sm-8" id="ProductInfo">
                        <div id="product-info" >
                            <div id="product-spec" class="wrapper">
                                <h1>Nike Roshe Run</h1>
                                <h3>150</h3>
                            </div>
                            <h4 class="clearfix">Description</h4>
                            <p id="aboutProduct">
                                With a highly breathable upper and casual silouette
                            </p>

                            <div id="product-options" class="clearfix-auto">
                                <div id="color" class="wrapper">
                                    <h4 class="">Color</h4>
                                    <div>
                                        <input type="radio" name="radio" id="radio1" class="radio" checked />
                                        <label for="radio1">&nbsp;</label>
                                    </div>

                                    <div>
                                        <input type="radio" name="radio" id="radio2" class="radio" />
                                        <label for="radio2">&nbsp;</label>
                                    </div>

                                    <div>
                                        <input type="radio" name="radio" id="radio3" class="radio" />
                                        <label for="radio3">&nbsp;</label>
                                    </div>

                                    <div>
                                        <input type="radio" name="radio" id="radio4" class="radio" />
                                        <label for="radio4">&nbsp;</label>
                                    </div>

                                    <div>
                                        <input type="radio" name="radio" id="radio5" class="radio" />
                                        <label for="radio5">&nbsp;</label>
                                    </div>
                                </div>
                                <div id="quantity" class="wrapper">
                                    <h4>Qty</h4>
                                    <span class="arr"></span>
                                    <select>
                                        <option value="quantity-1">(1)</option>
                                        <option value="quantity-2">(2)</option>
                                        <option value="quantity-3">(3)</option>
                                        <option value="quantity-4">(4)</option>
                                        <option value="quantity-5">(5)</option>
                                        <option value="quantity-6">(6)</option>
                                        <option value="quantity-7">(7)</option>
                                        <option value="quantity-8">(8)</option>
                                    </select>
                                </div>
                            </div>
                            <a href="#" title="Add to cart" class="button">
                                <i class="bi bi-cart"></i>
                                Add to cart</a>
                        </div>
                    </div>
                </div>
            </section>
            <asp:Label ID="Label1" Text='<%# Eval("Name") %>' runat="server" />
            <br />
            <asp:Label ID="Label2" Text='<%# Eval("Age") %>' runat="server" />
            <br />
            <asp:Label ID="Label3" Text='<%# Eval("Gender") %>' runat="server" /><br />
        </ItemTemplate>
    </asp:DataList>
    <div style="margin-bottom: 20px">
        <asp:Button ID="btn1" Text="Buy" runat="server" OnClick="btnBuy" />
        <asp:Label ID="lblShowError" runat="server" />
    </div>
</asp:Content>
