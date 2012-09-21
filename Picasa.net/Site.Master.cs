using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Picasa.Logic;
using Google.Picasa;
using Google.GData.Photos;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Extensions.Location;
using Ext.Net;

namespace Picasa.net
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if (Session["lt"] != null && Session["feed"] != null)
                {
                    PicasaFeed feed = Session["feed"] as PicasaFeed;

                    //int count = 0;
                    //foreach (PicasaEntry entry in feed.Entries)
                    //{
                    //    AlbumAccessor myAlbum = new AlbumAccessor((PicasaEntry)entry);
                    //    entry.Etag = myAlbum.Id;
                    //    feed.Entries[count] = entry;
                    //    count++;
                    //}
                    this.Repeater1.DataSource = feed.Entries;
                    this.Repeater1.DataBind();
                }

                if (Session["user"] != null)
                {
                    Label_user.Text = ((User)Session["user"]).Username;
                }
            }
        }
    }
}
