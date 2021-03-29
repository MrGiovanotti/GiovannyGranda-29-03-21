using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evaluation.Models;
using Evaluation.Utils;
using Newtonsoft.Json;

namespace Evaluation.Services
{
    public class PhotoDataManager
    {
        private RestConsumer restConsumer = RestConsumer.GetInstance();
        private const string RESOURCE = "/photos";

        private static PhotoDataManager photoDataManager;

        private PhotoDataManager() { }

        public static PhotoDataManager GetInstance()
        {
            if (photoDataManager == null)
            {
                photoDataManager = new PhotoDataManager();
            }
            return photoDataManager;
        }

        public List<Photo> GetPhotos()
        {
            string response = restConsumer.Get(ConstantsUtils.BASE_URL + RESOURCE);
            if (response != null)
            {
                return JsonConvert.DeserializeObject<List<Photo>>(response);
            }
            return new List<Photo>();
        }

        public Photo GetPhotoById(int id)
        {
            string response = restConsumer.Get(ConstantsUtils.BASE_URL + RESOURCE + "?id=" + id);
            if (response != null)
            {
                return JsonConvert.DeserializeObject<List<Photo>>(response)[0];
            }
            return null;
        }

        public List<Photo> GetPhotosByAlbum(int AlbumId)
        {
            string response = restConsumer.Get(ConstantsUtils.BASE_URL + RESOURCE + "?albumId=" + AlbumId);
            if (response != null)
            {
                return JsonConvert.DeserializeObject<List<Photo>>(response);
            }
            return new List<Photo>();
        }
    }
}