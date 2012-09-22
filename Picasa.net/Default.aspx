<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Picasa.net._Default" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

<div class="row-fluid">    
    <ext:ResourceManager runat="server" />
         <ext:Store runat="server" ID="Store1">
            <Reader>
                <ext:JsonReader IDProperty="name">
                    <Fields>
                        <ext:RecordField Name="name" />
                        <ext:RecordField Name="url" />      
                    </Fields>
                </ext:JsonReader>
            </Reader>
        </ext:Store>   
                       
        <ext:Panel 
            ID="ImagePanel" 
            runat="server" 
            Cls="images-view" 
            Frame="true" 
            AutoHeight="true" 
           
            Collapsible="true" 
            Layout="Fit"
            Title="Fotos">
            <Items>
                <ext:DataView ID="ImageView" runat="server"
                    StoreID="Store1"
                    AutoHeight="true"
                    MultiSelect="true"
                    OverClass="x-view-over"
                    ItemSelector="div.thumb-wrap"
                    EmptyText="No images to display">
                    <Template runat="server">
                        <Html>
							<tpl for=".">
								<div class="thumb-wrap" id="{name}">
									<div class="thumb"><img src="{url}" title="{name}"></div>
									<span class="x-editable">{shortName}</span>
								</div>
							</tpl>
							<div class="x-clear"></div>    
						</Html>
                    </Template>                         
                    <PrepareData Fn="prepareData" />                
                    <Listeners>
                        <SelectionChange Fn="selectionChanged" /> 
                    </Listeners>   
                    
                    <Plugins>
                        <ext:GenericPlugin runat="server" InstanceName="Ext.DataView.DragSelector" />
                    </Plugins>
                </ext:DataView>
            </Items> 
   

   
            <Buttons>
                <ext:Button ID="Button1" runat="server" Text="Delete Album">
                    <DirectEvents>
                        <Click OnEvent="AlbumDelete_Click" />
                    </DirectEvents>
                </ext:Button>
            </Buttons>

            <Buttons>
                <ext:Button ID="Button2" runat="server" Text="Delete Selected Image">
                    <DirectEvents>
                        <Click OnEvent="Button1_Click" />
                    </DirectEvents>
                </ext:Button>
            </Buttons>
                  
        </ext:Panel>
  </div>
   
</asp:Content>
