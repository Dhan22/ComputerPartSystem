<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStock.aspx.cs" Inherits="AnStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 7px;
        }
    </style>
</head>
<body style="height: 52px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtCPU" runat="server" style="z-index: 1; left: 143px; top: 158px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtGPU" runat="server" style="z-index: 1; left: 141px; top: 201px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPCIDNo" runat="server" style="z-index: 1; left: 141px; top: 247px; position: absolute" OnTextChanged="txtPCIDNo_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtPCName" runat="server" style="z-index: 1; left: 139px; top: 303px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 53px; top: 118px; position: absolute; bottom: 565px;" Text="BuildDate"></asp:Label>
        <asp:Label ID="lblCPU" runat="server" style="z-index: 1; left: 47px; top: 162px; position: absolute" Text="CPU"></asp:Label>
        <asp:Label ID="lblGPU" runat="server" style="z-index: 1; left: 47px; top: 205px; position: absolute" Text="GPU"></asp:Label>
        <asp:Label ID="Label" runat="server" style="z-index: 1; left: 51px; top: 251px; position: absolute; right: 1052px;" Text="PCIDNo"></asp:Label>
        <asp:Label ID="lblPCName" runat="server" style="z-index: 1; left: 47px; top: 305px; position: absolute" Text="PCName"></asp:Label>
        <asp:Label ID="lblRAM" runat="server" style="z-index: 1; left: 37px; top: 371px; position: absolute; height: 8px; width: 43px;" Text="RAM"></asp:Label>
        <asp:Label ID="lblStockAvailable" runat="server" style="z-index: 1; left: 94px; top: 405px; position: absolute; height: 3px; width: 44px;" Text="StockAvailable"></asp:Label>
        <asp:Label ID="lblStorageType" runat="server" style="z-index: 1; left: 39px; top: 454px; position: absolute" Text="StorageType"></asp:Label>
        <asp:TextBox ID="txtStockAvailable" runat="server" style="z-index: 1; left: 234px; top: 405px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStorageType" runat="server" style="z-index: 1; left: 175px; top: 447px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtBuildDate" runat="server" style="z-index: 1; top: 118px; position: absolute; height: 22px; left: 143px"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 171px; top: 504px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 131px; top: 504px; position: absolute; height: 26px; width: 31px;" Text="Ok" OnClick="btnOk_Click" />
        <p>
        <asp:TextBox ID="txtRAM" runat="server" style="z-index: 1; left: 138px; top: 358px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 248px; top: 504px; position: absolute; height: 26px" Text="Find" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="height: 65px; width: 95px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
