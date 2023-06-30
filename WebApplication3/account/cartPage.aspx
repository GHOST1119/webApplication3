<%@ Page Title="cartPage" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="cartPage.aspx.cs" Inherits="WebApplication3.account.cartPage" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div align="center" style="margin: 0 auto">
            <h2 style="text-decoration: underline overline blink; color: #5f98f3">Your Order History</h2>
            <br />
            <asp:HyperLink ID="HyperLink1" Text="Continue Shopping" Font-Size="X-Large" Font-Bold="true"
                NavigateUrl="AllProjects.aspx" runat="server" />
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
    </div>
</asp:Content>