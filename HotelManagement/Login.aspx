<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HotelManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="username: "></asp:Label>
            <asp:TextBox ID="uname" runat="server" style="margin-left: 10px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="password: "></asp:Label>
            <asp:TextBox ID="pwd" runat="server" style="margin-left: 10px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" style="margin-left: 57px" />
        </div>
        <br />
        <h3>Create an account? <a href="Registration.aspx">click here!</a></h3>
    </form>
</body>
</html>
