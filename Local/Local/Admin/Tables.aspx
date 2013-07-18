<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="Local.Admin.Tables" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<script>
    $(function () {
        $("#dialog2").dialog({
            autoOpen: false,
            show: "blind"
        });


    });

    function OpenDialog2() {
        $("#dialog2").dialog("open");
        return false;
    }
</script>
<form id="form1" runat="server">
<div>
    <asp:scriptmanager id="RadScriptManager1" runat="server" />
    <div id="dialog2" title="Editing">
        <asp:table runat="server">
                <asp:TableRow>
                    <asp:TableCell><input type="hidden" id="inputId" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Table name : <input type="text" id="inputTableName" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <input type="button" value="Save" onclick="SaveTable();" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:table>
    </div>
    <div id="tables">
        <telerik:RadListView ID="rlvTables" runat="server" ItemPlaceholderID="ListViewContainer">
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
                                    <asp:TableCell>Table name : <%#Eval("Title")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <input type="button" value="Edit" onclick="OpenDialog2()" />
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
        <input type="button" value="Add"  onclick="OpenDialog2()"/>
    </div>
</div>
</form>
