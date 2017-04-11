<%@ Page Language="C#" Title="Appends" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppendsTheInputOfAText.aspx.cs" Inherits="ASP.NETStateManagement.AppendsTheInputOfAText" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="well">
        <div>
            <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonForTheTextBox" runat="server" Text="Go !" OnClick="ButtonForTheTextBox_Click" />
        </div>
        <asp:Label ID="Result" runat="server" Text="Result is: "></asp:Label>

    </div>
</asp:Content>
