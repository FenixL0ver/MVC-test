using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TryOut.Models
{
    public class Team
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Нет имени клуба")]
        public string Name { get; set; }

        public List<Participant> Participants { get; set; }
    }
}