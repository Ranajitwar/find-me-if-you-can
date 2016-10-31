<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asknumber.aspx.cs" Inherits="find_me_if_you_can.asknumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>game2</title>
</head>

<body>
        <form name="form1" runat="server">
         <p>Starting Number: <input type="text" id="start_number" name="crypto1" runat="server" value=0/></p>
        <p>Ending Number: <input type="text" id="end_number" name="crypto2" runat="server" value=0/></p>
        <p>Interval: <input type="text" id="interval_num" name="crypto3" runat="server" value=0/></p>
   
      <p><asp:Button ID="submit1" runat="server" OnClick="submitform" Text="Submit"  />
</p>
 
         </form>
      


        <h1 id="xyz" runat="server"></h1>
       
    
</body>
</html>
