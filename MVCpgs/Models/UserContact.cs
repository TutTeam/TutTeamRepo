using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCpgs.Models
{
    public class UserContact
    {
        [Required(ErrorMessage = "Proszę podać swoje Imię i Nazwisko!")]
        [Display(Name = "imie i nazwisko:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać swój e-mail!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="prosze podać poprawny adres")]
        [Display(Name = "E-mail:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę udzielić odpowiedzi")]
        [Display(Name = "Czy lubisz piwo ziomeczku?:")]
        public bool LikeBeer { get; set; }

        [Required(ErrorMessage = "Twoja wiadomość jest za krótka")]
        [Display(Name = "Pytanie:")]
        [MinLength(10)]
        public string MsgToUs { get; set; }



    }
}