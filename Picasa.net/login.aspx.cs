﻿using System;
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
                //Session["token"] = Request.QueryString["token"];
                //GAuthSubRequestFactory authFactory = new GAuthSubRequestFactory("lh2","picasa.net");
                //authFactory.Token = (String)Session["token"];
                //String token = Request.QueryString["token"];

                AlbumQuery albumQuery = new AlbumQuery();
                albumQuery.Uri = new Uri(PicasaQuery.CreatePicasaUri("diegoturciostc@gmail.com"));
                albumQuery.Access = PicasaQuery.AccessLevel.AccessPublic;

                PicasaFeed feed = PicasaService.Query(albumQuery);

                Session["feed"] = feed;


                List<PicasaEntry> tmp = new List<PicasaEntry>();
                foreach (PicasaEntry entry in feed.Entries)
                {
                    tmp.Add(entry);
                    //AlbumAccessor ac = new AlbumAccessor(entry);
                }

                Session["lt"] = tmp;



                //Response.Write("<script type='text/javascript'>alert("+txtAlbum+");</script>");       
                //Session["token"] = AuthSubUtil.exchangeForSessionToken(token, null).ToString();
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