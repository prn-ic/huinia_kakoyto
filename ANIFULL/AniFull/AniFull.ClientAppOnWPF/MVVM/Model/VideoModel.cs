using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniFull.ClientAppOnWPF.MVVM.Model
{
    class Videos
    {
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public string? Logo { get; set; }
        public string? TitleAnime { get; set; }
        public string? VideoURI { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }

    }
}
