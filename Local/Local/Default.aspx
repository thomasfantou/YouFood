<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Local._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button runat="server" ID="btnKitchen" Text="Kitchen" OnClick="btnKitchen_Click" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button runat="server" ID="btnWaiters" Text="Waiters" OnClick="btnWaiters_Click" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button runat="server" ID="btnAdmin" Text="Admin" OnClick="btnAdmin_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
