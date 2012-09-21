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
        string Name="";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void on_Click(object sender, DirectEventArgs e)
        {
            String name = ComboBox1.SelectedItem.Value;

            string path = this.FileUploadField1.FileName;
            path = Server.MapPath(path);

            Uri postUri = new Uri(PicasaQuery.CreatePicasaUri("diegoturciostc@gmail.com","5680246730142935889"));

            System.IO.Stream fileInfo = this.FileUploadField1.PostedFile.InputStream;
            int buffer=1024*1024;
            System.IO.FileStream filestream = null;//new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            filestream = System.IO.File.Create(path);

            filestream.SetLength(fileInfo.Length);
            int bytesRead = -1;
            byte[] bytes = new byte[buffer];
            while ((bytesRead = fileInfo.Read(bytes,0,buffer) ) >0)
            {
                filestream.Write(bytes, 0, bytesRead);
            }
            PicasaService tmp=Session["service"] as PicasaService;

            PicasaEntry entry = (PicasaEntry)tmp.Insert(postUri, filestream, "image/jpeg", path);
            filestream.Close();

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        protected void FileSelected(object sender, DirectEventArgs e)
        {

            
            string path = this.FileUploadField1.FileName;
            path = Server.MapPath(path);
            System.IO.FileInfo info = new System.IO.FileInfo(this.FileUploadField1.FileName);
            string _path = info.DirectoryName; 
            
            X.Msg.Alert("Upload", path).Show();
            
        }

        protected void UploadClick(object sender, DirectEventArgs e)
        {
            string tpl = "Uploaded file: {0}<br/>Size: {1} bytes";

            if (this.FileUploadField1.HasFile)
            {
                X.Msg.Show(new MessageBoxConfig
                {
                    Buttons = MessageBox.Button.OK,
                    Icon = MessageBox.Icon.INFO,
                    Title = "Success",
                    Message = string.Format(tpl, this.FileUploadField1.PostedFile.FileName, this.FileUploadField1.PostedFile.ContentLength)
                });
            }
            else
            {
                X.Msg.Show(new MessageBoxConfig
                {
                    Buttons = MessageBox.Button.OK,
                    Icon = MessageBox.Icon.ERROR,
                    Title = "Fail",
                    Message = "No file uploaded"
                });
            }
        }
    }


}