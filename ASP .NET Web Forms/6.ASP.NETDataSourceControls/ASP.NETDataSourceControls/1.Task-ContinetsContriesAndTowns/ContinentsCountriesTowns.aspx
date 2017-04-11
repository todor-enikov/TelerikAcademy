<%@ Page Language="C#" Title="Continents Countries and Towns" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContinentsCountriesTowns.aspx.cs" Inherits="ASP.NETDataSourceControls._1.Task_ContinetsContriesAndTowns.ContinentsCountriesTowns" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:EntityDataSource ID="CountriesSource" runat="server"
        ConnectionString="name=CountriesSystem"
        DefaultContainerName="CountriesSystem"
        EntitySetName="Countries"
        EnableFlattening="false">
    </asp:EntityDataSource>

    <asp:ListBox ID="Continents" runat="server">
        <asp:ListItem>Empty</asp:ListItem>
    </asp:ListBox>

    <asp:GridView ID="Countries" runat="server" 
        AllowPaging="true" AllowSorting="true"
        DataSourceID="CountriesSource"
        AutoGenerateColumns="false">

        <Columns>
            <asp:BoundField HeaderText="Name of country" DataField="Name"/>
        </Columns>
    </asp:GridView>

    <asp:ListView ID="Towns" runat="server">
        <EmptyItemTemplate>Empty</EmptyItemTemplate>
    </asp:ListView>

</asp:Content>
