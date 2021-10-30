<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.account.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../content/Login.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <div class="container">

        <form runat="server">
            <img src="../../img/310-3105859_film-cinema-icon-png.png" alt="Logo" height="120px">
            <h2>Welcome</h2>
            <input id="txtEmail" type="email" placeholder="Email" required runat="server"><br />
            <input id="txtPassword" type="password" placeholder="Password" required runat="server"><br />
            <asp:Button Style="background-color: #3cadd4; color: #fff !important; padding: 10px 20px; border: 0; border-radius: 30px; font-size: 1.3vw; cursor: pointer; text-align: center; color: #ffffff;"
                ID="Button1" runat="server" Text="SignIn" OnClick="btnLogin_Click" /><br />
            <a href="ForgotPassword.aspx">Forgot password?</a><br />
            <a href="register.aspx">Register</a>
        </form>
    </div>
</body>
</html>
