<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="WebApplication3.account.Verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../content/Verify.css" rel="stylesheet" />
    <title>Account Verify</title>
</head>
<body>
    <body>
        <div class="container" runat="server">

            <form runat="server">
                <p>The verification code has been sent! please check your email.</p>
                <input runat="server" type="text" name="myinput" class="verify-code" maxlength="6" minlength="6" placeholder="Enter the code" id="txtCode" onkeypress="return isNumber(event);"><br />
                <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem; background: #3cadd4; color: #ffffff;"
                    ID="Button1" runat="server" Text="Verify" OnClick="btnVerify_Click" /><br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">didnt get the mail?<br />click here</asp:LinkButton>
            </form>

        </div>
        <script>
            function isNumber(e) {
                e = e || window.event;
                var charCode = e.which ? e.which : e.keyCode;
                return /\d/.test(String.fromCharCode(charCode));
            }
        </script>
    </body>
</body>
</html>
