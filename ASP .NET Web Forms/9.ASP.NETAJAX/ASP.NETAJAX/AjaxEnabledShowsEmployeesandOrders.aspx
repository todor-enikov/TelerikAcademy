<%@ Page Language="C#" Title="Employees and orders" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AjaxEnabledShowsEmployeesandOrders.aspx.cs" Inherits="ASP.NETAJAX.AjaxEnabledShowsEmployeesandOrders" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel">
        <asp:GridView ID="Employees" runat="server"
            AllowSorting="true"
            AutoGenerateColumns="false" OnPreRender="Employees_PreRender">
            <Columns>
                <asp:HyperLinkField HeaderText="Employee name"
                    DataTextField="FirstName"
                    DataNavigateUrlFields="EmployeeID"
                    DataNavigateUrlFormatString="~/AjaxEnabledShowsEmployeesandOrders.aspx?id={0}" />
            </Columns>
        </asp:GridView>

        <asp:UpdatePanel ID="UpdatePanelOrders" runat="server">
            <ContentTemplate>
                <asp:GridView ID="Orders" runat="server" AllowSorting="true">
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
