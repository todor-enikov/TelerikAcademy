<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SumNumbers.aspx.cs" Inherits="SumNumbers.SumNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>My first ASP .Net Web Forms</h3>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Enter first number: "></asp:Label>
                <asp:TextBox ID="FirstNumber" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Text="Enter second number:"></asp:Label>
                <asp:TextBox ID="SecondNumber" runat="server"></asp:TextBox>
            </p>
        </div>
        <p>
            <asp:Button ID="Sum" runat="server" Text="Sum the numbers!" OnClick="Sum_Click" />
        </p>
        <p>
            <asp:Label ID="TextForSum" runat="server" Text="The sum of the numbers is: "></asp:Label>
            <asp:Label ID="FinalResult" runat="server" Text=""></asp:Label>

        </p>
    </form>
</body>
</html>
