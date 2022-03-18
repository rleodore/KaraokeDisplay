using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KaraokeDisplay.Models
{
    public class RequestModel
    {
        [Key]
        public int Id { get; set; }
        public int SongId { get; set; }
        public string RequesterName { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
    }
}
