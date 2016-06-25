<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqFunc.aspx.cs" Inherits="LINQTut.Projection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="ProjectionView" runat="server"></asp:GridView>
        <asp:Button ID="GetDataBut" runat="server" Text="GetData" OnClick="GetDataBut_Click" />
        <asp:Button ID="InsertBut" runat="server" OnClick="InsertBut_Click" Text="Insert" />
        <asp:Button ID="UpdBut" runat="server" Text="Update" OnClick="UpdBut_Click" />
        <asp:Button ID="DelBut" runat="server" Text="Delete" OnClick="DelBut_Click" />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server" Text="LName"></asp:Label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="InsSub" runat="server" Text="Submit" OnClick="InsSub_Click" /><br />
        <asp:Label ID="UpdOldlab" runat="server" Text="Old LName"></asp:Label><asp:TextBox ID="UpdOldLName" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="UpdNewlab" runat="server" Text="New LName"></asp:Label><asp:TextBox ID="UpdNewLName" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="UpdSubmit" runat="server" Text="Submit" OnClick="UpdSubmit_Click" />
    </div>
    </form>
</body>
</html>
