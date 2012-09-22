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
        private string _username;
        private string _password;
        public string Username
        {
            set{ this._username = value; }
            get { return this._username; }
        }

        public string Password
        {
            set { this._password = value; }
            get { return this._password; }
        }


    }
}
