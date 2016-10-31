<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gamepage.aspx.cs" Inherits="find_me_if_you_can.gamepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    
<style>
html,body{
width:100%;
height:100%;
overflow:hidden;
margin:0px;
}
span{
position:relative;
display:inline-block;
top:0px;
border:1px solid black;
text-align:center;

width:3%;

 -webkit-touch-callout: none;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}
span:hover{
position:relative;
background:red;
border:2px solid black;
 -webkit-touch-callout: none;
    -webkit-user-select: none;
    -khtml-user-select: none;
    -moz-user-select: none;
    -ms-user-select: none;
    user-select: none;
}
#main{

position:relative;
margin:2px;

}

</style>
<form id="form1" runat="server">
    
    

</form>
    <div id="show" runat="server"></div>
</body>
</html>
