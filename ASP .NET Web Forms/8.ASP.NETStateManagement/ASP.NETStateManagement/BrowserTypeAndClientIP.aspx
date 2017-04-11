<%@ Page Language="C#" Title="Browser and IP" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BrowserTypeAndClientIP.aspx.cs" Inherits="ASP.NETStateManagement.BrowserTypeAndClientIP" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Browser: "></asp:Label>
            <asp:Label ID="BrowserType" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Ip address of the client: "></asp:Label>
            <asp:Label ID="IpAddress" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
