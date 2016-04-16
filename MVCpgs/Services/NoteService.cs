using MVCpgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVCpgs.Services
{
    public class NoteService
    {


        public async Task SaveToDB(NoteViewModels noteViewModels)
        {
            using (var ctx = new NotesDBEntities())
            {
                var note = new NoteViewModels()
                {
                    Name = noteViewModels.Name,
                    Title = noteViewModels.Title,
                    Note = noteViewModels.Note,
                    hasz = noteViewModels.hasz
                };

                ctx.Notes.Add(note);
                ctx.SaveChanges();

                await ctx.SaveChangesAsync();

               
               
            }
        }
    }
}