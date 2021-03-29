using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace Evaluation.Services
{
    public class RestConsumer
    {
        private static RestConsumer restConsumer;

        private RestConsumer() { }

        public static RestConsumer GetInstance()
        {
            if (restConsumer == null)
            {
                restConsumer = new RestConsumer();
            }
            return restConsumer;
        }

        public string Get(string Url)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/jason");
            webClient.Encoding = System.Text.Encoding.UTF8;
            return webClient.DownloadString(Url);
        }
    }
}