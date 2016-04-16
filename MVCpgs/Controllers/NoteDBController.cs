using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCpgs.Models;

namespace MVCpgs.Controllers
{
    public class NoteDBController : Controller
    {
        // GET: NoteDB
        public ActionResult Index()
        {
            var entities = new NotesDBEntities();

            return View(entities.NoteViewModels.ToList());
        }
    }
}