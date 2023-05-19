<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebApplication3.account.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../content/forgotPassword.css" rel="stylesheet" />
    <title>ForgotPassword</title>
</head>
<body>
    <div class="container" runat="server">

        <form runat="server">
            <img src="../../img/310-3105859_film-cinema-icon-png.png" alt="Logo" height="120px">
            <h2>Welcome</h2>
            <input id="txtEmail" type="email" placeholder="Email" required runat="server"><br />
            <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem;cursor: pointer; background: #3cadd4; color: #ffffff;"
                ID="Button1" runat="server" Text="Recovery" OnClick="btnRecovery_Click" /><br />
            <a href="Login.aspx">Login</a><br />
            <p>or</p>
            <a href="register.aspx">Register</a>
        </form>

    </div>
</body>
</html>
