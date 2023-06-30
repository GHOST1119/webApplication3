<%@ Page Title="ForgotPassword" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebApplication3.account.ForgotPassword" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../content/Css/Account.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" id="form">
        <img src="../../img/310-3105859_film-cinema-icon-png.png" alt="Logo" height="120px">
        <h2>Welcome</h2>
        <input id="txtEmail" type="email" placeholder="Email" required runat="server"><br />
        <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem; cursor: pointer; background: #3cadd4; color: #ffffff;"
            ID="Button1" runat="server" Text="Recovery" OnClick="btnRecovery_Click" /><br />
        <a href="Login.aspx">Login</a><br />
        <p>or</p>
        <a href="register.aspx">Register</a>
    </div>
</asp:Content>
