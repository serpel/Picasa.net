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

namespace Picasa.net
{
    public partial class AddPicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void on_Click(object sender, DirectEventArgs e)
        {
            String name = ComboBox1.SelectedItem.Value;
            String file = FileUploadField1.PostedFile.FileName;

            

            /*Uri postUri = new Uri(PicasaQuery.CreatePicasaUri("diegoturciostc@gmail.com", name));

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
            System.IO.FileStream fileStream = fileInfo.OpenRead();

            PicasaEntry entry = (PicasaEntry)service.Insert(postUri, fileStream, "image/jpeg", file);

            fileStream.Close();*/
        }
    }


}