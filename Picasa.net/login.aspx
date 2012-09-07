<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Picasa.net.login" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">




<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Picasa Net Login</title>
    <link href="css/login.css" rel="stylesheet" type="text/css" />
</head>
<body background="img/watermark.png">
    <form id="form1" runat="server">
    
    </form>
</body>
<h1>
<a href="login.aspx">
   <img  alt="PicasaNet" src="img/logo_picasa_large.png" />
</a>
</h1>

<div class="header">
    <p class="download windows">
    <asp:HyperLink ID="GotoAuthSubLink" runat="server"/>
       <ext:ResourceManager ID="ResourceManager1" runat=server></ext:ResourceManager>
        <ext:HyperLink  runat="server" 
         Cls = "download"
        ImageUrl = "img/pika.png" >
        </ext:HyperLink>
    </p>
    <h2>
        Ingresa a Picasa Net
    </h2>
</div>


</html>
