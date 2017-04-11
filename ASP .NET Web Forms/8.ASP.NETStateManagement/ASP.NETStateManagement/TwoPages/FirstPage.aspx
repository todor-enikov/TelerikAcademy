<%@ Page Language="C#" Title="First" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="ASP.NETStateManagement.TwoPages.FirstPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <asp:Button ID="Log" runat="server" Text="Log user!" OnClick="Log_Click" />
    </div>
</asp:Content>
