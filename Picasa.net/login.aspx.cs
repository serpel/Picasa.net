using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Google.Picasa;
using Google.GData.Photos;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Extensions.Location;
using Picasa.Logic;
using Picasa.net;


namespace Picasa.net
{
    public partial class login : System.Web.UI.Page
    {

        private static PicasaService m_picasaService;

        public static PicasaService PicasaService
        {
            get
            {
                if (m_picasaService == null)
                    m_picasaService = new PicasaService("PhotoBrowser");
                return m_picasaService;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            GotoAuthSubLink.Visible = false;

            if (Session["token"] != null)
            {
                Response.Redirect("Default.aspx");
            }
            else if (Request.QueryString["token"] != null)
            {
                User u = new User();
                u.Username = "diegoturciostc@gmail.com";
                u.Password = "87654321q";

                PicasaService.setUserCredentials(u.Username, u.Password);

                AlbumQuery albumQuery = new AlbumQuery();
                albumQuery.Uri = new Uri(PicasaQuery.CreatePicasaUri(u.Username));
                //albumQuery.Access = PicasaQuery.AccessLevel.AccessPublic;

                PicasaFeed feed = PicasaService.Query(albumQuery);

                Session["feed"] = feed;
                Session["service"] = PicasaService;
                Session["user"] = u;

                if (feed.Entries.Count > 0)
                {
                    AlbumAccessor myAlbum = new AlbumAccessor((PicasaEntry)feed.Entries[0]);
                    Response.Redirect("Default.aspx?album=" + myAlbum.Id, true);
                }
                else
                {
                    Response.Redirect("Default.aspx", true);
                }
            }
            else //no auth data, print link
            {
                GotoAuthSubLink.Text = "Login to your Google Account";
                GotoAuthSubLink.Visible = true;
                GotoAuthSubLink.NavigateUrl = AuthSubUtil.getRequestUrl(Request.Url.ToString(),
                    "https://picasaweb.google.com/data/", false, true);
            }
        }

        public void loginpicasa(object sender, DirectEventArgs e)
        {
            Response.Redirect("GotoAuthSubLink");
            //askForLogin();
        }

    }
}