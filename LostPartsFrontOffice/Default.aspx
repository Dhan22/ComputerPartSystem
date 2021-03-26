<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaff" runat="server" Height="378px" Width="405px"></asp:ListBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Please Enter a Staff Name"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtEnterName" runat="server" Width="354px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="Button1_Click" Text="Apply" />
            <br />
            <br />
            <asp:Button ID="btnDisplay" runat="server" OnClick="Button1_Click" Text="Display" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <br />
            <br />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 63px; top: 618px; position: absolute; right: 1290px" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 125px; top: 619px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        </div>
    </form>
</body>
</html>
