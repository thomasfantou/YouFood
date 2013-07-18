<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Local.Admin.Admin" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Admin</title>
    
    <link type="text/css" href="~/Scripts/jquery-ui/css/ui-lightness/jquery-ui-1.8.21.custom.css"
        rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/jquery-1.4.1.min.js" />
                <asp:ScriptReference Path="~/Scripts/jquery-ui/js/jquery-ui-1.8.21.custom.min.js" />
                <asp:ScriptReference Path="~/Scripts/scripts.js" />
            </Scripts>
        </asp:ScriptManager>
        <script type="text/javascript">
             $(function () {
                 $("#tabs").tabs({
                     ajaxOptions: {
                         error: function (xhr, status, index, anchor) {
                             $(anchor.hash).html(
						"Couldn't load this tab.");
                         }
                     }
                 });

                 var tab = $.getUrlVar('tab');
                 if (tab == "database")
                     $("#tabs").tabs("select", 0);
                 else if (tab == "waiters")
                     $("#tabs").tabs("select", 1);
                 else if (tab == "tables")
                     $("#tabs").tabs("select", 2);
                 else if (tab == "zones")
                     $("#tabs").tabs("select", 3);
                 else if (tab == "management")
                     $("#tabs").tabs("select", 4);
             });
    </script>
        <div id="tabs">
            <ul>
                <li><a href="Database.aspx">Database</a></li>
                <li><a href="Waiters.aspx">Waiters</a></li>
                <li><a href="Tables.aspx">Tables</a></li>
                <li><a href="Zones.aspx">Zones</a></li>
                <li><a href="Management.aspx">Management</a></li>
            </ul>
        </div>
    </div>
    </form>
</body>
</html>
