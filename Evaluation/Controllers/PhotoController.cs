using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evaluation.Services;
using Evaluation.Models;
using Newtonsoft.Json;

namespace Evaluation.Controllers
{
    public class PhotoController : Controller
    {
        private PhotoDataManager photoDataManager = PhotoDataManager.GetInstance();


        // GET: Photo
        public ActionResult Index(int AlbumId = 0)
        {
            if (AlbumId != 0)
            {
                return View(photoDataManager.GetPhotosByAlbum(AlbumId));
            }
            return View(photoDataManager.GetPhotos());
        }

        public string Show(int id)
        {
            return JsonConvert.SerializeObject(photoDataManager.GetPhotoById(id));
        }
    }
}