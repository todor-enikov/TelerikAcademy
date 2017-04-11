<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowingAllEmployees.aspx.cs" Inherits="ASP.NETDataBinding._4.Task_EmployeeNameCountryCity.ShowingAllEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="3" OnPageIndexChanging="View_PageIndexChanging">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First name"/>
                    <asp:BoundField DataField="LastName" HeaderText="Last name"/>
                    <asp:BoundField DataField="Country" HeaderText="Country"/>
                    <asp:BoundField DataField="City" HeaderText="City"/>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
