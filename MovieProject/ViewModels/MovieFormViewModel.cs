﻿using MovieProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.ViewModels
{
    public class MovieFormViewModel
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1,10)]
        public double Rate { get; set; }

        [Required, StringLength(2500)]
        public string Storeline { get; set; }

        [Display(Name = "Select Poster...")]
        public byte[] Poster { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
