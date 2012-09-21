using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Picasa;
using Google.GData.Photos;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Extensions.Location;
using Ext.Net;
using Picasa.Logic;
using Picasa.net;


namespace Picasa.net
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!X.IsAjaxRequest)
            {
                if ( Session["user"] != null && Request.QueryString["album"] != null)
                {
                    PhotoQuery query = new PhotoQuery(PicasaQuery.CreatePicasaUri(((User)Session["user"]).Username, Request.QueryString["album"] as string));

                    PicasaService tmp = Session["service"] as PicasaService;
                    PicasaFeed feed = tmp.Query(query);

                    List<object> data = new List<object>(feed.Entries.Count);
                    foreach (PicasaEntry entry in feed.Entries)
                    {
                        Console.WriteLine(entry.Title.Text);
                        data.Add(new
                        {
                            name = entry.Title.Text,
                            url = entry.Content.AbsoluteUri,
                        });
                    }
                    this.Store1.DataSource = data;
                    this.Store1.DataBind();

                }
            }
        }
    }
}
