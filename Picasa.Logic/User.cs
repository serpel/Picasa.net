using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Picasa;
using Google.GData.Photos;
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.Extensions.Location;

namespace Picasa.Logic
{
    public class User
    {
        string _username;
        public string Username
        {
            set{ this._username = value; }
            get { return this._username; }
        }
    }
}
