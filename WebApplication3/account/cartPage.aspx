<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cartPage.aspx.cs" Inherits="WebApplication3.account.cartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Gridview1" runat="server" AutoGenerateColumns="False" BackColor="#CCFFFF" BorderWidth="5px" EmptyDataText="No Product Available" Height="260px" ShowFooter="True" Width="1100px">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Age" HeaderText="Age" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="Button1" Text="Click" runat="server" />
        </div>
    </form>
</body>
</html>
