<%@ Page Title="Escaping" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Escaping.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls.Escaping" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div>
            <p>
                <asp:Label ID="EnterTextLabel" runat="server" Text="Enter text: "></asp:Label>
                <asp:TextBox ID="EnterText" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="Fill" runat="server" Text="Visualize the entered text into the down label." OnClick="Fill_Click" />
            <p>
                <asp:Label ID="SecondLabel" runat="server" Text="The entered text was: "></asp:Label>
                <asp:Literal ID="Literal" runat="server" Mode="Encode" Text="No text yet!"></asp:Literal>
            </p>
        </div>
    </div>
</asp:Content>
