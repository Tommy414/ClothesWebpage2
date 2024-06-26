﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add a new supplier</h2>
        </div>

        <asp:Label ID="lblSupplierId" runat="server" height="19px" style="z-index: 1; left: 13px; top: 112px; position: absolute" Text="Supplier ID" width="186px"></asp:Label>
        <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 218px; top: 111px; position: absolute" width="128px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 112px; position: absolute" Text="Find" OnClick="btnFind_Click" />

        <asp:Label ID="lblSupplierName" runat="server" Style="z-index: 1; left: 13px; top: 149px; position: absolute; width: 186px;" Text="Supplier's name" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" Style="z-index: 1; left: 218px; top: 148px; position: absolute; width: 128px"></asp:TextBox>

        <asp:Label ID="lblSupplier" runat="server" Style="z-index: 1; left: 13px; top: 200px; position: absolute; " Text="Supplier's city" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierCity" runat="server" Style="z-index: 1; left: 218px; top: 199px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierEmail" runat="server" Style="z-index: 1; left: 13px; top: 243px; position: absolute" Text="Supplier's email" Width="186px" height="19px"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" Style="z-index: 1; left: 218px; top: 242px; position: absolute" Width="128px"></asp:TextBox>

        <asp:Label ID="lblSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 13px; top: 282px; position: absolute; right: 1455px; width: 186px;" Text="Supplier's telephone number"></asp:Label>
        <asp:TextBox ID="txtSupplierTelephoneNumber" runat="server" Style="z-index: 1; left: 218px; top: 281px; position: absolute" width="128px"></asp:TextBox>

        <asp:CheckBox ID="chkSupplierAvailability" runat="server" Style="z-index: 1; left: 101px; top: 349px; position: absolute" Text="Is the supplier available?" />
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 16px; top: 406px; position: absolute"></asp:Label>

        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 69px; top: 506px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 225px; top: 507px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 354px; top: 507px; position: absolute" Text="Return to Main Menu" />

    </form>
</body>
</html>
