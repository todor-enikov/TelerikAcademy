<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadingFileToAFolder.aspx.cs" Inherits="FileUploadInASP.NET.UploadingFileToAFolder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload ID="FileUpload" runat="server" />
        <asp:Button ID="UploadButton" runat="server" Text="Upload the file!" OnClick="UploadButton_Click" />
        <br />
        <br />
        <asp:Label ID="StatusLabel" runat="server" Text="Upload status: "></asp:Label>
    </form>
</body>
</html>
