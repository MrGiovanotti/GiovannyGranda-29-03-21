using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Evaluation.Services;

namespace Evaluation.Controllers
{
    public class AlbumController : Controller
    {

        private AlbumDataManager albumDataManager = AlbumDataManager.GetInstance();

        // GET: Album
        public ActionResult Index()
        {
            return View(albumDataManager.GetAlbums());
        }
    }
}