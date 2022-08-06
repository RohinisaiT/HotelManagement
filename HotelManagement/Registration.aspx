<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="HotelManagement.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="username: "></asp:Label>
            <asp:TextBox ID="uname" runat="server" style="margin-left: 33px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="password: "></asp:Label>
            <asp:TextBox ID="pwd" runat="server" style="margin-left: 31px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="email: "></asp:Label>
            <asp:TextBox ID="txtemail" runat="server" style="margin-left: 58px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="mobilenumber: "></asp:Label>
            <asp:TextBox ID="mobnum" runat="server" style="margin-left: 5px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="signup!" OnClick="Button1_Click" style="margin-left: 81px" />
        </div>
    </form>
</body>
</html>
