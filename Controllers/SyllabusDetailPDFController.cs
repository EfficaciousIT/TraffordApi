﻿using System;
using TraffordSchool.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
namespace TraffordSchool.Controllers
{
    public class SyllabusDetailPDFController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string command, string intSTD_id, string intSubject_id, string intSchool_id)
        {
            Syllabus syllabus = new Syllabus();
            syllabus.intSchool_id = Convert.ToInt32(intSchool_id);
            syllabus.intSTD_id = Convert.ToInt32(intSTD_id);
            syllabus.intSubject_id = Convert.ToInt32(intSubject_id);
            DataSet ds = record.SyllabusDetailsPDF(command, syllabus);
            return ds;
        }
    }
}
