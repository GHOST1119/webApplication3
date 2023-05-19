<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cartPage.aspx.cs" Inherits="WebApplication3.account.cartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="margin:0 auto">
            <h2 style="text-decoration: underline overline blink;color:#5f98f3">Your Order History</h2>
            <br />
            <asp:HyperLink ID="HyperLink1" Text="Continue Shopping" Font-Size="X-Large" Font-Bold="true"
                NavigateUrl="~/account/ApplyFilter.aspx" runat="server" />
            <br />
            <br />
            <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="False" BackColor="#CCFFFF" BorderWidth="5px" EmptyDataText="No Product Available" Height="260px" ShowFooter="True" Width="1100px" OnRowDeleting="Gridview1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" />
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" Text="Click" runat="server" BackColor="#CCFFFF" Font-Bold="True" Font-Size="Large" Height="46px" Width="115px" OnClick="Button1_Click" />
            <br />
            <hr />
            <br />
        </div>
        <div>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" DataKeyField="ID">
                <ItemTemplate>
                    <table style="border: 2px solid gray">
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
                    </table>

                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
