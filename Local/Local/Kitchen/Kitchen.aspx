<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kitchen.aspx.cs" Inherits="Local.Kitchen.Kitchen" enableEventValidation="false" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Kitchen</title>
    <link type="text/css" href="~/Scripts/jquery-ui/css/start/jquery-ui-1.8.21.custom.css"
        rel="stylesheet" />
    <style>
        .listArticle
        {
            border: 1px solid gray;
            -webkit-border-radius: 10px;
            -moz-border-radius: 10px;
            border-radius: 10px;
            padding:5px;
        }
        
        .tableOrders
        {
            -webkit-border-radius: 20px;
            -moz-border-radius: 20px;
            border-radius: 20px;
            -webkit-box-shadow: 5px 5px 5px 2px rgba(0, 0, 0, 0.3);
            box-shadow: 5px 5px 5px 2px rgba(0, 0, 0, 0.3); 
            width:50%;
            margin:auto;
            margin-top:5px;
            padding:10px;
        }
        
        .tableOrdered
        {
            background: rgb(145,192,95); /* Old browsers */
            background: -moz-linear-gradient(top,  rgba(145,192,95,1) 1%, rgba(219,244,217,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(1%,rgba(145,192,95,1)), color-stop(100%,rgba(219,244,217,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top,  rgba(145,192,95,1) 1%,rgba(219,244,217,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top,  rgba(145,192,95,1) 1%,rgba(219,244,217,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top,  rgba(145,192,95,1) 1%,rgba(219,244,217,1) 100%); /* IE10+ */
            background: linear-gradient(top,  rgba(145,192,95,1) 1%,rgba(219,244,217,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#91c05f', endColorstr='#dbf4d9',GradientType=0 ); /* IE6-9 */
        }
        
        .tableAccepted
        {
            background: rgb(240,249,255); /* Old browsers */
            background: -moz-linear-gradient(top,  rgba(240,249,255,1) 0%, rgba(203,235,255,1) 47%, rgba(161,219,255,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(240,249,255,1)), color-stop(47%,rgba(203,235,255,1)), color-stop(100%,rgba(161,219,255,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top,  rgba(240,249,255,1) 0%,rgba(203,235,255,1) 47%,rgba(161,219,255,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top,  rgba(240,249,255,1) 0%,rgba(203,235,255,1) 47%,rgba(161,219,255,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top,  rgba(240,249,255,1) 0%,rgba(203,235,255,1) 47%,rgba(161,219,255,1) 100%); /* IE10+ */
            background: linear-gradient(top,  rgba(240,249,255,1) 0%,rgba(203,235,255,1) 47%,rgba(161,219,255,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f0f9ff', endColorstr='#a1dbff',GradientType=0 ); /* IE6-9 */
        }
        
        .tableReady
        {
            background: rgb(254,204,177); /* Old browsers */
            background: -moz-linear-gradient(top,  rgba(254,204,177,1) 0%, rgba(241,116,50,1) 50%, rgba(234,85,7,1) 51%, rgba(251,149,94,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(254,204,177,1)), color-stop(50%,rgba(241,116,50,1)), color-stop(51%,rgba(234,85,7,1)), color-stop(100%,rgba(251,149,94,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top,  rgba(254,204,177,1) 0%,rgba(241,116,50,1) 50%,rgba(234,85,7,1) 51%,rgba(251,149,94,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top,  rgba(254,204,177,1) 0%,rgba(241,116,50,1) 50%,rgba(234,85,7,1) 51%,rgba(251,149,94,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top,  rgba(254,204,177,1) 0%,rgba(241,116,50,1) 50%,rgba(234,85,7,1) 51%,rgba(251,149,94,1) 100%); /* IE10+ */
            background: linear-gradient(top,  rgba(254,204,177,1) 0%,rgba(241,116,50,1) 50%,rgba(234,85,7,1) 51%,rgba(251,149,94,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#feccb1', endColorstr='#fb955e',GradientType=0 ); /* IE6-9 */

        }
    </style>
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

                var tab = $.getUrlVar('tab');
                if (tab == "ordered")
                    $("#tabs").tabs("select", 0);
                else if (tab == "accepted")
                    $("#tabs").tabs("select", 1);

                $("input:submit", ".details").button();


            });
        </script>
        <div id="tabs">
            <ul>
                <li><a href="#ordered">Ordered</a></li>
                <li><a href="#accepted">Accepted</a></li>
                <li><a href="#ready">Ready</a></li>
            </ul>
            <div id="ordered">
                <telerik:RadListView ID="rlvOrdered" runat="server" ItemPlaceholderID="ListViewContainer">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="details">
                            <asp:Table runat="server" class="tableOrders tableOrdered">
                                <asp:TableRow>
                                    <asp:TableCell>Order #<%#Eval("IdOrder")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>Ordered at <%#Eval("Date")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <div class="listArticle">
                                            Articles:
                                            <ul>
                                                <asp:Repeater runat="server" ID="_subitemsRepeater" EnableViewState="false" DataSource='<%# Eval("Articles") %>'>
                                                    <ItemTemplate>
                                                        <li>
                                                            <%#Eval("Title")%> [<%#Eval("Type")%>]</li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </div>
                                    </asp:TableCell>
                                    <asp:TableCell style="float:right;">
                                        <asp:Button runat="server" ID="btnAcceptOrder" CommandArgument='<%#Eval("IdOrder")%>'
                                            Text="Accept" Height="50px" OnClick="btnAcceptOrder_Click"/>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </ItemTemplate>
                </telerik:RadListView>
            </div>
            <div id="accepted">
                <telerik:RadListView ID="rlvAccepted" runat="server" ItemPlaceholderID="ListViewContainer">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="details">
                            <asp:Table ID="Table2" runat="server" class="tableOrders tableAccepted">
                                <asp:TableRow>
                                    <asp:TableCell>Order #<%#Eval("IdOrder")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>Ordered at <%#Eval("Date")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <div class="listArticle">
                                            Articles:
                                            <ul>
                                                <asp:Repeater runat="server" ID="_subitemsRepeater" EnableViewState="false" DataSource='<%# Eval("Articles") %>'>
                                                    <ItemTemplate>
                                                        <li>
                                                            <%#Eval("Title")%> [<%#Eval("Type")%>]</li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </div>
                                    </asp:TableCell>
                                    <asp:TableCell style="float:right;">
                                        <asp:Button runat="server" ID="btnOrderReady" CommandArgument='<%#Eval("IdOrder")%>'
                                            Text="Ready" Height="50px" OnClick="btnOrderReady_Click"/>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </ItemTemplate>
                </telerik:RadListView>
            </div>
            <div id="ready">
                <telerik:RadListView ID="rlvReady" runat="server" ItemPlaceholderID="ListViewContainer">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="details">
                            <asp:Table ID="Table2" runat="server" class="tableOrders tableReady">
                                <asp:TableRow>
                                    <asp:TableCell>Order #<%#Eval("IdOrder")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>Ordered at <%#Eval("Date")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <div class="listArticle">
                                            Articles:
                                            <ul>
                                                <asp:Repeater runat="server" ID="_subitemsRepeater" EnableViewState="false" DataSource='<%# Eval("Articles") %>'>
                                                    <ItemTemplate>
                                                        <li>
                                                            <%#Eval("Title")%> [<%#Eval("Type")%>]</li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </div>
                                    </asp:TableCell>
                                    <asp:TableCell style="float:right;">
                                        <asp:Button runat="server" ID="btnOrderReady" CommandArgument='<%#Eval("IdOrder")%>'
                                            Text='<%# "Order taker : " + Eval("WaiterFirstName") + " " + Eval("WaiterLastName")%>' Height="100px" Enabled="false"/>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </div>
                    </ItemTemplate>
                </telerik:RadListView>
            </div>
        </div>
    </div>
    </form>
</body>
