<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.account.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <link href="../content/Css/profile.css" rel="stylesheet" />
    <!-- FontAwesome 5 -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.12.1/css/all.min.css" />
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
