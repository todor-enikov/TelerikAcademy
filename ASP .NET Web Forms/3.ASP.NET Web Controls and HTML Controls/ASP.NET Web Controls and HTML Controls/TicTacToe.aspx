<%@ Page Title="TicTacToe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="ASP.NET_Web_Controls_and_HTML_Controls.TicTacToe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="Table1" BorderColor="Yellow" BorderWidth="4" runat="server" Height="250px" Width="350px">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button1" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button2" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button3" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="Label1" runat="server" Text="Tic-Tac-Toe" BackColor="GreenYellow" BorderColor="Green"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button4" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button5" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button6" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell ColumnSpan="2">
                <asp:Label ID="Label2" runat="server" Text="The winner is: " BackColor="WhiteSmoke" BorderColor="Green"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="Button7" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button8" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="Button9" runat="server" Text="" Width="50" Height="50" OnClick="Button_Click" />
            </asp:TableCell>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell ColumnSpan="2">
                <asp:Button ID="Button10" runat="server" Text="Restart" Width="110" OnClick="Restart_Click" />
            </asp:TableCell>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
