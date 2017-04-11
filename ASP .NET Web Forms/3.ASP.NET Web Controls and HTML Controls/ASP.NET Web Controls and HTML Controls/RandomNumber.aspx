<%@ Page Title="Random Number" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RandomNumber.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls.RandomNumber" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div>
            <h1>With HTML server cotrols.</h1>
            <div>
                <input type="text" id="firstNumber" runat="server" />
                <input type="text" id="secondNumber" runat="server" />
                <button id="button" runat="server" onserverclick="Button_click">Generate random number!</button>
                <p>
                    <label id="Label2" runat="server">Generated number is: </label>
                    <label id="generatedNumber" runat="server">Empty!</label>
                </p>
            </div>
        </div>
        <div>
            <h1>With WEB server cotrols.</h1>
            <asp:TextBox ID="First" runat="server"></asp:TextBox>
            <asp:TextBox ID="Second" runat="server"></asp:TextBox>
            <asp:Button ID="Generate" runat="server" Text="Generate random number!" OnClick="Button1_Click" />
            <p>
                <asp:Label ID="Label3" runat="server" Text="Generated number is: "></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Empty!"></asp:Label>
            </p>
        </div>
    </div>
</asp:Content>
