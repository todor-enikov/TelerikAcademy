<%@ Page Language="C#" Title="Javascript" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Javascript.aspx.cs" Inherits="ASP.NETStateManagement.Javascript" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
        <asp:Button ID="ViewState" runat="server" Text="Click to delete the viewstate!" OnClick="ViewState_Click" />
        <asp:Label ID="View" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

