﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TraffordSchool.Models;
using System.Data;

namespace TraffordSchool.Controllers
{
    public class NoticeboardController : ApiController
    {
        Database.DB record = new Database.DB();
        public HttpResponseMessage Post(string command, Noticeboard noticeboard)
        {
            try
            {
                DataSet ds = record.NoticeboardDetail(command, noticeboard);
                var message = Request.CreateResponse(HttpStatusCode.Created);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
