<%@ Page Language="C#" Title="Timer" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Timer.aspx.cs" Inherits="ASP.NETAJAX.Timer" %>

<asp:Content ID="Bodycontent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="FormTimer" runat="server">
        <p>This text is not updated by the partial rendering.</p>
        <asp:UpdatePanel runat='server' ID='UpdatePanelTime' UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TimerTimeRefresh" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                AJAX Timer updates per 3 seconds:
                <%= DateTime.Now.ToString("HH:mm:ss") %>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Timer ID="TimerTimeRefresh" runat="Server" Interval="3000" />
        <p>This text is also not updated.</p>
    </div>
</asp:Content>
