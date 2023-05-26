<%@ Page Title="projectsInfo" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="fullDataOfProjects.aspx.cs" Inherits="WebApplication3.account.fullDataOfProjects" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:Label Text="erfan" runat="server" />
            <br />
            <asp:Label Text="18" runat="server" />
            <br />
            <asp:Label Text="Male" runat="server" />
            <br />
        </div>
        <div>
            <asp:Button Text="Buy" runat="server" OnClick="btnBuy" />
        </div>
    </div>
</asp:Content>
