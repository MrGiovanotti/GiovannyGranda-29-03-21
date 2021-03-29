using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evaluation.Models;
using Evaluation.Utils;
using Newtonsoft.Json;

namespace Evaluation.Services
{
    public class AlbumDataManager
    {
        private RestConsumer restConsumer = RestConsumer.GetInstance();
        private const string RESOURCE = "/albums";

        private static AlbumDataManager albumDataManager;

        private AlbumDataManager() { }

        public static AlbumDataManager GetInstance()
        {
            if (albumDataManager == null)
            {
                albumDataManager = new AlbumDataManager();
            }
            return albumDataManager;
        }

        public List<Album> GetAlbums()
        {
            string response = restConsumer.Get(ConstantsUtils.BASE_URL + RESOURCE);
            if (response != null)
            {
                return JsonConvert.DeserializeObject<List<Album>>(response);
            }
            return new List<Album>();
        }
    }
}