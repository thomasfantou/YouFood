<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="Admin.Articles" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
    <link type="text/css" href="~/Scripts/jquery-ui/css/smoothness/jquery-ui-1.8.21.custom.css"
        rel="stylesheet" />
    <style type="text/css">
        .rdpWrap .RadInput, .rdpWrap .rdpPagerButton, .rdpWrap .rdpPagerLabel
        {
            float: left;
        }
        
        .ArticlesFieldSet
        {
            float: left;
            width: 350px;
            margin: 5px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            background: rgb(254,255,232); /* Old browsers */
            background: -moz-linear-gradient(top,  rgba(254,255,232,1) 0%, rgba(214,219,191,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(254,255,232,1)), color-stop(100%,rgba(214,219,191,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top,  rgba(254,255,232,1) 0%,rgba(214,219,191,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top,  rgba(254,255,232,1) 0%,rgba(214,219,191,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top,  rgba(254,255,232,1) 0%,rgba(214,219,191,1) 100%); /* IE10+ */
            background: linear-gradient(top,  rgba(254,255,232,1) 0%,rgba(214,219,191,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#feffe8', endColorstr='#d6dbbf',GradientType=0 ); /* IE6-9 */
        }
        
        .ArticlesFieldSet legend
        {
            width: 250px;
            padding: 6px 6px 8px 15px;
            border: 1px solid gray;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            background: rgb(255,255,255); /* Old browsers */
            background: -moz-linear-gradient(top,  rgba(255,255,255,1) 0%, rgba(243,243,243,1) 50%, rgba(237,237,237,1) 51%, rgba(255,255,255,1) 100%); /* FF3.6+ */
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(255,255,255,1)), color-stop(50%,rgba(243,243,243,1)), color-stop(51%,rgba(237,237,237,1)), color-stop(100%,rgba(255,255,255,1))); /* Chrome,Safari4+ */
            background: -webkit-linear-gradient(top,  rgba(255,255,255,1) 0%,rgba(243,243,243,1) 50%,rgba(237,237,237,1) 51%,rgba(255,255,255,1) 100%); /* Chrome10+,Safari5.1+ */
            background: -o-linear-gradient(top,  rgba(255,255,255,1) 0%,rgba(243,243,243,1) 50%,rgba(237,237,237,1) 51%,rgba(255,255,255,1) 100%); /* Opera 11.10+ */
            background: -ms-linear-gradient(top,  rgba(255,255,255,1) 0%,rgba(243,243,243,1) 50%,rgba(237,237,237,1) 51%,rgba(255,255,255,1) 100%); /* IE10+ */
            background: linear-gradient(top,  rgba(255,255,255,1) 0%,rgba(243,243,243,1) 50%,rgba(237,237,237,1) 51%,rgba(255,255,255,1) 100%); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ffffff', endColorstr='#ffffff',GradientType=0 ); /* IE6-9 */
        }
    </style>
    
    <title>YouFood - Admin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Admin
        </h1>
        <asp:ScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
                <asp:ScriptReference Path="~/Scripts/jquery-ui/js/jquery-ui-1.8.21.custom.min.js" />
            </Scripts>
        </asp:ScriptManager>
        <script>
            $(function () {
                $("#dialog").dialog({
                    autoOpen: false,
                    show: "blind",
                    width: "500px"
                });


            });

            function OpenDialog(id, name, description, price, typeid) {
                $("#inputId").val(id);
                $("#inputName").val(name);
                $("#inputDescription").val(description);
                $("#inputPrice").val(price);
                $("#selectType").val(typeid).attr('selected', true);
                $("#dialog").dialog("open");
                return false;
            }

            function SaveArticle() {
                $.ajax({
                    type: "POST",
                    url: "Articles.aspx/SaveArticle",
                    data: "{ 'id' : '" + $("#inputId").val() + "', 'name' : '" + $("#inputName").val() + "', 'description' : '" + $("#inputDescription").val() + "', 'price' : '" + $("#inputPrice").val() + "', 'typeId' : '" + $("#selectType").val() + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        window.location = "Articles.aspx";
                    },
                    error: function (xhr, err, msg) {
                        alert(xhr.responseText);
                    }
                });
            }

            function DeleteArticle(id) {
                $.ajax({
                    type: "POST",
                    url: "Articles.aspx/DeleteArticle",
                    data: "{ 'id' : '" + id + "'}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        window.location = "Articles.aspx";
                    },
                    error: function (xhr, err, msg) {
                        alert(xhr.responseText);
                    }
                });
            }
    </script>
        <telerik:RadFormDecorator ID="RadFormDecorator1" runat="server" />
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" />
        <div id="dialog" title="Editing">
            <asp:Table ID="Table2" runat="server">
                <asp:TableRow>
                    <asp:TableCell><input type="hidden" id="inputId" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Name : <input type="text" id="inputName" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><span style="vertical-align:top;">Description :</span>  <textarea id="inputDescription" rows="2" cols="30"></textarea></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Price : <input type="text" id="inputPrice" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Type : 
                        <select id="selectType">
                            <asp:Repeater runat="server" ID="repListArticlesTypeCb" EnableViewState="false">
                                <ItemTemplate>
                                    <option value='<%#Eval("Id")%>' ><%#Eval("Title")%></option>
                                </ItemTemplate>
                            </asp:Repeater>
                        </select>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <input type="button" value="Save" onclick="SaveArticle();" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <div style="margin: 15px; margin-left:45px;">
            <input type="button" ID="btnCreate" onclick="OpenDialog('','','','','');"
                value="Create new article" />
        </div>
        <asp:Repeater runat="server" ID="repListArticlesType" EnableViewState="false">
            <ItemTemplate>
                <asp:Table ID="Table1" Width="95%" runat="server" Style="border: 1px solid black;
                    margin: auto; margin-bottom: 15px; background: #E6EBED; -webkit-border-radius: 5px; border-radius: 5px;">
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2"><%#Eval("Type")%></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Repeater ID="repListArticles" runat="server" EnableViewState="false" DataSource='<%# Eval("Articles") %>'>
                                <ItemTemplate>
                                    <fieldset class="ArticlesFieldSet">
                                        <legend><b>Name</b>:
                                            <%#Eval("Title")%></legend>
                                        <div class="details">
                                            <ul>
                                                <li>
                                                    <label>
                                                        Description:</label>
                                                    <%#Eval("Description")%>
                                                </li>
                                                <li>
                                                    <label>
                                                        Price:</label>
                                                    <%#Eval("Price")%>
                                                </li>
                                                <li>
                                                    <label>
                                                        Type:</label>
                                                    <%#Eval("Type")%>
                                                </li>
                                            </ul>
                                            <input type="button" onclick='<%# String.Format("javascript:return OpenDialog(\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\")", Eval("Id").ToString(), Eval("Title").ToString(), Eval("Description").ToString(), Eval("Price").ToString(), Eval("TypeId").ToString()) %>'  value="Edit" />
                                            <input type="button" onclick='<%# String.Format("javascript:return DeleteArticle(\"{0}\")", Eval("Id").ToString()) %>'  value="Delete" />
                                        </div>
                                    </fieldset>
                                </ItemTemplate>
                            </asp:Repeater>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
    <div id="footer"><a href="Articles.aspx">Articles</a> | <a href="Statistics.aspx">Statistics</a></div>
</body>
</html>
