<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateDBI.aspx.cs" Inherits="WebProject.UpdateDBI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>www.UpdateDBIpage</title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a>Data base information update page</a><br />
&nbsp;<div>
    <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
        <br />
    <br />
    <asp:Label ID="lblPsw" runat="server" Text="Password:"></asp:Label>&nbsp&nbsp&nbsp;
    <asp:TextBox ID="txtPsw" runat="server" ></asp:TextBox>
        <br />
    <br />
    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
        <br />
    <br />
        <asp:Label ID="lblMobile" runat="server" Text="MobileNo:"></asp:Label>&nbsp&nbsp
    <asp:TextBox ID="txtMobile" runat="server" ></asp:TextBox>
        <br />
    <br />
        <asp:Label ID="lblEmail" runat="server" Text="EmailId:"></asp:Label>&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" Text="Update" Width="65px" />&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="65px" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblStatus" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
