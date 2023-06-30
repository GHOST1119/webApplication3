<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication3.account.Register" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../content/Css/Account.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <div class="container" id="form">
            <img src="../../img/310-3105859_film-cinema-icon-png.png" alt="Logo">
            <h2>Welcome</h2>
            <input id="txtUserName" type="text" placeholder="User name" runat="server"><br />
            <input id="txtEmail" type="email" placeholder="Email" required runat="server"><br />
            <input id="txtPassword" type="password" placeholder="Password" required runat="server"><br />
            <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem; cursor: pointer; background-color: #3cadd4; color: #ffffff;"
                runat="server" Text="Register" OnClick="btnRegister_Click" /><br />
            <a href="login.aspx">Also have accont? Sign in</a>
        </div>
</asp:Content>
