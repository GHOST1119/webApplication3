<%@ Page Title="applyFilter" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="WebApplication3.account.Projects" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:LinkButton Text="PlaceOrder" runat="server" OnClick="Lbtn_Click1" />
        <hr />
        <h1>show project</h1>
        <hr>
        <div class="panel panel-default">
            <div class="panel-heading">AllNames</div>
            <asp:Repeater ID="repeaterNames" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Name</th>
                                <th>Edit</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <th><%# Eval("ID")%></th>
                        <td><%# Eval("Name")%></td>
                        <td>Edit</td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>      
    </div>
</asp:Content>
