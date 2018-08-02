<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebProject.Login"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>www.login page</title>
</head>
<body style="width: 892px; height: 370px">
    <form id="form1" runat="server">
    <div>
         <p>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <a style="align-content:center; color:black;font-size:x-large">User Login Form</a>
        </p>
         <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Images/login_banner201.jpg" Height="332px" style="margin-right: 0px" Width="889px" Direction="LeftToRight" GroupingText="Login Authentication" Wrap="False">
         
             <br />
             <br />
         
        <br />
   &nbsp;&nbsp;&nbsp;<b>User Name:</b> 
    <asp:TextBox ID="txtuname" runat="server" Height="24px" Width="158px" ></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtuname" ErrorMessage="Enter the User Name" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
             <br />
             <br />
             &nbsp;&nbsp;&nbsp;<b>Password:</b>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtpsw" runat="server" Height="24px" TextMode="Password" Width="160px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpsw" ErrorMessage="Enter the Password" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
             <br />
             <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnlogin" runat="server" Text="Login" Width="65px" OnClick="btnlogin_Click" />
             &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" Width="65px" />
&nbsp;
             <asp:Button ID="btnHelp" runat="server" Text="Help" Width="65px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="lblstatus" runat="server"></asp:Label>
             <br />
             <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lnbnewuserregi" runat="server" ForeColor="#660066" OnClick="lnbnewuserregi_Click" Text="* New user Register!" Visible="true"></asp:LinkButton>
             <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       </asp:Panel>
    </div>
    </form>
</body>
</html>
