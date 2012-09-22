<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPicture.aspx.cs" Inherits="Picasa.net.AddPicture" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {

       /* ArrayList list = new ArrayList();
        ArrayList list1 = new ArrayList();
        foreach (Google.GData.Photos.PicasaEntry entry in Session["lt"] as Google.GData.Client.AtomEntryCollection)
        {
            Google.GData.Photos.AlbumAccessor ac = new Google.GData.Photos.AlbumAccessor(entry);
            list.Add(ac.AlbumTitle);
            list1.Add(ac.Id);
        }

        List<object[]> data = new List<object[]>();
        
        for (int i = 0; i < list.Count; i++)
        {
            String name=list[i].ToString();
            String id = list1[i].ToString();
            data.Add(new object [] {name,id});
        }
        this.Store1.DataSource = data;
        
        this.Store1.DataBind();*/
        
    }
</script>



<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server">
    </ext:ResourceManager>

    <ext:Store ID="Store1" runat="server">
            <Reader>
                <ext:ArrayReader>
                    <Fields>
                        <ext:RecordField Name="abbr" />
                        <ext:RecordField Name="id" />
                    </Fields>
                </ext:ArrayReader>
            </Reader>            
        </ext:Store>

        <div class = "row-fluid"  >
    <ext:FormPanel ID="BasicForm" runat="server" Frame="true" Title="File Upload Form"
        AutoHeight="true" MonitorValid="true" PaddingSummary="10px 10px 0 10px" LabelWidth="50">
        <Defaults>
            <ext:Parameter Name="anchor" Value="95%" Mode="Value" />
            <ext:Parameter Name="allowBlank" Value="false" Mode="Raw" />
            <ext:Parameter Name="msgTarget" Value="side" Mode="Value" />
        </Defaults>
        <Items>
            <%--<ext:ComboBox ID="ComboBox1" runat="server" DisplayField="abbr" ValueField="id" FieldLabel="Nombre del Album"
                StoreID="Store1" Editable="false" TypeAhead="true" Mode="Local" ForceSelection="true"
                EmptyText="Seleccione un album..." Resizable="true" SelectOnFocus="true" />--%>
            <ext:FileUploadField ID="FileUploadField1" runat="server" EmptyText="Select an image"
                FieldLabel="Photo" ButtonText="" Icon="ImageAdd" >
                <DirectEvents>
                <FileSelected OnEvent="FileSelected" />
            </DirectEvents>
                </ext:FileUploadField>
        </Items>
        <Buttons>
         <ext:Button ID="SaveButton" runat="server" Text="Save">
                    <DirectEvents>
                        <Click 
                            OnEvent="UploadClick"
                            Before="if (!#{BasicForm}.getForm().isValid()) { return false; } 
                                Ext.Msg.wait('Uploading your photo...', 'Uploading');"
                                
                            Failure="Ext.Msg.show({ 
                                title   : 'Error', 
                                msg     : 'Error during uploading', 
                                minWidth: 200, 
                                modal   : true, 
                                icon    : Ext.Msg.ERROR, 
                                buttons : Ext.Msg.OK 
                            });">
                        </Click>
                    </DirectEvents>
                </ext:Button>

            <ext:Button ID="Button1" runat="server" Icon="Disk" Text="Submit">
        <DirectEvents>
            <Click OnEvent="on_Click">
            </Click>
        </DirectEvents>
    </ext:Button>
        </Buttons>
    </ext:FormPanel>

    </div>
     

   

</asp:Content>
