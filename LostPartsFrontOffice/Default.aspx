<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStock" runat="server" Height="243px" Width="298px"></asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please Enter a Stock No"></asp:Label>
        <br />
        <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
            <asp:Button ID="btnDisplayAll" runat="server" Text="DisplayAll" Width="79px" />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" OnClick="Button1_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    </form>
</body>
</html>
