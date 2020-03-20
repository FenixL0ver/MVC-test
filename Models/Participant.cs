using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TryOut.Models
{
    public class Participant
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Нет логина")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Нет имени")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Нет фамилии")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Нет возраста")] [Range(1,100,ErrorMessage ="Неверный возраст")]
        public int Age { get; set; }

        public Team Team { get; set; }
    }
}