<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchingForCar.aspx.cs" Inherits="ASP.NETDataBinding.SearchingForCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ProducerLabel" runat="server" Text="Producer"></asp:Label>
            <asp:DropDownList ID="ProducerDropDown" runat="server" OnSelectedIndexChanged="Page_Load"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="ModelLabel" runat="server" Text="Model"></asp:Label>
            <asp:DropDownList ID="ModelDropDownList" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="ExtraLabel" runat="server" Text="Extra"></asp:Label>
            <asp:CheckBoxList ID="ExtraCheckBoxList" runat="server" RepeatDirection="Horizontal"></asp:CheckBoxList>
        </div>
        <div>
            <asp:Label ID="EngineLabel" runat="server" Text="Engine type: "></asp:Label>
            <asp:RadioButtonList ID="EngineRadioButtonList" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList>
        </div>
        <div>
            <asp:Button ID="Submit" runat="server" Text="Submit your choice!" OnClick="Submit_Click" Width="300px"/>
        </div>
    </form>
    <asp:Literal ID="ChoosenInfo" runat="server"></asp:Literal>
</body>
</html>
