<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="ApplyFilter.aspx.cs" Inherits="WebApplication3.account.ApplyFilter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>applyFilter</title>
    <link href="../content/bootstrap.min.css" rel="stylesheet" />
    <link href="../content/applyFilter.css" rel="stylesheet" />

</head>
<body>
    <form runat="server">
        <div class="container">
            <h2 class="name_profile">Test</h2>
            <input id="txtUserName" type="text" placeholder="User name" runat="server" /><br />
            <input id="txt_Age" type="search" class="form-control rounded" placeholder="Age" aria-label="Search" aria-describedby="search-addon" runat="server" /><br />
            <input id="txt_Gender" type="search" class="form-control rounded" placeholder="Gender" aria-label="Search" aria-describedby="search-addon" runat="server" /><br />
            <asp:Button Text="Filter" runat="server" OnClick="btnFilter" />
        </div>
        <br />
        <asp:LinkButton Text="CartPage" runat="server" OnClick="Lbtn_Click"/>
        <hr />

        <div>
            <asp:DataList align="Center" ID="DataList1" runat="server" DataKeyField="ID" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table style="border:2px solid gray">
                        <tr>
                            <td style="text-align: center; background-color: #5f98f3">
                                <asp:Label ID="Label1" Text='<%# Eval("ID") %>' runat="server" Font-Bold="True" Font-Names="Open Sans SemiBold" ForeColor="White" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; background-color: #5f98f3">
                                <asp:Label ID="Label2" Text='<%# Eval("Name") %>' runat="server" Font-Bold="True" Font-Names="Arial" ForeColor="White" Style="text-align: center" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; background-color: #5f98f3">
                                <asp:Label ID="Label3" Text='<%# Eval("Age") %>' runat="server" Font-Bold="True" Font-Names="Open Sans SemiBold" ForeColor="White" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; background-color: #5f98f3">
                                <asp:Label ID="Label4" Text='<%# Eval("Gender") %>' runat="server" Font-Bold="True" Font-Names="Open Sans SemiBold" ForeColor="White" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <asp:Button ID="btn1" Text="AddToCart" runat="server" Height="40px" Width="160px" CommandArgument='<%# Eval("ID") %>' CommandName="AddToCart"  />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>            
        </div>
    </form>




</body>
</html>
