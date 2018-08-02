<%@ Page Language="C#" AutoEventWireup="true" Inherits="WebProject.Home" MasterPageFile="~/MainMasterPage.Master" Title="www.Home Page" CodeFile="~/Home.aspx.cs"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrap">
<div id="right">
<h1>Index</h1>
	<ul>
		<li><a>Home</a></li>
		<li><a>AboutUs</a></li>
		<li><a>Gallery</a></li>
		<li><a>Registration</a></li>
		<li><a>Login</a></li>
        <li><a>ContactUs</a></li>
	</ul>
</div>
<div id="content">
    <asp:Image ID="img2" runat="server" ImageUrl="~/Images/welcome-message-winter-background-blue.jpg" ToolTip="This is an image" Height="303px" Width="806px" />
    </div>
        </div>
 </asp:Content>
