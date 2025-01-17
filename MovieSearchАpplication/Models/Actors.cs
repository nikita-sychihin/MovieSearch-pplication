﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSearchАpplication.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Films> Films { get; set; }

        public Actors()
        {
            Films = new List<Films>();
        }
    }
}