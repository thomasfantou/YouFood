<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Waiters.aspx.cs" Inherits="Local.Admin.Waiters" enableEventValidation="false" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<script>
    $(function () {
        $("#dialog").dialog({
            autoOpen: false,
            show: "blind"
        });

        $("input:submit, input:button", "#waiters").button();
        $("a", ".demo").click(function () { return false; });
        
    });

    function OpenDialog(id, firstname, lastname) {
        $("#inputId").val(id);
        $("#inputFirstName").val(firstname);
        $("#inputLastName").val(lastname);
        $("#dialog").dialog("open");
        return false;
    }

    function SaveWaiter() {
        $.ajax({
            type: "POST",
            url: "Waiters.aspx/SaveWaiter",
            data: "{ 'id' : '" + $("#inputId").val() + "', 'firstname' : '" + $("#inputFirstName").val() + "', 'lastname' : '" + $("#inputLastName").val() + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                window.location = "Admin.aspx?tab=waiters";
            },
            error: function (xhr, err, msg) {
                alert(xhr.responseText);
            }
        });
    }


</script>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="RadScriptManager1" runat="server" />
        <div id="dialog" title="Editing">
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell><input type="hidden" id="inputId" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>First name : <input type="text" id="inputFirstName" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Last name : <input type="text" id="inputLastName" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <input type="button" value="Save" onclick="SaveWaiter();" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <div id="waiters">
            <telerik:RadListView ID="rlvWaiters" runat="server" ItemPlaceholderID="ListViewContainer">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="ListViewContainer" />
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="details">
                        <fieldset>
                            <legend><b>Id</b>:
                                <%#Eval("Id")%></legend>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell>First name : <%#Eval("FirstName")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>Last name : <%#Eval("LastName")%></asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <input type="button" onclick='<%# String.Format("javascript:return OpenDialog(\"{0}\",\"{1}\",\"{2}\")", Eval("Id").ToString(), Eval("FirstName").ToString(), Eval("LastName").ToString()) %>'  value="Edit" />
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:Button ID="btnDelete" runat="server" CommandArgument='<%#Eval("Id")%>' OnClick="btnDelete_Click" Text="Delete" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                    </div>
                </ItemTemplate>
            </telerik:RadListView>

            <input type="button" value="Add" onclick="OpenDialog('', '', '')" />

        </div>
    </div>
    </form>
