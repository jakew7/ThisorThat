﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThisorThat.Models
{
    public class Item
    {
        public int ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string ItemDescription { get; set; }

        [Required]
        public string Brand { get; set; }
       
        [Required]
        public int ListId { get; set; }

        [Required]
        public string Photo { get; set; }

        //Parent reference for List
        public List<Item> Items { get; set; }


    }
}