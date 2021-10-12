using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThisorThat.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public DateTime PostDate { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName  { get; set; }

        [Required]
        public string PersonId { get; set; }
    }
}

