<%@ Page Title="Account Verify" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Verify.aspx.cs" Inherits="WebApplication3.account.Verify" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../content/Css/Account.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" id="form">
        <div>
            <p>The verification code has been sent! please check your email.</p>
            <input runat="server" type="text" name="myinput" class="verify-code" maxlength="6" minlength="6" placeholder="Enter the code" id="txtCode" onkeypress="return isNumber(event);" /><br />
            <asp:Button Style="margin-top: 10px; width: 150px; font-size: 1rem; background: #3cadd4; color: #ffffff;"
                ID="Button1" runat="server" Text="Verify" OnClick="btnVerify_Click" /><br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">didnt get the mail?<br />click here</asp:LinkButton>
        </div>
    </div>
    <script>
        function isNumber(e) {
            e = e || window.event;
            var charCode = e.which ? e.which : e.keyCode;
            return /\d/.test(String.fromCharCode(charCode));
        }
    </script>
</asp:Content>

