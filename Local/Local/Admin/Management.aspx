<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="Local.Admin.Management" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<style>
    .draggableTables
    {
        width: 80px;
        height: 50px;
        padding: 0.5em;
        float: left;
        margin: 10px 10px 10px 0;
    }
    
    .draggableTables p
    {
        font-size: 10px;
    }
    .droppable
    {
        width: 350px;
        height: 250px;
        padding: 0.5em;
        float: left;
        margin: 10px;
    }
    .droppable p
    {
        font-size: 11px;
    }
</style>
<script>
    $(function () {
        $(".draggableTables").draggable();
        $(".droppable").droppable({
            drop: function (event, ui) {
                console.log(event)
                console.log(ui)

                $(this).addClass("ui-state-highlight");
            }
        }).resizable();
    });
</script>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="RadScriptManager1" runat="server" />
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <telerik:RadListView ID="rlvZones" runat="server" ItemPlaceholderID="ListViewContainer">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="droppable ui-widget-header">
                                <asp:Table ID="Table1" runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell>Zone [<%#Eval("Title")%>]</asp:TableCell>
                                        <asp:TableCell>
                                            <select id='waiterZone<%#Eval("Id")%>' >
                                                <option value="0">Select a waiter</option>
                                            <% foreach (Local.DataContract.WaiterDataContact waiter in Waiters)
                                               { %>
                                                    <option value='<%= waiter.Id %>'><%= waiter.FirstName + " "%><%= waiter.LastName %></option>
                                            <% } %>
                                            
                                            </select>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table> 
                            </div>
                        </ItemTemplate>
                    </telerik:RadListView>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <telerik:RadListView ID="rlvTables" runat="server" ItemPlaceholderID="ListViewContainer">
                        <LayoutTemplate>
                            <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="draggableTables ui-widget-content">
                                <asp:Table runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell><%#Eval("Title")%></p></asp:TableCell>
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