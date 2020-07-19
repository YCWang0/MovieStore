using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Entities
{
    public class Detail
    {

        public Movie DetailMovie { get; set; }
        public IEnumerable<Cast> DetailCast { get; set; }
        public Decimal DetailRating { get; set; }
        public IEnumerable<Genre> DetailGenre { get; set; }
    }
}
