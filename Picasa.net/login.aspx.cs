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
using Picasa.net;


namespace Picasa.net
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GotoAuthSubLink.Visible = false;

            if (Session["token"] != null)
            {
                Response.Redirect("Default.aspx");
            }
            else if (Request.QueryString["token"] != null)
            {
                GAuthSubRequestFactory authFactory = new GAuthSubRequestFactory("lh2","exampleCo-exampleApp-1");
                authFactory.Token = (String)Session["token"];
                String token = Request.QueryString["token"];
                PicasaService service = new PicasaService(authFactory.ApplicationName);
                service.RequestFactory = authFactory;
                AlbumQuery query = new AlbumQuery(PicasaQuery.CreatePicasaUri("default"));
                /*PicasaFeed feed = service.Query(query);

                foreach (PicasaEntry entry in feed.Entries)
                {
                    AlbumAccessor ac = new AlbumAccessor(entry);

                }*/
                
                Session["token"] = AuthSubUtil.exchangeForSessionToken(token, null).ToString();
                Response.Redirect(Request.Url.AbsolutePath, true);
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