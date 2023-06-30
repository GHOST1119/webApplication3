<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AllProjects.aspx.cs" Inherits="WebApplication3.account.AllProjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-sm-9" style="background-color: lavenderblush; margin-bottom: 20px">
        <asp:DataList align="Center" ID="DataList2" runat="server" DataKeyField="ID" OnItemDataBound="DataList2_ItemDataBound">
            <ItemTemplate>
                <table style="border: 2px solid gray">
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
                            <asp:Button ID="myButton1" runat="server" Text="ShowFullData" Height="40px" Width="160px" CommandArgument='<%# Eval("ID") %>' />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
    <div class="col-sm-3" style="background-color: lightgray; margin-bottom: 20px">
        <h2 class="name_profile">Test</h2>
        <asp:TextBox ID="txtUser" placeholder="User name" Style="margin-bottom:10px" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtAge" placeholder="Age" Style="margin-bottom:10px" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtGender" placeholder="Gender" Style="margin-bottom:10px" runat="server"></asp:TextBox><br />
        <asp:Button Text="Filter" Style="margin-bottom:10px" runat="server" OnClick="btnFilter" />
    </div>
    <br />
</asp:Content>
