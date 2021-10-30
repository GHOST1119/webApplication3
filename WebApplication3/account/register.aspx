<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication3.account.WebForm1" %>

<!DOCTYPE html>
<html lang="en" runat="server">

<head>
    <link href="../content/register.css" rel="stylesheet" />
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Register</title>
</head>

<body>


    <div class="container">

        <form runat="server">
            <img src="../../img/310-3105859_film-cinema-icon-png.png" alt="Logo" height="120px">
            <h2>Welcome</h2>
            <input id="txtUserName" type="text" placeholder="User name" runat="server"><br />
            <input id="txtEmail" type="email" placeholder="Email" required runat="server"><br />
            <input id="txtPassword" type="password" placeholder="Password" required runat="server"><br />
            <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem; background-color: #3cadd4; color: #ffffff;"
                runat="server" Text="Register" OnClick="btnRegister_Click" /><br />
            <a href="login.aspx">Also have accont? Sign in</a>
        </form>

    </div>


</body>

</html>

