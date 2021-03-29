using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Evaluation.Models;
using Evaluation.Utils;
using Newtonsoft.Json;

namespace Evaluation.Services
{
    public class CommentDataManager
    {
        private RestConsumer restConsumer = RestConsumer.GetInstance();
        private const string RESOURCE = "/comments";

        private static CommentDataManager commentDataManager;

        private CommentDataManager() { }

        public static CommentDataManager GetInstance()
        {
            if (commentDataManager == null)
            {
                commentDataManager = new CommentDataManager();
            }
            return commentDataManager;
        }

        public List<Comment> GetComments()
        {
            string response = restConsumer.Get(ConstantsUtils.BASE_URL + RESOURCE);
            if (response != null)
            {
                return JsonConvert.DeserializeObject<List<Comment>>(response);
            }
            return new List<Comment>();
        }
    }
}