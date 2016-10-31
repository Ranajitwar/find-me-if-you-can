<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="find_me_if_you_can.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="Button1" runat="server"  Text="New Game" TabIndex="0" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Score" Width="97px" TabIndex="1" />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Moregames" Width="98px" TabIndex="2" />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Exit" Width="65px" TabIndex="3" />
    </form>
</body>
</html>
