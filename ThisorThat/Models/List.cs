using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThisorThat.Models
{
    public class List
    {
        [Range(1, 99999)]
        [Display(Name = "List Id")]
        public int ListId { get; set; }

        [Required(ErrorMessage = "Please fill this field out!")]

        public string Name { get; set; }

    }
}
