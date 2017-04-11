﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="ASP.NETDataBinding._2.Task_Employee.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="EmployeesGridView" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:HyperLinkField 
                    HeaderText="First name"
                    DataTextField="FirstName"
                    DataNavigateUrlFields="EmployeeID"
                    DataNavigateUrlFormatString="~/2.Task-Employee/EmployeeDetails.aspx?id={0}"/>
            </Columns>
        </asp:GridView>  
    </div>
    </form>
</body>
</html>
