<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="DetailsAlbum.aspx.cs" Inherits="Picasa.net.Details" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:ResourceManager runat="server">
    </ext:ResourceManager>
    <div class="page-header">
        <h1>
            Example Album Title <small>Subtext for date or other thing</small></h1>
    </div>

    <div class="btn-group">
        <button class="btn">
            Add</button>
        <button class="btn">
            Edit</button>
        <button class="btn">
            Delete</button>
    </div>

    <!--Separator-->
    <div class="page-header">
    </div>

    <div class="btn-group">
       <%-- <ext:Toolbar ID="Toolbar1" runat="server" Split="False" LabelAlign="Right">
            <Items>
                <ext:Button ID="b1" runat="server" Text="Button1">
                </ext:Button>
            </Items>
        </ext:Toolbar>--%>
    </div>
    <%--<div class="hero-unit">--%>
        <div class="row-fluid">
            <ul class="thumbnails">
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/lambo.jpg" alt="">
                </a></li>
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/mustang.jpg" alt="">
                </a></li>
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/lambo.jpg" alt="">
                </a></li>
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/Corvette.png" alt="">
                </a></li>
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/lambo.jpg" alt="">
                </a></li>
                <li class="span3"><a href="#" class="thumbnail">
                    <img src="img/Corvette.png" alt="">
                </a></li>
            </ul>
        </div>
    <%--</div>--%>
</asp:Content>
