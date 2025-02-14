﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi.Models
{
    [Table("Turler")]
    public class Tur
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string TurAd { get; set; }

        public virtual ICollection<Film> Filmler { get; set; }
    }
}
