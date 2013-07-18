<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="Local.Admin.Database" %>

<form id="form1" runat="server">
<div>
    <asp:table runat="server">
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lbLastUpdate" Text="Last update made on : {0}" /></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lbLastUpdateAvailable" Text="Last available update made on : {0}" /></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Label runat="server" ID="lbUpdateMessage" /></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell>
            <asp:Button runat="server" ID="btnForceUpdate" OnClick="btnForceUpdate_Click" Text="Force database refresh"/></asp:TableCell>
    </asp:TableRow>
</asp:table>
</div>
</form>
