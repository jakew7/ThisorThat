using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThisorThat.Models
{
    public class List
    {
        public int ListId { get; set; }

        [Required(ErrorMessage = "Please fill this field out!")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill this field out!")]
        public string Description { get; set; }

        //child reference for Items
        public List<Item> Items { get; set; }

    }
}
