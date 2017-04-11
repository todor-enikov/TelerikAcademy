<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls.Calculator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" runat="server" BorderColor="Yellow" BorderWidth="4" Width="300" Height="400" CellSpacing="20">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2">
                <asp:TextBox ID="TextBox1" runat="server" Width="100"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="1" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="2" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button3" runat="server" Text="3" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button4" runat="server" Text="+" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button5" runat="server" Text="4" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button6" runat="server" Text="5" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button7" runat="server" Text="6" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button8" runat="server" Text="-" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button9" runat="server" Text="7" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button10" runat="server" Text="8" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button11" runat="server" Text="9" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button12" runat="server" Text="*" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button13" runat="server" Text="Clear!" Width="50" Height="50" OnClick="Clear_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button14" runat="server" Text="0" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button15" runat="server" Text="/" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button16" runat="server" Text="root" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell ColumnSpan="2">
                <asp:Button ID="Button18" runat="server" Text="=" Width="115" Height="30" OnClick="Equal_Click" />
            </asp:TableCell>
            <asp:TableCell>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
