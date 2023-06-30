<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebApplication3.account.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link href="../content/Css/profile.css" rel="stylesheet" />
    <!-- FontAwesome 5 -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.1/css/all.min.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="title">
        <h1>Profile</h1>
    </div>
    <br />
    <br />
    <br />
    <!-- Main -->
    <div class="main">
        <h2>Your Information</h2>
        <div class="card">
            <div class="card-body">
                <i class="fa fa-pen fa-xs edit"></i>
                <table>
                    <tbody>
                        <tr>
                            <td>Name :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>Landline Phone :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>Address :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>Person Type :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>Company Name :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                        <tr>
                            <td>Activity Field :</td>
                            <td>
                                <asp:Label Text="text" runat="server" /></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <!-- End -->
    <%--<br />
    <div>
        <img src="../img/favorite.png" class="img-circle" alt="Cinque Terre" width="204" height="136"><br />
        <asp:Label Text="Your Image" runat="server" />
        <asp:FileUpload ID="FileUpload1" class="form-control rounded" runat="server" Multiple="true" /><br />
        <asp:Button ID="btnSendImage" Text="Send" runat="server" OnClick="btnSendImage_Click" />
        <asp:Label ID="lblSelectPhoto" runat="server" />
    </div>--%>
</asp:Content>
