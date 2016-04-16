using MVCpgs.Models;
using MVCpgs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCpgs.Controllers
{
    public class NoteController : Controller
    {
        NoteService _noteService;

        public NoteController()
        {
            _noteService = new NoteService();
        }
        [HttpGet]
        public ActionResult Note()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Note(NoteViewModels noteViewModels)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _noteService.SaveToDB(noteViewModels);

            return View("SendedNote", noteViewModels);
        }
    }
}