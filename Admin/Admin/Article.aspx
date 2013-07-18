<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="Admin.Article" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Article</h1>
            <asp:ScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </asp:ScriptManager>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" />
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" />
        <asp:Table runat="server" ID="ArticleTable" Width="500px">
            <asp:TableRow>
                <asp:TableCell>Name : </asp:TableCell>
                <asp:TableCell>
                    <telerik:RadTextBox runat="server" ID="tbName" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Description : </asp:TableCell>
                <asp:TableCell>
                    <telerik:RadTextBox runat="server" ID="tbDescription"
                        TextMode="MultiLine"  Width="300px"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Price : </asp:TableCell>
                <asp:TableCell>
                    <telerik:RadTextBox runat="server" ID="tbPrice" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Type : </asp:TableCell>
                <asp:TableCell>
                    <telerik:RadComboBox runat="server" ID="rcbType" DataTextField="Title" DataValueField="Id"></telerik:RadComboBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <asp:Button runat="server" ID="btnBack" OnClick="btnBack_Click" Text="Back"/>
                    <asp:Button runat="server" ID="btnUpdate" OnClick="btnUpdate_Click" Visible="false" Text="Update"/>
                    <asp:Button runat="server" ID="btnCreate" OnClick="btnCreate_Click" Visible="false" Text="Create"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
