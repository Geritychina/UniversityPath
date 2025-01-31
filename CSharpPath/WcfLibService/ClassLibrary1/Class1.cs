using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Sample(string id)
        {
            var bgTollUrl = "https://check.bgtoll.bg/check/vignette/plate/BG/";

            var client = new WebClient();
            var body = "";


            if (id != null && id != "")
            {

                body = client.DownloadString(bgTollUrl + id);

            }
            else
            {
                body = "Please enter valid number!";
            }

            return body;

        }

    }
}
