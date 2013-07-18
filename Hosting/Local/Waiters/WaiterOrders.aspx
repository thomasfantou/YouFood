<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaiterOrders.aspx.cs" Inherits="Local.Waiters.WaiterOrders" enableEventValidation="false" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<style>
    .ordersNotReady
    {
        width: 120px;
        height: 40px;
        padding: 3px;
        font-size: 12px;
        -webkit-border-radius: 5px;
        border: 1px solid black;
        border-radius: 5px;
        background: rgb(226,226,226); /* Old browsers */
        background: -moz-linear-gradient(top,  rgba(226,226,226,1) 0%, rgba(219,219,219,1) 50%, rgba(209,209,209,1) 51%, rgba(254,254,254,1) 100%); /* FF3.6+ */
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(226,226,226,1)), color-stop(50%,rgba(219,219,219,1)), color-stop(51%,rgba(209,209,209,1)), color-stop(100%,rgba(254,254,254,1))); /* Chrome,Safari4+ */
        background: -webkit-linear-gradient(top,  rgba(226,226,226,1) 0%,rgba(219,219,219,1) 50%,rgba(209,209,209,1) 51%,rgba(254,254,254,1) 100%); /* Chrome10+,Safari5.1+ */
        background: -o-linear-gradient(top,  rgba(226,226,226,1) 0%,rgba(219,219,219,1) 50%,rgba(209,209,209,1) 51%,rgba(254,254,254,1) 100%); /* Opera 11.10+ */
        background: -ms-linear-gradient(top,  rgba(226,226,226,1) 0%,rgba(219,219,219,1) 50%,rgba(209,209,209,1) 51%,rgba(254,254,254,1) 100%); /* IE10+ */
        background: linear-gradient(top,  rgba(226,226,226,1) 0%,rgba(219,219,219,1) 50%,rgba(209,209,209,1) 51%,rgba(254,254,254,1) 100%); /* W3C */
        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#e2e2e2', endColorstr='#fefefe',GradientType=0 ); /* IE6-9 */
        margin:10px;
        float:left;
    }
    
    .ordersReady
    {
        width: 250px;
        padding: 10px;
        font-size: 14px;
        -webkit-border-radius: 5px;
        border: 1px solid black;
        border-radius: 5px;
        background: rgb(242,246,248); /* Old browsers */
        background: -moz-linear-gradient(top,  rgba(242,246,248,1) 0%, rgba(216,225,231,1) 50%, rgba(181,198,208,1) 51%, rgba(224,239,249,1) 100%); /* FF3.6+ */
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(242,246,248,1)), color-stop(50%,rgba(216,225,231,1)), color-stop(51%,rgba(181,198,208,1)), color-stop(100%,rgba(224,239,249,1))); /* Chrome,Safari4+ */
        background: -webkit-linear-gradient(top,  rgba(242,246,248,1) 0%,rgba(216,225,231,1) 50%,rgba(181,198,208,1) 51%,rgba(224,239,249,1) 100%); /* Chrome10+,Safari5.1+ */
        background: -o-linear-gradient(top,  rgba(242,246,248,1) 0%,rgba(216,225,231,1) 50%,rgba(181,198,208,1) 51%,rgba(224,239,249,1) 100%); /* Opera 11.10+ */
        background: -ms-linear-gradient(top,  rgba(242,246,248,1) 0%,rgba(216,225,231,1) 50%,rgba(181,198,208,1) 51%,rgba(224,239,249,1) 100%); /* IE10+ */
        background: linear-gradient(top,  rgba(242,246,248,1) 0%,rgba(216,225,231,1) 50%,rgba(181,198,208,1) 51%,rgba(224,239,249,1) 100%); /* W3C */
        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f2f6f8', endColorstr='#e0eff9',GradientType=0 ); /* IE6-9 */
        float:left;
        margin:12px;
    }
    
    .ordersUnpaid
    {
        width: 200px;
        padding: 10px;
        font-size: 13px;
        -webkit-border-radius: 5px;
        border: 1px solid black;
        border-radius: 5px;
        background: rgb(243,197,189); /* Old browsers */
        background: -moz-linear-gradient(top,  rgba(243,197,189,1) 0%, rgba(232,108,87,1) 50%, rgba(234,40,3,1) 51%, rgba(255,102,0,1) 75%, rgba(199,34,0,1) 100%); /* FF3.6+ */
        background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(243,197,189,1)), color-stop(50%,rgba(232,108,87,1)), color-stop(51%,rgba(234,40,3,1)), color-stop(75%,rgba(255,102,0,1)), color-stop(100%,rgba(199,34,0,1))); /* Chrome,Safari4+ */
        background: -webkit-linear-gradient(top,  rgba(243,197,189,1) 0%,rgba(232,108,87,1) 50%,rgba(234,40,3,1) 51%,rgba(255,102,0,1) 75%,rgba(199,34,0,1) 100%); /* Chrome10+,Safari5.1+ */
        background: -o-linear-gradient(top,  rgba(243,197,189,1) 0%,rgba(232,108,87,1) 50%,rgba(234,40,3,1) 51%,rgba(255,102,0,1) 75%,rgba(199,34,0,1) 100%); /* Opera 11.10+ */
        background: -ms-linear-gradient(top,  rgba(243,197,189,1) 0%,rgba(232,108,87,1) 50%,rgba(234,40,3,1) 51%,rgba(255,102,0,1) 75%,rgba(199,34,0,1) 100%); /* IE10+ */
        background: linear-gradient(top,  rgba(243,197,189,1) 0%,rgba(232,108,87,1) 50%,rgba(234,40,3,1) 51%,rgba(255,102,0,1) 75%,rgba(199,34,0,1) 100%); /* W3C */
        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f3c5bd', endColorstr='#c72200',GradientType=0 ); /* IE6-9 */

        float:left;
        margin:12px;
    }
    
</style>
<script>
    $(function () {
        $(".boxOrderReady").draggable();
        $("#OrderCompletedArea").droppable({
            drop: function (event, ui) {
                $.ajax({
                    type: "POST",
                    url: "WaiterOrders.aspx/CompleteOrder",
                    data: "{ 'id' : '" + ui.draggable[0].id + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        window.location = "Waiters.aspx";
                    },
                    error: function (xhr, err, msg) {
                        alert(xhr.responseText);
                    }
                });
            }
        });
    });
</script>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="RadScriptManager1" runat="server" />
        <asp:Table runat="server" Style="width: 100%">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell Style="width: 25%; background:#F0F0F0; border: 1px solid #DBDBDB; font-size:13px;">Recent orders</asp:TableHeaderCell>
                <asp:TableHeaderCell Style="width: 40%; font-size:13px">Orders ready</asp:TableHeaderCell>
                <asp:TableHeaderCell Style="width: 35%; background:#FFFAB8; border: solid #DBDBDB 1px; font-size:13px" >Order completed (Drag and drop orders here once done)</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell Style="width: 25%; background:#F0F0F0; border: 1px solid #DBDBDB;">
                    <telerik:RadListView ID="rlvOrdersNotReady" runat="server" ItemPlaceholderID="ListViewContainer">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="details">
                                <asp:Table runat="server" CssClass="ordersNotReady">
                                    <asp:TableRow>
                                        <asp:TableCell><%# Eval("TableName") %></asp:TableCell>
                                        <asp:TableCell style="float:right;">#<%# Eval("IdOrder") %></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell><%# Eval("StatusDescription") %></asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </ItemTemplate>
                    </telerik:RadListView>
                </asp:TableCell>
                <asp:TableCell Style="width: 40%">
                    <telerik:RadListView ID="rlvOrdersReady" runat="server" ItemPlaceholderID="ListViewContainer">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="boxOrderReady" id='<%# Eval("IdOrder") %>'>
                                <asp:Table ID="Table1" runat="server" CssClass="ordersReady">
                                    <asp:TableRow>
                                        <asp:TableCell><%# Eval("TableName") %></asp:TableCell>
                                        <asp:TableCell style="float:right;">#<%# Eval("IdOrder") %></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>Ready</asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <ul>
                                                <asp:Repeater runat="server" ID="repListArticles" EnableViewState="false" DataSource='<%# Eval("Articles") %>'>
                                                    <ItemTemplate>
                                                        <li><%# Eval("Title")%></li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </ItemTemplate>
                    </telerik:RadListView>
                </asp:TableCell>
                <asp:TableCell Style="width: 35%; background:#FFFAB8; border: solid #DBDBDB 1px;" ID="OrderCompletedArea" >
                    <telerik:RadListView ID="rlvOrdersUnpaid" runat="server" ItemPlaceholderID="ListViewContainer">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="details">
                                <asp:Table ID="Table2" runat="server" CssClass="ordersUnpaid">
                                    <asp:TableRow>
                                        <asp:TableCell><%# Eval("TableName") %></asp:TableCell>
                                        <asp:TableCell style="float:right;">#<%# Eval("IdOrder") %></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell><%# Eval("StatusDescription") %></asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>Price : <%# Eval("TotalPrice") %>$</asp:TableCell>
                                        <asp:TableCell style="float:right;"><asp:Button runat="server" ID="btnComplete" OnClick="btnComplete_Click" Text="V" CommandArgument='<%# Eval("IdOrder") %>'/></asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                            </div>
                        </ItemTemplate>
                    </telerik:RadListView>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
