<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Waiters.aspx.cs" Inherits="Local.Waiters.Waiters" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Waiters</title>
    <link type="text/css" href="~/Scripts/jquery-ui/css/black-tie/jquery-ui-1.8.21.custom.css"
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
                $(function () {
                    $("#tabs").tabs();
                });

                
                $("#tabs").tabs("select", <%=CurrentIndex%>);

                $("input:submit", ".details").button();


            });

            function CacheCurrentWaiter(index) {
                $.ajax({
                    type: "POST",
                    url: "Waiters.aspx/CacheCurrentWaiter",
                    data: "{ 'index' : '" + index + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {

                    },
                    error: function (xhr, err, msg) {
                        alert(xhr.responseText);
                    }
                });
            }
        </script>
        <div id="tabs">
            <ul>
                <asp:Repeater runat="server" ID="repListWaiters" EnableViewState="false">
                    <ItemTemplate>
                        <li>
                            <a href='<%# String.Format("WaiterOrders.aspx?id={0}", Eval("Id")) %>'  onclick='CacheCurrentWaiter("<%# Container.ItemIndex %>")' >
                                <%# String.Format("{0} {1}", Eval("FirstName"), Eval("LastName"))%>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
    </form>
</body>
</html>
