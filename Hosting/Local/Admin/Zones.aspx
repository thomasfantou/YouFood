<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zones.aspx.cs" Inherits="Local.Admin.Zones" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<script>
    $(function () {
        $("#dialogZone").dialog({
            autoOpen: false,
            show: "blind"
        });


    });

    function OpenDialogZone() {
        $("#dialogZone").dialog("open");
        return false;
    }
</script>
<form id="form1" runat="server">
<div>
    <asp:scriptmanager id="RadScriptManager1" runat="server" />
    <div id="dialogZone" title="Editing">
        <asp:table runat="server">
                <asp:TableRow>
                    <asp:TableCell><input type="hidden" id="inputId" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Zone name : <input type="text" id="inputTableName" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <input type="button" value="Save" onclick="SaveTable();" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:table>
    </div>
    <div id="tables">
        <telerik:RadListView ID="rlvZones" runat="server" ItemPlaceholderID="ListViewContainer">
            <LayoutTemplate>
                <asp:placeholder runat="server" id="ListViewContainer" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="details">
                    <fieldset>
                        <legend><b>Id</b>:
                            <%#Eval("Id")%></legend>
                        <asp:table id="Table1" runat="server">
                                <asp:TableRow>
                                    <asp:TableCell>Zone name : <%#Eval("Title")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <input type="button" value="Edit" onclick="OpenDialogZone()" />
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:Button ID="btnDelete" runat="server" CommandArgument='<%#Eval("Id")%>' Text="Delete" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:table>
                    </fieldset>
                </div>
            </ItemTemplate>
        </telerik:RadListView>
        <input type="button" value="Add"  onclick="OpenDialogZone()"/>
    </div>
</div>
</form>
