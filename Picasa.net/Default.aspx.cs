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
using Picasa.net;


namespace Picasa.net
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*AlbumQuery query = new AlbumQuery(PicasaQuery.CreatePicasaUri("default"));
            PicasaFeed feed = picassa_info.service.Query(query);

            foreach (PicasaEntry entry in feed.Entries)
            {
                //Console.WriteLine(entry.Title.Text);
                AlbumAccessor ac = new AlbumAccessor(entry);
                //Console.WriteLine(ac.NumPhotos);
            }*/
        }
    }
}
