<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Picasa.net._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

   <div class="row-fluid">
        <ul class="thumbnails">
            <li class="span4">
                <div class="thumbnail">
                    <img src="img/Corvette.png" alt="" />
                    <h3>
                        Album title</h3>
                    <p>
                        Lexury cars!</p>
                </div>
            </li>
            <li class="span3"><a href="#" class="thumbnail">
                <img src="img/lambo.jpg" alt="">
            </a></li>
            <li class="span4"><a href="#" class="thumbnail">
                <img src="img/mustang.jpg" alt="">
            </a>
            </li>
             <li class="span4"><a href="#" class="thumbnail">
                <img src="img/lambo.jpg" alt="">
            </a></li>
            <li class="span3"><a href="#" class="thumbnail">
                <img src="img/Corvette.png" alt="">
            </a>
            </li>
        </ul>
    </div>

   
</asp:Content>
